# Beginner Account Login/Lobby Packet Order

This is the beginner-account copy of `docs/login-lobby-packet-order.md`, generated from the official Frida log and cross-checked against the parsed beginner account packet dump.

Sources:

- `e:/documents/Decompiling/Extracted/GF2/frida_gf2/beginner_acc_official.js`
- `NTRSimulator.PcapParser/bin/Debug/net8.0/Resources/Packets/beginner_acc.json`
- `NTRSimulator.Common/Protocol/MsgId.cs`

## Official Beginner Account Order

The Frida log shows the client logging socket sends and received raw packet IDs. The parsed `beginner_acc.json` gives the exact packet names and the main-message grouping.

```text
01. CS 10001 MsgCsLogin

02. SC 10129 MsgScRecordStatisticUpdate

03. SC encrypted login bundle, MainMessageId 155:
    03.01 SC 12531 MsgScActivityBackDailyRefresh
    03.02 SC 10002 MsgScLogin
    03.03 SC 11201 MsgScResource
    03.04 SC 10106 MsgScSync
    03.05 SC 20063 MsgScPlayerStatusCounterSync
    03.06 SC 20063 MsgScPlayerStatusCounterSync
    03.07 SC 10102 MsgScRecord
    03.08 SC 20029 MsgScDarkZoneStep1RoomBasicInfo
    03.09 SC 23017 MsgScHotfixNoticeSync

04. SC 20071 MsgScGetGamePlayStatus

05. SC MainMessageId 157:
    05.01 SC 20063 MsgScPlayerStatusCounterSync
    05.02 SC 20071 MsgScGetGamePlayStatus

06. SC 11728 MsgScMomentFetch

07. CS 10151 MsgCsGetPrefaceRecord
08. SC 10152 MsgScGetPrefaceRecord

09. CS 10320 MsgCsStageRecord
10. CS 10320 MsgCsStageRecord

11. SC 10321 MsgScStageRecord
12. SC 10321 MsgScStageRecord

13. CS large startup batch, beginning at sequence 5:
    13.001 CS 10417 MsgCsClientDataGet
    13.002 CS 10910 MsgCsTimers
    13.003 CS 10900 MsgCsAdjutantInfo
    13.004 CS 11060 MsgCsGunWeaponMods
    13.005 CS 11020 MsgCsGunWeapons
    13.006 CS 11137 MsgCsPublicTalentSkillItems
    13.007 CS 11195 MsgCsGetDelTalentSkillItems
    13.008 CS 11100 MsgCsGuns
    13.009 CS 20065 MsgCsPlayerCounterSync
    13.010 CS 10800 MsgCsQuestCount
    13.011 CS 10410 MsgCsSystemUnlocks
    13.012 CS 10330 MsgCsChapters
    13.013 CS 10898 MsgCsGetBgm
    13.014 CS 29140 MsgCsGetLobbyBgm
    13.015 CS 10907 MsgCsBackgroundInfo
    13.016 CS 11876 MsgCsSimCombatTutorialInfoV2
    13.017 CS 10450 MsgCsPlan
    13.018 CS 11800 MsgCsSimCombatInfo
    13.019 CS 10450 MsgCsPlan
    13.020 CS 10450 MsgCsPlan
    13.021 CS 11400 MsgCsTutorialInfo
    13.022 CS 11210 MsgCsItems
    13.023 CS 29412 MsgCsLobbyHandmadeGiftInfo
    13.024 CS 29424 MsgCsGetLobbyHandmadeGiftMay
    13.025 CS 10358 MsgCsDifficultInfo
    13.026 CS 10320 MsgCsStageRecord
    13.027 CS 10320 MsgCsStageRecord
    13.028 CS 10320 MsgCsStageRecord
    13.029 CS 11890 MsgCsSimCombatMythicInfo
    13.030 CS 25002 MsgCsSimCombatMythicHardInfo
    13.031 CS 11183 MsgCsGetAutoDismantleRulesInfo
    13.032 CS 11895 MsgCsSimCombatResourceInfo
    13.033 CS 10925 MsgCsGetAvgInfo
    13.034 CS 10130 MsgCsIndex
    13.035 CS 11408 MsgCsPptInfo
    13.036 CS 10458 MsgCsCyclePlan
    13.037 CS 10491 MsgCsGetGmConfig
    13.038 CS 10500 MsgCsStore
    13.039 CS 29500 MsgCsDishBagInfo
    13.040 CS 10450 MsgCsPlan
    13.041 CS 10450 MsgCsPlan
    13.042 CS 12200 MsgCsRecordRoom

14. SC responses to the first startup batch:
    14.001 SC 10418 MsgScClientDataGet
    14.002 SC 10912 MsgScTimers
    14.003 SC 10902 MsgScAdjutantInfo
    14.004 SC 11061 MsgScGunWeaponMods
    14.005 SC 11021 MsgScGunWeapons
    14.006 SC 11138 MsgScPublicTalentSkillItems
    14.007 SC 11196 MsgScGetDelTalentSkillItems
    14.008 SC 11101 MsgScGuns
    14.009 SC 20038 MsgScPlayerCounterSync
    14.010 SC 20063 MsgScPlayerStatusCounterSync
    14.011 SC 10833 MsgScCountSection
    14.012 SC 10833 MsgScCountSection
    14.013 SC 10833 MsgScCountSection
    14.014 SC 10833 MsgScCountSection
    14.015 SC 10833 MsgScCountSection
    14.016 SC 10801 MsgScQuestCount
    14.017 SC 10411 MsgScSystemUnlocks
    14.018 SC 10331 MsgScChapters
    14.019 SC 10899 MsgScGetBgm
    14.020 SC 29141 MsgScGetLobbyBgm
    14.021 SC 10908 MsgScBackgroundInfo
    14.022 SC 11877 MsgScSimCombatTutorialInfoV2
    14.023 SC 10451 MsgScPlan
    14.024 SC 11801 MsgScSimCombatInfo
    14.025 SC 10451 MsgScPlan
    14.026 SC 10451 MsgScPlan
    14.027 SC 11401 MsgScTutorialInfo
    14.028 SC 11211 MsgScItems
    14.029 SC 29413 MsgScLobbyHandmadeGiftInfo
    14.030 SC 29425 MsgScGetLobbyHandmadeGiftMay
    14.031 SC 10359 MsgScDifficultInfo
    14.032 SC 10321 MsgScStageRecord
    14.033 SC 10321 MsgScStageRecord
    14.034 SC 10321 MsgScStageRecord
    14.035 SC 11891 MsgScSimCombatMythicInfo
    14.036 SC 25003 MsgScSimCombatMythicHardInfo
    14.037 SC 11184 MsgScGetAutoDismantleRulesInfo
    14.038 SC 11896 MsgScSimCombatResourceInfo
    14.039 SC 10926 MsgScGetAvgInfo
    14.040 SC 10131 MsgScIndex
    14.041 SC 11409 MsgScPptInfo
    14.042 SC 10459 MsgScCyclePlan
    14.043 SC 10492 MsgScGetGmConfig
    14.044 SC 10501 MsgScStore
    14.045 SC 29501 MsgScDishBagInfo
    14.046 SC 10451 MsgScPlan
    14.047 SC 10451 MsgScPlan
    14.048 SC 12201 MsgScRecordRoom

15. CS second startup batch, beginning at sequence 47:
    15.001 CS 10600 MsgCsFriends
    15.002 CS 10606 MsgCsFriendApplyList
    15.003 CS 24004 MsgCsDarkZoneGetWeeklyInfo
    15.004 CS 11171 MsgCsGetGunRemouldingPluginLockPlan
    15.005 CS 23095 MsgCsRougeAllPlans
    15.006 CS 22000 MsgCsControlRoomInfo
    15.007 CS 23200 MsgCsGetCustomFormation
    15.008 CS 10808 MsgCsGetDailyCheckIn
    15.009 CS 11920 MsgCsSimCombatWeekInfo
    15.010 CS 21200 MsgCsGetControlFightInfo
    15.011 CS 10130 MsgCsIndex

16. SC responses to the second startup batch:
    16.001 SC 10601 MsgScFriends
    16.002 SC 24005 MsgScDarkZoneGetWeeklyInfo
    16.003 SC 11172 MsgScGetGunRemouldingPluginLockPlan
    16.004 SC 23096 MsgScRougeAllPlans
    16.005 SC 22001 MsgScControlRoomInfo
    16.006 SC 23201 MsgScGetCustomFormation
    16.007 SC 10809 MsgScGetDailyCheckIn
    16.008 SC 11921 MsgScSimCombatWeekInfo
    16.009 SC 21201 MsgScGetControlFightInfo
    16.010 SC 10131 MsgScIndex

17. CS third observed batch:
    17.001 CS 12200 MsgCsRecordRoom
    17.002 CS 23096 MsgScRougeAllPlans-like raw request payload in Frida bytes
    17.003 CS 23096 MsgScRougeAllPlans-like raw request payload in Frida bytes
    17.004 CS 24004 MsgCsDarkZoneGetWeeklyInfo
    17.005 CS 11096 MsgCsGunWeaponSkinItems

18. SC 12201 MsgScRecordRoom
```

