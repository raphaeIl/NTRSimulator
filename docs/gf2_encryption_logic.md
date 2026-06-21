# GF2 main-message encryption and length encoding

This document describes how the GF2 client and NTRSimulator encode **main messages** on the game TCP socket, with emphasis on the **encryption byte** and **body-length** fields. Payload protobuf bytes are not encrypted by this mechanism — only the 2-byte length field in the 5-byte main header is XOR-masked when the encryption byte is non-zero.

## Wire format overview

TCP data is a stream of **main messages**. Each main message contains one or more **packets** (individual protobuf messages).

```
┌─────────────────────────────────────────────────────────────┐
│ Main message (5-byte header + body)                         │
├──────────┬──────────┬──────────┬──────────────────────────┤
│ seqId    │ bodyLen  │ encrypt  │ body (one or more packets) │
│ 2 bytes  │ 2 bytes  │ 1 byte   │ bodyLen bytes              │
│ LE       │ BE*      │          │                            │
└──────────┴──────────┴──────────┴──────────────────────────┘
                                              │
                    ┌─────────────────────────┴─────────────────────────┐
                    │ Packet 1          │ Packet 2          │ ...         │
                    │ 4-byte hdr + proto│ 4-byte hdr + proto│             │
                    └───────────────────┴───────────────────┴─────────────┘
```

| Layer | Field | Size | Endian | Notes |
|-------|--------|------|--------|-------|
| Main | `sequenceId` | 2 | **Little-endian** | Updated from incoming client seq for most responses |
| Main | `messageLength` | 2 | **Big-endian** (plain or XOR-masked) | Body size only — excludes the 5-byte main header |
| Main | `encryptionByte` | 1 | — | `0` = length sent/read as plain BE; `> 0` = length XOR-masked |
| Packet | `rawMsgId` | 2 | **Little-endian** | e.g. `11101` → `5D 2B` |
| Packet | `iMessageLength` | 2 | **Little-endian** | Protobuf payload size |
| Packet | payload | N | — | Standard protobuf; no extra GF2 wire patch unless bool-map patching applies |

\* After XOR decode when `encryptionByte > 0`.

## Server implementation (NTRSimulator)

Relevant code:

- `NTRSimulator.Common/Protocol/MainMessage.cs` — encode/decode main header
- `NTRSimulator.Common/Protocol/BasePacket.cs` — inner packet header (always LE length)
- `NTRSimulator.Common/Utils/Crypto.cs` — `XorCrypt`
- `NTRSimulator.Common/Networking/Connection.cs` — `Send`, `Send(encryptionByte, ...)`, `SendEncrypted`

### Writing a main message header

1. Compute `messageLength` = sum of `(4 + payloadLength)` for each packet in the body.
2. Write `sequenceId` as uint16 **LE** at offset 0.
3. Write `messageLength` as uint16 **BE** at offset 2.
4. If `encryptionByte > 0`, XOR bytes at offset 2–3 with key `[encryptionByte, 0]`.
5. Write `encryptionByte` at offset 4.

```csharp
// MainMessage.WriteHeader (simplified)
BinaryPrimitives.WriteUInt16LittleEndian(target[0..2], sequenceId);
BinaryPrimitives.WriteUInt16BigEndian(target[2..4], messageLength);

if (encryptionByte > 0)
{
    byte[] encoded = Crypto.XorCrypt(target[2..4], [encryptionByte, 0]);
    encoded.CopyTo(target[2..4]);
}

target[4] = encryptionByte;
```

### Reading a main message header (simulator / tools)

```csharp
// MainMessageHeader.DecodeBodyLength
byte[] lengthBytes = headerBytes[2..4];
if (encryptionFlag > 0)
    lengthBytes = Crypto.XorCrypt(lengthBytes, [encryptionFlag, 0]);

ushort bodyLength = BinaryPrimitives.ReadUInt16BigEndian(lengthBytes);
```

NTRSimulator’s **server-side reader** always uses full 16-bit BE (with optional XOR). The **game client** does not — see below.

## Encryption byte formula (confirmed from logs)

The encryption byte is **not** chosen arbitrarily. For every encrypted main message in `server_log_without_extra_gun`, this holds:

```text
encryptionByte = floor(bodyLength / 255)   // integer division, same as (byte)(bodyLength / 255)
```

Where `bodyLength` is the main-message **body only** (sum of all packet headers + payloads), **not** including the 5-byte main header.

