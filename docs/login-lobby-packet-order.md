# Login/Lobby Packet Order Comparison

This note compares the official client log with the private-server client log for the login-to-lobby flow.

Sources:

- `official_client_log`
- `ps_client_log`
- `NTRSimulator.PcapParser/bin/Debug/net8.0/Resources/Packets/gacha.json`
- `NTRSimulator.Common/Protocol/MsgId.cs`

## Official Server Order

The official flow starts with the login request, then sends one standalone statistic update, then a bundled encrypted login response, then several post-login notifications before the client asks for preface/lobby data.

```text
01. CS 10001 MsgCsLogin

02. SC 10129 MsgScRecordStatisticUpdate

03. SC encrypted login bundle, MainMessageId 189:
    03.01 SC 20071 MsgScGetGamePlayStatus
    03.02 SC 10002 MsgScLogin
    03.03 SC 11201 MsgScResource
    03.04 SC 10106 MsgScSync
    03.05 SC 10102 MsgScRecord
    03.06 SC 20029 MsgScDarkZoneStep1RoomBasicInfo
    03.07 SC 23017 MsgScHotfixNoticeSync

04. SC 11728 MsgScMomentFetch
05. SC 20071 MsgScGetGamePlayStatus
06. SC 11719 MsgScChatNodeNotifyAddr

07. CS 10151 MsgCsGetPrefaceRecord
08. SC 10152 MsgScGetPrefaceRecord

09. CS 1201 unknown/non-enum request
10. CS 10320 MsgCsStageRecord
11. CS 10320 MsgCsStageRecord

12. SC 1202 unknown/non-enum response
13. SC 10321 MsgScStageRecord
14. SC 10321 MsgScStageRecord

15. CS large startup batch, beginning with:
    15.01 CS 10320 MsgCsStageRecord
    15.02 CS 10910 MsgCsTimers
    15.03 CS 10900 MsgCsAdjutantInfo
    15.04 CS 11060 MsgCsGunWeaponMods
    15.05 CS 11020 MsgCsGunWeapons
    15.06 CS 11137 MsgCsPublicTalentSkillItems
    15.07 CS 11195 MsgCsGetDelTalentSkillItems
    15.08 CS 11100 MsgCsGuns
    15.09 CS 20065 MsgCsPlayerCounterSync
    15.10 CS 10800 MsgCsQuestCount
    15.11 CS 10410 MsgCsSystemUnlocks
    15.12 CS 10330 MsgCsChapters
    15.13 CS 10898 MsgCsGetBgm
    15.14 CS 29140 MsgCsGetLobbyBgm
    15.15 CS 10907 MsgCsBackgroundInfo
    15.16 CS 11876 MsgCsSimCombatTutorialInfoV2
    15.17 CS 10450 MsgCsPlan
    15.18 CS 11800 MsgCsSimCombatInfo
    15.19 CS 10450 MsgCsPlan
    15.20 CS 10450 MsgCsPlan
    15.21 CS 11400 MsgCsTutorialInfo
    15.22 CS 11210 MsgCsItems
    15.23 CS 29412 MsgCsLobbyHandmadeGiftInfo
    15.24 CS 29424 MsgCsGetLobbyHandmadeGiftMay
    15.25 CS 10358 MsgCsDifficultInfo
    15.26 CS 10320 MsgCsStageRecord
    15.27 CS 10320 MsgCsStageRecord
    15.28 CS 10320 MsgCsStageRecord
    15.29 CS 11890 MsgCsSimCombatMythicInfo
    15.30 CS 25002 MsgCsSimCombatMythicHardInfo
    15.31 CS 11183 MsgCsGetAutoDismantleRulesInfo
    15.32 CS 11895 MsgCsSimCombatResourceInfo
    15.33 CS 10925 MsgCsGetAvgInfo
    15.34 CS 10130 MsgCsIndex
    15.35 CS 11408 MsgCsPptInfo
    15.36 CS 21904 MsgCsGuildInfo
    15.37 CS 21952 MsgCsGetGuildBattleMissionInfo
    15.38 CS 21916 MsgCsGuildMemberList
    15.39 CS 10458 MsgCsCyclePlan
    15.40 CS 10491 MsgCsGetGmConfig
    15.41 CS 10500 MsgCsStore
    15.42 CS 29500 MsgCsDishBagInfo
    15.43 CS 10450 MsgCsPlan
    15.44 CS 10450 MsgCsPlan
    15.45 CS 12200 MsgCsRecordRoom
    15.46 CS 11727 MsgCsMomentFetch
    15.47 CS 22061 MsgCsSupportChip
    15.48 CS 22070 MsgCsGetSupportChipLockPlan
    15.49 CS 22043 MsgCsSupportRoomInfo
    15.50 CS 22057 MsgCsSupportTeams
    15.51 CS 11920 MsgCsSimCombatWeekInfo
    15.52 CS 11505 MsgCsNrtPvpInfo
    15.53 CS 24004 MsgCsDarkZoneGetWeeklyInfo
    15.54 CS 22000 MsgCsControlRoomInfo
    15.55 CS 23021 MsgCsExGetThemesInfo
    15.56 CS 10320 MsgCsStageRecord
    15.57 CS 22024 MsgCsHandmadeData
    15.58 CS 11171 MsgCsGetGunRemouldingPluginLockPlan
    15.59 CS 21200 MsgCsGetControlFightInfo
    15.60 CS 10130 MsgCsIndex
    15.61 CS 12200 MsgCsRecordRoom
    15.62 CS 29040 MsgCsLobbyMiniGameInfo
    15.63 CS 29125 MsgCsLobbyGetCafeInfo

16. CS 10415 MsgCsClientDataGet or related client-data request, depending on exact continuation in the log

17. SC 10418 MsgScClientDataGet
18. SC 10912 MsgScTimers
19. SC 10902 MsgScAdjutantInfo
20. SC 11061 MsgScGunWeaponMods, repeated across many chunks
21. SC 11021 MsgScGunWeapons, repeated across many chunks
22. SC 11138 MsgScPublicTalentSkillItems, repeated
23. SC 11196 MsgScGetDelTalentSkillItems
24. SC 11101 MsgScGuns
```

