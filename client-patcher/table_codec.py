"""Read GF2's indexed protobuf tables without loading or running game code.

Only the Python standard library is needed. Unknown protobuf fields are retained
when a table is rebuilt. All offsets are checked before use.
"""
from __future__ import annotations

import struct
from dataclasses import dataclass
from pathlib import Path


def varint(data: bytes, pos: int = 0) -> tuple[int, int]:
    value = 0
    for shift in range(0, 70, 7):
        if pos >= len(data):
            raise ValueError("Truncated varint")
        byte = data[pos]
        pos += 1
        if shift == 63 and byte > 1:
            raise ValueError("Varint exceeds 64 bits")
        value |= (byte & 127) << shift
        if not byte & 128:
            return value, pos
    raise ValueError("Oversized varint")


def encode_varint(value: int) -> bytes:
    if value < 0:
        value &= (1 << 64) - 1
    out = bytearray()
    while value >= 128:
        out.append((value & 127) | 128)
        value >>= 7
    out.append(value)
    return bytes(out)


@dataclass(frozen=True)
class Field:
    number: int
    wire: int
    value: int | bytes
    raw: bytes
    start: int
    end: int


def fields(data: bytes):
    pos = 0
    while pos < len(data):
        start = pos
        tag, pos = varint(data, pos)
        number, wire = tag >> 3, tag & 7
        if not 0 < number < (1 << 29):
            raise ValueError("Invalid field number")
        if wire == 0:
            value, pos = varint(data, pos)
        elif wire in (1, 5):
            end = pos + (8 if wire == 1 else 4)
            value = data[pos:end]
            pos = end
        elif wire == 2:
            size, pos = varint(data, pos)
            end = pos + size
            value = data[pos:end]
            pos = end
        else:
            raise ValueError(f"Unsupported wire type {wire}")
        if pos > len(data):
            raise ValueError("Field exceeds message bounds")
        yield Field(number, wire, value, data[start:pos], start, pos)


def encode_field(number: int, value: int | bytes) -> bytes:
    if isinstance(value, int):
        return encode_varint(number << 3) + encode_varint(value)
    return encode_varint((number << 3) | 2) + encode_varint(len(value)) + value


def unpack_table(data: bytes) -> tuple[bytes, bytes]:
    if len(data) < 4:
        raise ValueError("Missing table header")
    header_size = struct.unpack_from("<I", data)[0]
    if header_size + 4 > len(data):
        raise ValueError("Header exceeds file bounds")
    return data[4:4 + header_size], data[4 + header_size:]


def rows(data: bytes):
    _, payload = unpack_table(data)
    for field in fields(payload):
        if field.number != 1 or field.wire != 2:
            raise ValueError("Unexpected table wrapper field")
        yield field


def language_rows(data: bytes) -> dict[int, str]:
    result = {}
    for row in rows(data):
        value = {field.number: field.value for field in fields(row.value)}
        key = value.get(1, 0)
        if key in result:
            raise ValueError(f"Duplicate language ID {key}")
        result[key] = value.get(2, b"").decode("utf-8")
    return result


def replace_fields(message: bytes, replacements: dict[int, int | bytes]) -> bytes:
    """Replace known singular fields and retain every unknown field verbatim."""
    output = bytearray()
    remaining = dict(replacements)
    seen = set()
    for field in fields(message):
        if field.number in replacements:
            if field.number in seen:
                raise ValueError("Duplicate singular field")
            output += encode_field(field.number, replacements[field.number])
            remaining.pop(field.number, None)
            seen.add(field.number)
        else:
            output += field.raw
    for number, value in remaining.items():
        # Protobuf omits scalar default values.
        if value not in (0, b""):
            output += encode_field(number, value)
    return bytes(output)


def index_entries(header: bytes):
    for field in fields(header):
        if field.number == 3 and field.wire == 2:
            entry = {f.number: f.value for f in fields(field.value)}
            location = {f.number: f.value for f in fields(entry[2])}
            yield field, entry.get(1, 0), location.get(1, 0), location.get(2, 0)


def validate_language_table(data: bytes) -> int:
    return validate_table(data, language=True)