| bodyLength | encryptionByte | Example in logs |
|------------|----------------|-----------------|
| 212 | 0 | `MsgScGuns` 4 guns — `0C 00 00 D4 00` |
| 264 | 1 | `MsgScGuns` 5 guns / `MsgScStageRecord` — `encrypt=1` |
| 628 | 2 | `SC_Chapters`, gun weapon mod lock plan |
| 1128 | 4 | `SC_SystemUnlocks` |
| 2218–2290 | 8 | `StoreHandler` burst |
| 2436 | 9 | Login burst — `01 00 00 84 09` (`SendEncrypted(0x09, ...)`) |
| 2934 | 11 | `PlayerCounterHandler` — `Send(11, ...)` |
| 3492 | 13 | Unsequenced counter sync |
| 5250 | 20 | `NrtPvpHandler` — `Send(20, ...)` |
| 7300 | 28 | `StageHandler` — `Send(28, ...)` |

XOR key for the length field is always `[encryptionByte, 0]`.

### Why login uses `0x09`

From `server_log_without_extra_gun` line 638:

```text
total bytes 2441  →  body = 2436  →  2436 / 255 = 9  →  header ends with ... 00 84 09
```

`LoginHandler` hardcodes `SendEncrypted(0x09, ...)` because that bundle’s body is always ~2436 bytes. The value **is** `body / 255`, not an unrelated constant.

### Client length decode (two modes)

| encryptionByte | Client body-length decode |
|----------------|---------------------------|
| `0` | Reads **only byte at offset 3** (works when body &lt; 256) |
| `body / 255` (non-zero) | XOR bytes 2–3 with `[encryptionByte, 0]`, then uint16 **BE** |

When `body >= 256` and `encryptionByte == 0`, byte at offset 3 is the **low** byte of the real length (e.g. `0x08` instead of 264) → stream desync.

Use `connection.SendAutoEncrypted(...)` to set `encryptionByte = bodyLength / 255`. All other `Send` overloads are unchanged.

### Handlers that previously hardcoded the byte (now redundant)

These already matched `body / 255` and needed no manual value once auto-compute exists:

| Handler | Old call | Typical body | Expected byte |
|---------|----------|--------------|---------------|
| `LoginHandler` | `SendEncrypted(0x09, ...)` | 2436 | 9 |
| `StageHandler` | `Send(1, ...)` / `Send(28, ...)` | 264 / 7300 | 1 / 28 |
| `PlayerCounterHandler` | `Send(11, ...)` | 2934 | 11 |
| `NrtPvpHandler` | `Send(20, ...)` | 5250 | 20 |
| `StoreHandler` | `Send(8, ...)` | ~2218 | 8 |
| `SystemHandler` | `Send(4, ...)` | ~1128 | 4 |
| `IndexHandler` | `Send(2, ...)` | ~628 | 2 |
| `ItemHandler`, `SupportHandler`, `QuestCountHandler`, etc. | `Send(1, ...)` | 255–509 | 1 |
| `GachaHandler` | `SendEncrypted(0x0C, ...)` | ~3060+ | 12 |

### Failure case found in logs

Only one message had `body >= 256` with `encryptionByte = 0`:

| Log | Message | body | encrypt | Result |
|-----|---------|------|---------|--------|
| `server_log_with_extra_gun.log` | `MsgScGuns` 5 guns | 264 | 0 | Client desync |

Fixed by auto-compute (`264 / 255 = 1`).

## Client behavior (observed)

### Encryption byte = 0 (unencrypted length)

When `encryptionByte == 0`, the client does **not** reliably decode the full 16-bit big-endian body length. It behaves as if only **header byte at offset 3** (the low byte of the BE length) is the body size.

| Actual body length | BE length bytes (offset 2–3) | Byte at offset 3 | Client reads | Result |
|--------------------|------------------------------|------------------|--------------|--------|
| 212 | `00 D4` | `0xD4` (212) | 212 | Correct (high byte is 0) |
| 264 | `01 08` | `0x08` (8) | **8** | **Stream desync** |

Symptoms when wrong:

- `Deserialize Error. BodyLen=8, StreamPos=13` — `StreamPos = 5` (main header) + `8` (wrong body)
- `InvalidProtocolBufferException: invalid tag (zero)`
- Subsequent packets show garbage msg IDs; UI freezes