## Differences From The Earlier Gacha Capture

The beginner-account login path is not the same as the older gacha-account path:

```text
Beginner capture:
SC 10129 MsgScRecordStatisticUpdate
SC encrypted MainMessageId 155:
  SC 12531 MsgScActivityBackDailyRefresh
  SC 10002 MsgScLogin
  SC 11201 MsgScResource
  SC 10106 MsgScSync
  SC 20063 MsgScPlayerStatusCounterSync
  SC 20063 MsgScPlayerStatusCounterSync
  SC 10102 MsgScRecord
  SC 20029 MsgScDarkZoneStep1RoomBasicInfo
  SC 23017 MsgScHotfixNoticeSync
SC 20071 MsgScGetGamePlayStatus
SC 20063 MsgScPlayerStatusCounterSync + SC 20071 MsgScGetGamePlayStatus
SC 11728 MsgScMomentFetch
```

The earlier gacha capture had a different login bundle and included `MsgScChatNodeNotifyAddr` before preface. The beginner capture does not show `MsgScChatNodeNotifyAddr` in this early Frida log.

The beginner capture also does not show the `1201 -> 1202` unknown exchange before the two initial `MsgCsStageRecord` requests. It goes from `MsgScGetPrefaceRecord` directly into the two `MsgCsStageRecord` requests.

## Implementation Notes

For this beginner account capture, the closer early response sequence is:

```text
SC 10129 MsgScRecordStatisticUpdate
SC encrypted login bundle, MainMessageId 155:
  SC 12531 MsgScActivityBackDailyRefresh
  SC 10002 MsgScLogin
  SC 11201 MsgScResource
  SC 10106 MsgScSync
  SC 20063 MsgScPlayerStatusCounterSync
  SC 20063 MsgScPlayerStatusCounterSync
  SC 10102 MsgScRecord
  SC 20029 MsgScDarkZoneStep1RoomBasicInfo
  SC 23017 MsgScHotfixNoticeSync
SC 20071 MsgScGetGamePlayStatus
SC 20063 MsgScPlayerStatusCounterSync
SC 20071 MsgScGetGamePlayStatus
SC 11728 MsgScMomentFetch
```

If replaying from `beginner_acc.json`, prefer preserving captured main-message grouping and encryption flags where possible. Sending individual protobuf messages through `connection.Send(...)` will reproduce the inner `MsgId`, but not the original outer framing.