## Private Server Order From `ps_client_log`

The private-server log shows a different order very early in the flow.

```text
01. CS 10001 MsgCsLogin

02. SC 23017 MsgScHotfixNoticeSync

03. CS 10151 MsgCsGetPrefaceRecord
04. SC 10152 MsgScGetPrefaceRecord

05. CS 10320 MsgCsStageRecord
06. CS 10320 MsgCsStageRecord

07. SC 10321 MsgScStageRecord
08. SC 10321 MsgScStageRecord
09. SC 10321 MsgScStageRecord
10. SC 10321 MsgScStageRecord
11. SC 10321 MsgScStageRecord
12. SC 10321 MsgScStageRecord
13. SC 10321 MsgScStageRecord
14. SC 10321 MsgScStageRecord
15. SC 10321 MsgScStageRecord
16. SC 10321 MsgScStageRecord
17. SC 10321 MsgScStageRecord
18. SC 10321 MsgScStageRecord
19. SC 10321 MsgScStageRecord
20. SC 10321 MsgScStageRecord
21. SC 10321 MsgScStageRecord
22. SC 10321 MsgScStageRecord
23. SC 10321 MsgScStageRecord

24. CS large startup batch, shifted earlier than official

25. SC 10321 MsgScStageRecord
26. SC 10418 MsgScClientDataGet

27. CS 10415 MsgCsClientDataUpload, repeated several times
```

## Differences

The first divergence is immediately after `CS 10001 MsgCsLogin`.

Official sends:

```text
SC 10129 MsgScRecordStatisticUpdate
SC bundled encrypted login response:
  SC 20071 MsgScGetGamePlayStatus
  SC 10002 MsgScLogin
  SC 11201 MsgScResource
  SC 10106 MsgScSync
  SC 10102 MsgScRecord
  SC 20029 MsgScDarkZoneStep1RoomBasicInfo
  SC 23017 MsgScHotfixNoticeSync
SC 11728 MsgScMomentFetch
SC 20071 MsgScGetGamePlayStatus
SC 11719 MsgScChatNodeNotifyAddr
```

The private-server log shows only:

```text
SC 23017 MsgScHotfixNoticeSync
```

before the client sends `CS 10151 MsgCsGetPrefaceRecord`.

The official flow has a `CS 1201 -> SC 1202` exchange after preface and before the two stage-record responses. The private-server log skips that exchange and goes directly to `CS 10320 MsgCsStageRecord`.

The official second `SC 10321 MsgScStageRecord` is one large encrypted response with payload length `4426`. The private-server log shows many small `SC 10321` responses around `240` bytes. This is likely caused by the server's splitting behavior in `Connection.Send(...)`, and it does not match the official framing.

The official `MsgScMomentFetch` packet is captured as encrypted `MainMessageId 190`, but sending it through `connection.Send(...)` reconstructs it as a fresh unencrypted main message. That means the `MsgId` may match while the outer main-message framing/encryption still differs.

## Likely Fix Direction

To match official order more closely, the server should reproduce this early sequence before responding to preface:

```text
SC 10129 MsgScRecordStatisticUpdate
SC encrypted MainMessageId 189 bundle:
  SC 20071 MsgScGetGamePlayStatus
  SC 10002 MsgScLogin
  SC 11201 MsgScResource
  SC 10106 MsgScSync
  SC 10102 MsgScRecord
  SC 20029 MsgScDarkZoneStep1RoomBasicInfo
  SC 23017 MsgScHotfixNoticeSync
SC 11728 MsgScMomentFetch
SC 20071 MsgScGetGamePlayStatus
SC 11719 MsgScChatNodeNotifyAddr
```

Then handle the missing `1201` request and send the corresponding `1202` response before the two `MsgScStageRecord` responses.