This is **not** a limit on inner packet payload size. The same session parses other messages whose **packet** payload is 260+ bytes (e.g. `MsgScStageRecord` / 10321) because those main messages use `encryptionByte != 0`.

### Encryption byte > 0 (XOR length)

When `encryptionByte > 0`, the client XOR-decodes bytes 2–3 with `[encryptionByte, 0]`, then reads uint16 **BE** — matching NTRSimulator’s server logic.

Example from logs — `MsgScStageRecord` (10321), body 264 bytes:

```
On wire:  04 00  00 08  01  | body...
          seq=4  len XOR   encrypt=1

Decode:   00 08 XOR [01,00] → 01 08 BE → 264 ✓
```

Example — broken `MsgScGuns` (11101) with 5 guns, same body size but encrypt=0:

```
On wire:  0C 00  01 08  00  | body...
          seq=12 len plain  encrypt=0

Client:   reads offset 3 only → 0x08 = 8 ✗
```

Fixed `MsgScGuns` with 5 guns (encrypt=1):

```
On wire:  0C 00  00 08  01  | body...
          seq=12 len XOR   encrypt=1

Decode:   → 264 ✓
```

### Rule of thumb for the private server

**Opt-in:** `connection.SendAutoEncrypted(message)` — sets `encryptionByte = (byte)(bodyLength / 255)`.

| bodyLength | encryptionByte | On-wire length bytes (before XOR) |
|------------|----------------|-----------------------------------|
| &lt; 255 | 0 | Plain BE; client reads offset 3 only |
| 255–509 | 1 | XOR with `[01, 00]` |
| 510–764 | 2 | XOR with `[02, 00]` |
| … | n | XOR with `[n, 00]` |

```csharp
public static byte ComputeEncryptionByte(ushort bodyLength) => (byte)(bodyLength / 255);
```

## Case study: MsgScGuns (11101) and the “extra gun” bug

Adding a 5th gun (e.g. 1032 / costume 1103200) is not invalid — it increases `SC_Guns` protobuf size:

| Guns | Packet payload | Main body (4 + payload) | encrypt=0 header (len bytes) | Client |
|------|----------------|-------------------------|--------------------------------|--------|
| 4 | 208 | 212 | `00 D4` | OK |
| 5 | 260 | 264 | `01 08` | **Fails** (reads 8) |

Gun IDs 1032 and 1103200 are fine; the failure is purely framing once body length crosses the single-byte client quirk.

### Fix

Use `connection.SendAutoEncrypted(scGuns)` in `GunHandler`. Five guns → body 264 → `264 / 255 = 1` → header `0C 00 00 08 01`.

## Inner packet layer (unchanged by encryption byte)

The encryption byte affects **only** the main-message length field. Inner packets always use:

- 2-byte msg id, LE
- 2-byte payload length, LE (full uint16 — no observed 255-byte client bug at this layer)
- Raw protobuf payload

Large inner payloads (260, 3488, etc.) work when the **main** message length was decoded correctly.

## XOR helper

```csharp
// Crypto.XorCrypt — byte-by-byte XOR with repeating key
output[i] = (byte)(data[i] ^ key[i % key.Length]);

// Length key is always [encryptionByte, 0]
```

Examples:

| Body len | Plain BE | encrypt | XOR key | On wire (bytes 2–3) |
|----------|----------|---------|---------|---------------------|
| 212 | `00 D4` | 1 | `[1, 0]` | `01 D4` |
| 264 | `01 08` | 1 | `[1, 0]` | `00 08` |
| 264 | `01 08` | 0 | — | `01 08` (broken on client) |

## Connection API summary

| Method | encryptionByte | Use when |
|--------|----------------|----------|
| `connection.Send(msg)` | 0 | Default; body &lt; 256 |
| `connection.Send(1, msg)` | 1 | Body ≥ 256, or matching official captures that use encrypt=1 |
| `connection.SendEncrypted(0x09, ...)` | arbitrary non-zero | Login bursts / specific official patterns |
| `connection.SendUnsequenced(...)` | 0 | Heartbeats / deferred msg ids (seq 0) |

Sequence id: most responses reuse the client’s current sequence; `MsgScSync` and a few others use seq `0` (see `Connection.DeferredMsgIds`).

## TCP chunking

`PacketFramer.WriteClientSizedChunks` may split one logical main message across multiple `socket.Write` calls (max 1024 bytes per chunk). The client reassembles by reading the 5-byte header, then exactly `messageLength` body bytes. Length must be correct before any body byte is interpreted.

