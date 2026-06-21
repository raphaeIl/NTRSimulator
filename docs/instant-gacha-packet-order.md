# Instant Gacha Packet Order

This note tracks the official instant-gacha capture. Login/startup batches are intentionally compressed; the focus is the gacha request and its response bundle.

Sources:

- `instant_gacha_log`
- `NTRSimulator.PcapParser/bin/Debug/net8.0/Resources/Packets/instant_gacha.json`
- `NTRSimulator.Common/Protocol/MsgId.cs`

## Gacha-Relevant Order

The capture starts with the normal login/lobby flow, then continues through many startup and lobby data requests. The gacha part begins after the client has already requested activity, lobby, shop, treasure, and build data.

`instant_gacha.json` is useful for decoded packet bodies, but it groups a long run of client requests before the matching server responses. For the actual late-session gacha point, use `instant_gacha_log` around the `MsgCsGachaTentimes` socket send.

```text
01. CS 22320 MsgCsActivityLotteryInfo
    SeqId 93, MainMessageId 92, payload length 0

02. SC 22321 MsgScActivityLotteryInfo
    SeqId 93, MainMessageId 257, payload length 0

03. CS 10401 MsgCsGachaTentimes
    SeqId 155, MainMessageId 154, payload length 4
    Packet:
      Field1 = 234001

04. SC 10129 MsgScRecordStatisticUpdate
    The Frida log shows this immediately after the ten-pull request.

05. SC encrypted gacha result bundle, MainMessageId 330
    SeqId 155, MainMessageLength 3169
    Contains packet indexes 0 through 54. Important entries:
      05.01 SC 20063 MsgScPlayerStatusCounterSync, index 0
      05.02 SC 10133 MsgScAddIndex, index 1
      05.03 SC 20063 MsgScPlayerStatusCounterSync, indexes 2-3
      05.04 SC 11022 MsgScNewGunWeapon, index 4, result item 11036
      05.05 SC 10133 MsgScAddIndex, index 5
      05.06 SC 20063 MsgScPlayerStatusCounterSync, indexes 6, 8-9
      05.07 SC 10133 MsgScAddIndex, index 7
      05.08 SC 11022 MsgScNewGunWeapon, index 10, result item 11048
      05.09 SC 11032 MsgScGunWeaponBelong, index 11, doll/gun id 1026
      05.10 SC 10133 MsgScAddIndex, index 12
      05.11 SC 11102 MsgScNewGun, index 13, new doll/gun id 1026
      05.12 SC 10133 MsgScAddIndex, index 14
      05.13 SC 20063 MsgScPlayerStatusCounterSync, indexes 15, 17-24, 28-29, 34-35, 39-40, 44
      05.14 SC 10133 MsgScAddIndex, indexes 16, 22, 26-27, 31, 33, 37-38, 42, 50, 52
      05.15 SC 11022 MsgScNewGunWeapon, indexes 25, 30, 32, 36, 41, 43, 45, 46
      05.16 SC 10402 MsgScGachaAcquirement, index 47
      05.17 SC 10820 MsgScCommonQuestCountUpdate, index 48
      05.18 SC 11202 MsgScResourceUpdate, index 49
      05.19 SC 23162 MsgScOutfitCollectionScoreUpdate, indexes 51, 53
      05.20 SC 10820 MsgScCommonQuestCountUpdate, index 54

06. CS 10105 MsgCsSync
    The log shows the client sending this after the gacha result processing.

07. SC 10106 MsgScSync
    SeqId 0, MainMessageId 331, payload length 8
```

## Ten-Pull Result Payload

The actual gacha result is `MsgScGachaAcquirement` inside the encrypted bundle, not a standalone response packet.

```text
SC 10402 MsgScGachaAcquirement
SeqId 155
MainMessageId 330
MainMessagePacketIndex 47
MainMessageLength 3169
MainMessageIsEncrypted true
PacketLength 1992

Packet summary:
  Field3 = 234001       // same gacha pool id requested by MsgCsGachaTentimes
  Field4 = 10           // ten-pull count
  Field1 result list:
    11036
    1026
    11045
    11017
    11039
    10631
    10361
    11009
    10361
    11010
```

The result list matches the earlier update packets in the same encrypted bundle. For example, the server sends `MsgScNewGunWeapon` for several weapon results, `MsgScGunWeaponBelong` plus `MsgScNewGun` for the `1026` doll/gun result, and then emits the final `MsgScGachaAcquirement` summary.

## Log Correlation

The Frida log shows the same request at the socket level:

```text
Client->server socket send bytes:
9B 00 00 08 00 A1 28 04 00 08 91 A4 0E
```

`A1 28` is packet id `10401` (`MsgCsGachaTentimes`). The protobuf payload decodes as `Field1 = 234001`.

The response then arrives as multiple socket chunks, but the parser reconstructs it as one encrypted main-message bundle:

```text
MainMessageId 330
MainMessageLength 3169
MainMessageIsEncrypted true
SeqId 155
```

This is why reproducing only `MsgScGachaAcquirement` is likely not enough. The official server sends resource/status/index/new-item updates before the acquirement summary, all under the same request sequence.

## Implementation Notes

For a private-server handler for `MsgCsGachaTentimes`, the closest official shape would be:

```text
CS 10401 MsgCsGachaTentimes
SC encrypted bundle for same SeqId:
  status/index/resource updates for the ten-pull side effects
  new weapon/doll notifications
  SC 10402 MsgScGachaAcquirement
  quest/resource/outfit collection updates
SC 10106 MsgScSync
```

The gacha bundle should preserve both ordering and bundling. Sending `MsgScGachaAcquirement` alone as a fresh standalone packet would differ from the official capture in framing, encryption, and side-effect packet order.
