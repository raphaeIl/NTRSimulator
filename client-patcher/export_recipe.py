"""Export a reviewed UI catalog without redistributing publisher language tables.

The input catalog is a JSON list of {id, zh, en, source, references}; it must be
reviewed against the exact original CN table. Story IDs are explicitly excluded.
"""
import argparse
import json
from pathlib import Path

from patcher import (MAIN, BUILTIN, GACHA, CLIENT, STC, SOURCE_URL, SOURCE_SHA256,
                     digest, read_json, write_json, reference_text)
from table_codec import language_rows
from catalog_validation import compatible


def main():
    p = argparse.ArgumentParser(description=__doc__)
    p.add_argument("--catalog", required=True, type=Path)
    p.add_argument("--protected-story-ids", required=True, type=Path)
    p.add_argument("--original-tables", required=True, type=Path)
    p.add_argument("--builtin", required=True, type=Path)
    p.add_argument("--source-zip", required=True, type=Path)
    p.add_argument("--output", required=True, type=Path)
    args = p.parse_args()
    catalog = read_json(args.catalog)
    protected = set(read_json(args.protected_story_ids))
    cn = language_rows((args.original_tables / MAIN).read_bytes())
    reference = reference_text(args.output, args.source_zip)
    by_text = {}
    for key, value in reference.items():
        by_text.setdefault(value, key)
    seen, custom, index, provenance = set(), {}, [], []
    for row in catalog:
        key = row["id"]
        if key in seen or key in protected or cn.get(key) != row["zh"]:
            raise ValueError(f"Duplicate, protected, or mismatched original ID: {key}")
        seen.add(key)
        ok, why = compatible(row["zh"], row["en"])
        if not ok:
            raise ValueError(f"Invalid translation {key}: {why}")
        if row["source"].startswith("official-"):
            index.append(f"{key}\t{by_text[row['en']]}")
        else:
            custom[str(key)] = row["en"]
        contexts = "; ".join(f"{r[0]}.{r[1]}:{r[2]}" for r in row["references"])
        provenance.append(f"{key}\t{row['source']}\t{contexts}")
    builtin = read_json(args.builtin)
    original_builtin = language_rows((args.original_tables / BUILTIN).read_bytes())
    for key, value in builtin.items():
        if not compatible(original_builtin[int(key)], value)[0]:
            raise ValueError(f"Invalid builtin translation: {key}")
    manifest = {
        "schema": 1, "client_version": CLIENT, "table_version": STC,
        "originals": {name: digest((args.original_tables / name).read_bytes()) for name in (MAIN, BUILTIN, GACHA)},
        "translated_ui_entries": len(catalog), "protected_story_entries": len(protected),
        "official_reference_entries": len(index), "custom_entries": len(custom),
        "reference_url": SOURCE_URL, "reference_sha256": SOURCE_SHA256,
    }
    args.output.mkdir(parents=True, exist_ok=True)
    write_json(args.output / "manifest.json", manifest)
    write_json(args.output / "custom-en.json", custom)
    write_json(args.output / "builtin-en.json", builtin)
    (args.output / "official-index.tsv").write_text("# CN UI ID\tPublisher Global EN ID\n" + "\n".join(index) + "\n", encoding="utf-8")
    (args.output / "provenance.tsv").write_text("# CN UI ID\tTranslation source\tTable context\n" + "\n".join(provenance) + "\n", encoding="utf-8")
    print(json.dumps(manifest, indent=2))


if __name__ == "__main__":
    main()