## Related: protobuf bool-map patching

Separate from encryption: `ProtobufGameWireSerializer` patches protobuf so bool **map** entries include explicit `false` varints. That affects payload **content** size, not main-header length encoding. See `NTRSimulator.Common/Utils/ProtobufGameWireSerializer.cs`.

## Checklist when adding large responses

1. Compute or log `4 + protobuf.CalculateSize()` for the main body.
2. If ≥ 256, send with non-zero `encryptionByte` (typically `1`).
3. Confirm client log shows successful parse (no `BodyLen=8` / invalid tag zero).
4. Ensure handler data (weapons, index, etc.) matches new guns — separate from framing bugs.

## References in repo

- `NTRSimulator.Common/Protocol/MainMessage.cs`
- `NTRSimulator.Common/Protocol/BasePacket.cs`
- `NTRSimulator.Common/Networking/Connection.cs`
- `NTRSimulator.GameServer/Handlers/GunHandler.cs` — conditional `Send(1, scGuns)`
- Log comparisons: `client_log_without_extra_gun`, `client_log_with_extra_gun.log`, `server_log_without_extra_gun`, `server_log_with_extra_gun.log`

---

## Appendix: “Hide the high length byte and zero it on the wire”

This does **not** extend length beyond 16 bits (max body size is still 65535). The same 16-bit length is split so the on-wire length bytes can keep looking like `00 XX`.

### The 5-byte main header

```text
[ seq 2B ] [ body length 2B ] [ encrypt 1B ] [ body... ]
   0-1           2-3               4
```

**Body length** is a normal **16-bit big-endian** number: up to 65535. That’s two bytes:

```text
high byte | low byte
   0x09   |  0x84     →  0x0984 = 2436 bytes of body
```

### Small packet (body < 256)

Example: **212** bytes → length = `0x00D4`

```text
seq     length    enc   body...
?? ??   00 D4     00    ...
        ^^ ^^
        high=0  low=212
```

High byte is **0**, so the length already looks like “`00` + one useful byte `D4`”.  
Client with the old logic can read **only the last length byte** (`D4` = 212) and get the right size.

### Large packet (body ≥ 256) — the problem

Example: **2436** bytes → length = `0x0984`

```text
seq     length    enc   body...
?? ??   09 84     ??    ...
        ^^ ^^
        high=9  low=132
```

If the client still only looks at the **second length byte** (`0x84` = 132), or worse at **264** (`01 08`) only the **`08`** byte (= 8), you get the wrong size and the stream breaks.

They didn’t want to change the rule “length on the wire looks like `00 XX`” for all packets.

### What they did instead

1. Put the **high byte** (`0x09`) in the **encrypt** field.
2. **XOR** the length with `[encrypt, 0]` so the high byte becomes **0 on the wire**:

```text
Plain length:     09 84
XOR key:          09 00   (encrypt byte + 0)
On-wire length:   00 84   ← high byte zeroed
Encrypt field:    09      ← high byte stored here
```

So on the wire you see:

```text
seq     length    enc   body...
?? ??   00 84     09    ...2436 bytes...
```

It **looks** like a small packet again (`00 84`), but it isn’t — the real size is rebuilt as:

```text
high = encrypt byte     →  9
low  = wire length[1]   →  0x84 = 132
body length = 9×256 + 132 = 2436
```

(Same as XOR decode: `00^09, 84^00` → `09 84`.)

### “Hide” and “zero” in one sentence

- **Hide the high byte** → copy it into `encryptionByte` (byte 4).
- **Zero it on the wire** → XOR so byte 2 becomes `0x00` instead of `0x09`.

You’re not storing *more* length than 16 bits allow. You’re storing the **same** 16-bit length in two pieces:

| Piece | Where |
|--------|--------|
| Low 8 bits | Length byte 3 on the wire (`84`) |
| High 8 bits | Encrypt byte (`09`), and removed from length byte 2 via XOR |

That way old code that expects length to look like `00 XX` still sees that pattern, while new code uses `encrypt` + XOR to recover the full 16-bit size.

### Design intent (not bigger than 16 bits)

The `encryptionByte` is the **high byte of the same uint16**, stored separately so the length field on the wire can stay in the old “small packet” shape (`00 LL`). It is backward-compatible framing, not a larger address space.