def validate_table(data: bytes, language=False) -> int:
    """Validate the index as the client's lazy reader sees it, including gaps."""
    header, payload = unpack_table(data)
    meta = {f.number: f.value for f in fields(header) if f.wire == 0}
    group_size = meta.get(1, 0)
    if group_size <= 0:
        raise ValueError("Missing index group size")
    segments = sorted(index_entries(header), key=lambda item: item[2])
    cursor = 0
    total = 0
    seen_ids = set()
    for _, bucket, offset, length in segments:
        if offset != cursor or length <= 0 or offset + length > len(payload):
            raise ValueError("Invalid or overlapping index range")
        for row in fields(payload[offset:offset + length]):
            if row.number != 1 or row.wire != 2:
                raise ValueError("Invalid indexed row")
            value = {f.number: f.value for f in fields(row.value)}
            row_id = value.get(1, 0)
            wrong_bucket = row_id // group_size != bucket if meta.get(2) == 1 else bucket != 0
            if row_id in seen_ids or wrong_bucket:
                raise ValueError("Index bucket does not match row ID")
            if language:
                value.get(2, b"").decode("utf-8", errors="strict")
            seen_ids.add(row_id)
            total += 1
        cursor += length
    if cursor != len(payload):
        raise ValueError("Index does not cover all rows")
    if meta.get(2) != 1 and total != group_size:
        raise ValueError("Linear index row count mismatch")
    return total


def patch_language_table(data: bytes, replacements: dict[int, str]) -> bytes:
    """Change selected text, preserving row order/IDs and rebuilding index ranges."""
    return patch_table(data, {key: {2: text.encode("utf-8")} for key, text in replacements.items()})


def patch_table(data: bytes, replacements: dict[int, dict[int, int | bytes]]) -> bytes:
    """Change selected singular fields and rebuild offsets without reordering rows."""
    validate_table(data)
    header, payload = unpack_table(data)
    updated = bytearray()
    boundaries = {0: 0}
    applied = set()
    for row in fields(payload):
        if row.number != 1 or row.wire != 2:
            raise ValueError("Unexpected table wrapper")
        value = {f.number: f.value for f in fields(row.value)}
        row_id = value.get(1, 0)
        boundaries[row.start] = len(updated)
        if row_id in replacements:
            changes = replacements[row_id]
            if all(value.get(key, 0 if isinstance(val, int) else b"") == val for key, val in changes.items()):
                updated += row.raw
            else:
                updated += encode_field(1, replace_fields(row.value, changes))
            applied.add(row_id)
        else:
            updated += row.raw
        boundaries[row.end] = len(updated)
    if applied != set(replacements):
        raise ValueError(f"Replacement IDs not found: {set(replacements) - applied}")
    new_header = bytearray()
    for field in fields(header):
        if field.number == 3 and field.wire == 2:
            entry = {f.number: f.value for f in fields(field.value)}
            location = {f.number: f.value for f in fields(entry[2])}
            old_start = location.get(1, 0)
            old_end = old_start + location.get(2, 0)
            if old_start not in boundaries or old_end not in boundaries:
                raise ValueError("Index does not point to row boundaries")
            new_start, new_end = boundaries[old_start], boundaries[old_end]
            new_location = replace_fields(entry[2], {1: new_start, 2: new_end - new_start})
            new_header += encode_field(3, replace_fields(field.value, {2: new_location}))
        else:
            new_header += field.raw
    result = struct.pack("<I", len(new_header)) + new_header + updated
    validate_table(result)
    return result


if __name__ == "__main__":
    import json
    import sys
    path = Path(sys.argv[1])
    data = path.read_bytes()
    header, payload = unpack_table(data)
    header_fields = list(fields(header))
    print(json.dumps({"file": path.name, "bytes": len(data), "header_bytes": len(header),
                      "header_fields": len(header_fields), "rows": sum(1 for _ in rows(data))}))
    for field in header_fields[:5]:
        print(field.number, field.wire, field.value if field.wire == 0 else
              [(f.number, f.wire, f.value if f.wire == 0 else f.value.hex()) for f in fields(field.value)])
    for row in list(rows(data))[:3]:
        print("row", row.start, row.end, [(f.number, f.wire, repr(f.value)[:180]) for f in fields(row.value)])
