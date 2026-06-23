using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;
using System;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class LobbyHandler : LobbyHandlerBase
    {
        int lobbyGetBuildInfoCount;

        public override void HandleLobbyGetEventInfo(CS_LobbyGetEventInfo request, Connection connection)
        {
            uint nowUnix = (uint)DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            connection.SendAutoEncrypted(new SC_LobbyGetEventInfo
            {
                Field1 =
                {
                    [30200] = true,
                    [2000005] = true,
                    [2000002] = true,
                    [31000] = true,
                    [2000011] = true,
                    [30610] = true,
                    [103] = true,
                    [30710] = true,
                    [31210] = true,
                    [30510] = true,
                    [30900] = true,
                    [101] = true,
                    [30400] = true,
                    [102] = true,
                    [2000001] = true,
                    [30100] = true,
                    [31310] = true,
                    [30300] = true,
                    [2000013] = true,
                    [31110] = true,
                    [30810] = true,
                },
                Field2 =
                {
                    [2000003] = new SC_LobbyGetEventInfo_F2ValueType
                    {
                        Field1 = 2000003,
                        Field2 = nowUnix,
                        Field3 = 0,
                    },
                    [2000012] = new SC_LobbyGetEventInfo_F2ValueType
                    {
                        Field1 = 2000012,
                        Field2 = nowUnix,
                        Field3 = 0,
                    },
                    [2000019] = new SC_LobbyGetEventInfo_F2ValueType
                    {
                        Field1 = 2000019,
                        Field2 = nowUnix,
                        Field3 = 0,
                    },
                    [2000015] = new SC_LobbyGetEventInfo_F2ValueType
                    {
                        Field1 = 2000015,
                        Field2 = nowUnix,
                        Field3 = 0,
                    },
                    [2000020] = new SC_LobbyGetEventInfo_F2ValueType
                    {
                        Field1 = 2000020,
                        Field2 = nowUnix,
                        Field3 = 0,
                    },
                    [31410] = new SC_LobbyGetEventInfo_F2ValueType
                    {
                        Field1 = 31410,
                        Field2 = nowUnix,
                        Field3 = 0,
                    },
                },
                Field3 = { },
                Field4 = { 43016, 43015, 38003, 43008, 44001, 44002, 44003, 43001 },
                Field5 = { },
                Field6 = { 3, 1, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 },
            });
        }

        public override void HandleLobbyGetBuildInfo(CS_LobbyGetBuildInfo request, Connection connection)
        {
                    lobbyGetBuildInfoCount++;

                    connection.Send(
                        new SC_PlayerStatusCounterSync
                        {
                            Field2 = 28,
                            Field1 =
                            {
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40140 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40141 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40142 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Field2 = 31,
                            Field1 =
                            {
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1562 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1563 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1564 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1565 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1566 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1561 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Field2 = 28,
                            Field1 =
                            {
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40142 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40140 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40141 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Field2 = 31,
                            Field1 =
                            {
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1564 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1565 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1566 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1561 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1562 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1563 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Field2 = 28,
                            Field1 =
                            {
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40140 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40141 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40142 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Field2 = 31,
                            Field1 =
                            {
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1561 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1562 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1563 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1564 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1565 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1566 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Field2 = 28,
                            Field1 =
                            {
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40140 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40141 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40142 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Field2 = 31,
                            Field1 =
                            {
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1561 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1562 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1563 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1564 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1565 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1566 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Field2 = 28,
                            Field1 =
                            {
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40140 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40141 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40142 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Field2 = 31,
                            Field1 =
                            {
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1561 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1562 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1563 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1564 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1565 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1566 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Field2 = 28,
                            Field1 =
                            {
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40140 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40141 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40142 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Field2 = 31,
                            Field1 =
                            {
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1562 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1563 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1564 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1565 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1566 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1561 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Field2 = 28,
                            Field1 =
                            {
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40140 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40141 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40142 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Field2 = 31,
                            Field1 =
                            {
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1562 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1563 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1564 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1565 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1566 },
                                new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1561 },
                            },
                        },
                        new SC_LobbyGetBuildInfo
                        {
                            Field1 =
                            {
                                [101] = new SC_LobbyGetBuildInfo_F1ValueType { Field2 = { 10131, 10101, 10122, 10123, 10115, 10130, 10108, 10125, 10128, 10132, 10124, 10136, 10116, 10153, 10133 } },
                                [102] = new SC_LobbyGetBuildInfo_F1ValueType { Field2 = { 10204, 10205, 10212, 10226, 10231, 10211, 10201, 10206, 10218 } },
                                [103] = new SC_LobbyGetBuildInfo_F1ValueType { Field2 = { 10304, 10302, 10301 } },
                                [104] = new SC_LobbyGetBuildInfo_F1ValueType { Field2 = { 10401, 10402 } },
                                [106] = new SC_LobbyGetBuildInfo_F1ValueType { Field2 = { 10601, 10602, 10603, 10607 } },
                                [107] = new SC_LobbyGetBuildInfo_F1ValueType { Field2 = { 10716, 10701, 10702, 10704, 10703 } },
                                [201] = new SC_LobbyGetBuildInfo_F1ValueType { Field2 = { } },
                                [202] = new SC_LobbyGetBuildInfo_F1ValueType { Field2 = { 20202, 20203 } },
                            },
                            Field2 = 49,
                            Field3 = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49 },
                            Field4 = 40260,
                        });

                    if (lobbyGetBuildInfoCount != 2)
                    {
                        return;
                    }

                    connection.SendUnsequenced(
                        new SC_RecordStatisticUpdate
                        {
                            Field1 = 1,
                            Field2 = 11,
                            Field3 = 0,
                        },
                        new SC_PlayerCounterSync
                        {
                            Counters =
                            {
                                new PlayerCounter
                                {
                                    Id = 1437,
                                    Watchers =
                                    {
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 410261,
                                            Field3 = true,
                                            Field4 = 410261,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 410262,
                                            Field3 = true,
                                            Field4 = 410262,
                                        },
                                    },
                                    Counter = new Counter { Id = 1437, ResetPeriod = 0,
                                        Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                                        Field4 = 58,
                                        Field5 = false,
                                        Field6 = { 58, 1026 },
                                        Field7 = 0,
                                        Field8 = 0,
                                        Field9 = { },
                                        Field10 = null,
                                        Field11 = 0,
                                    },
                                },
                            },
                        },
                        new SC_PlayerCounterSync
                        {
                            Counters =
                            {
                                new PlayerCounter
                                {
                                    Id = 1437,
                                    Watchers =
                                    {
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 410261,
                                            Field3 = true,
                                            Field4 = 410261,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 410262,
                                            Field3 = true,
                                            Field4 = 410262,
                                        },
                                    },
                                    Counter = new Counter { Id = 1437, ResetPeriod = 0,
                                        Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                                        Field4 = 58,
                                        Field5 = false,
                                        Field6 = { 58, 1026 },
                                        Field7 = 0,
                                        Field8 = 0,
                                        Field9 = { },
                                        Field10 = null,
                                        Field11 = 0,
                                    },
                                },
                            },
                        },
                        new SC_PlayerCounterDel { SystemId = 30, UniqueId = 23023 },
                        new SC_PlayerCounterSync
                        {
                            Counters =
                            {
                                new PlayerCounter
                                {
                                    Id = 1439,
                                    Watchers =
                                    {
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 40001,
                                            Field3 = true,
                                            Field4 = 40001,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 44012,
                                            Field3 = true,
                                            Field4 = 44012,
                                        },
                                    },
                                    Counter = new Counter { Id = 1439, ResetPeriod = 0,
                                        Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                                        Field4 = 5,
                                        Field5 = false,
                                        Field6 = { 5, 1026 },
                                        Field7 = 0,
                                        Field8 = 0,
                                        Field9 = { },
                                        Field10 = null,
                                        Field11 = 0,
                                    },
                                },
                            },
                        },
                        new SC_PlayerCounterSync
                        {
                            Counters =
                            {
                                new PlayerCounter
                                {
                                    Id = 1439,
                                    Watchers =
                                    {
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 40001,
                                            Field3 = true,
                                            Field4 = 40001,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 44012,
                                            Field3 = true,
                                            Field4 = 44012,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 44015,
                                            Field3 = true,
                                            Field4 = 44015,
                                        },
                                    },
                                    Counter = new Counter { Id = 1439, ResetPeriod = 0,
                                        Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                                        Field4 = 5,
                                        Field5 = false,
                                        Field6 = { 5, 1026 },
                                        Field7 = 0,
                                        Field8 = 0,
                                        Field9 = { },
                                        Field10 = null,
                                        Field11 = 0,
                                    },
                                },
                            },
                        },
                        new SC_PlayerCounterSync
                        {
                            Counters =
                            {
                                new PlayerCounter
                                {
                                    Id = 1439,
                                    Watchers =
                                    {
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 40001,
                                            Field3 = true,
                                            Field4 = 40001,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 44012,
                                            Field3 = true,
                                            Field4 = 44012,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 44015,
                                            Field3 = true,
                                            Field4 = 44015,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 46032,
                                            Field3 = true,
                                            Field4 = 46032,
                                        },
                                    },
                                    Counter = new Counter { Id = 1439, ResetPeriod = 0,
                                        Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                                        Field4 = 5,
                                        Field5 = false,
                                        Field6 = { 5, 1026 },
                                        Field7 = 0,
                                        Field8 = 0,
                                        Field9 = { },
                                        Field10 = null,
                                        Field11 = 0,
                                    },
                                },
                            },
                        },
                        new SC_PlayerCounterSync
                        {
                            Counters =
                            {
                                new PlayerCounter
                                {
                                    Id = 1439,
                                    Watchers =
                                    {
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 40001,
                                            Field3 = true,
                                            Field4 = 40001,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 44012,
                                            Field3 = true,
                                            Field4 = 44012,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 44015,
                                            Field3 = true,
                                            Field4 = 44015,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 46032,
                                            Field3 = true,
                                            Field4 = 46032,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 71007,
                                            Field3 = true,
                                            Field4 = 71007,
                                        },
                                    },
                                    Counter = new Counter { Id = 1439, ResetPeriod = 0,
                                        Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                                        Field4 = 5,
                                        Field5 = false,
                                        Field6 = { 5, 1026 },
                                        Field7 = 0,
                                        Field8 = 0,
                                        Field9 = { },
                                        Field10 = null,
                                        Field11 = 0,
                                    },
                                },
                            },
                        },
                        new SC_PlayerCounterSync
                        {
                            Counters =
                            {
                                new PlayerCounter
                                {
                                    Id = 1439,
                                    Watchers =
                                    {
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 40001,
                                            Field3 = true,
                                            Field4 = 40001,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 44012,
                                            Field3 = true,
                                            Field4 = 44012,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 44015,
                                            Field3 = true,
                                            Field4 = 44015,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 46032,
                                            Field3 = true,
                                            Field4 = 46032,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 71007,
                                            Field3 = true,
                                            Field4 = 71007,
                                        },
                                    },
                                    Counter = new Counter { Id = 1439, ResetPeriod = 0,
                                        Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                                        Field4 = 5,
                                        Field5 = false,
                                        Field6 = { 5, 1026 },
                                        Field7 = 0,
                                        Field8 = 0,
                                        Field9 = { },
                                        Field10 = null,
                                        Field11 = 0,
                                    },
                                },
                            },
                        },
                        new SC_PlayerCounterSync
                        {
                            Counters =
                            {
                                new PlayerCounter
                                {
                                    Id = 1439,
                                    Watchers =
                                    {
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 40001,
                                            Field3 = true,
                                            Field4 = 40001,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 44012,
                                            Field3 = true,
                                            Field4 = 44012,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 44015,
                                            Field3 = true,
                                            Field4 = 44015,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 46032,
                                            Field3 = true,
                                            Field4 = 46032,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 71007,
                                            Field3 = true,
                                            Field4 = 71007,
                                        },
                                    },
                                    Counter = new Counter { Id = 1439, ResetPeriod = 0,
                                        Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                                        Field4 = 5,
                                        Field5 = false,
                                        Field6 = { 5, 1026 },
                                        Field7 = 0,
                                        Field8 = 0,
                                        Field9 = { },
                                        Field10 = null,
                                        Field11 = 0,
                                    },
                                },
                            },
                        },
                        new SC_PlayerCounterSync
                        {
                            Counters =
                            {
                                new PlayerCounter
                                {
                                    Id = 1439,
                                    Watchers =
                                    {
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 40001,
                                            Field3 = true,
                                            Field4 = 40001,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 44012,
                                            Field3 = true,
                                            Field4 = 44012,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 44015,
                                            Field3 = true,
                                            Field4 = 44015,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 46032,
                                            Field3 = true,
                                            Field4 = 46032,
                                        },
                                        new Watcher
                                        {
                                            SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 71007,
                                            Field3 = true,
                                            Field4 = 71007,
                                        },
                                    },
                                    Counter = new Counter { Id = 1439, ResetPeriod = 0,
                                        Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                                        Field4 = 5,
                                        Field5 = false,
                                        Field6 = { 5, 1026 },
                                        Field7 = 0,
                                        Field8 = 0,
                                        Field9 = { },
                                        Field10 = null,
                                        Field11 = 0,
                                    },
                                },
                            },
                        },
                        new SC_DropCollect
                        {
                            Field1 =
                            {
                                new SC_DarkZoneEndContract_F4Type
                                {
                                    Field1 = 16,
                                    Field2 = 18,
                                    Field6 = 0,
                                    Field7 = 0,
                                    Field4 = { },
                                    Field8 = { },
                                    Field9 = false,
                                    Field10 = (Enum_NoneNull_UserUpgradeReward_TakeAchieveRewards_TakeAchieveTagReward_RecordRoomGetDetailReward)62,
                                    Field11 = null,
                                    Field12 = 0,
                                },
                                new SC_DarkZoneEndContract_F4Type
                                {
                                    Field1 = 47,
                                    Field2 = 12,
                                    Field6 = 0,
                                    Field7 = 0,
                                    Field4 = { },
                                    Field8 = { },
                                    Field9 = false,
                                    Field10 = (Enum_NoneNull_UserUpgradeReward_TakeAchieveRewards_TakeAchieveTagReward_RecordRoomGetDetailReward)62,
                                    Field11 = null,
                                    Field12 = 0,
                                },
                                new SC_DarkZoneEndContract_F4Type
                                {
                                    Field1 = 23023,
                                    Field2 = 1,
                                    Field6 = 0,
                                    Field7 = 0,
                                    Field4 = { },
                                    Field8 = { },
                                    Field9 = false,
                                    Field10 = (Enum_NoneNull_UserUpgradeReward_TakeAchieveRewards_TakeAchieveTagReward_RecordRoomGetDetailReward)328,
                                    Field11 = null,
                                    Field12 = 0,
                                },
                                new SC_DarkZoneEndContract_F4Type
                                {
                                    Field1 = 21011,
                                    Field2 = 1,
                                    Field6 = 0,
                                    Field7 = 0,
                                    Field4 = { },
                                    Field8 = { },
                                    Field9 = false,
                                    Field10 = (Enum_NoneNull_UserUpgradeReward_TakeAchieveRewards_TakeAchieveTagReward_RecordRoomGetDetailReward)328,
                                    Field11 = null,
                                    Field12 = 0,
                                },
                            },
                        });
        }

        public override void HandleLobbyGetSchemeV2(CS_LobbyGetSchemeV2 request, Connection connection)
        {
            connection.Send(new SC_LobbyGetSchemeV2
            {
                Field1 = new CS_LobbySetScheme_F2Type
                {
                    Field1 =
                    {
                        [101] = new CS_LobbySetScheme_F2Type_F1ValueType
                        {
                            Field1 = { },
                            Field2 = { },
                            Field3 = 0,
                            Field4 = { },
                            Field5 =
                            {
                                [1] = new CS_LobbySetScheme_F2Type_F1ValueType_F5ValueType
                                {
                                    Field1 = 0,
                                    Field2 = { 660736 },
                                    Field3 = { },
                                },
                                [2] = new CS_LobbySetScheme_F2Type_F1ValueType_F5ValueType
                                {
                                    Field1 = 1,
                                    Field2 = { 809472, 1073152, 1452288, 929536 },
                                    Field3 = { },
                                },
                                [3] = new CS_LobbySetScheme_F2Type_F1ValueType_F5ValueType
                                {
                                    Field1 = 0,
                                    Field2 = { 2622906368, 2622658560, 2623308800 },
                                    Field3 = { },
                                },
                            },
                        },
                        [102] = new CS_LobbySetScheme_F2Type_F1ValueType
                        {
                            Field1 = { },
                            Field2 =
                            {
                                [10202] = 202802,
                                [10204] = 113204,
                                [10201] = 202801,
                            },
                            Field3 = 0,
                            Field4 = { },
                            Field5 = { },
                        },
                    },
                    Field2 = "",
                },
                Field2 =
                {
                    new CS_LobbySetScheme_F2Type { Field1 = { }, Field2 = "" },
                    new CS_LobbySetScheme_F2Type { Field1 = { }, Field2 = "" },
                    new CS_LobbySetScheme_F2Type { Field1 = { }, Field2 = "" },
                    new CS_LobbySetScheme_F2Type { Field1 = { }, Field2 = "" },
                },
            });
        }

                public override void HandleLobbyGetCafeInfo(CS_LobbyGetCafeInfo request, Connection connection)
        {
                    connection.Send(new SC_LobbyGetCafeInfo
                    {
                        Field1 = 0,
                        Field2 = 5,
                        Field3 =
                        {
                            [1u] = 1,
                            [2u] = 1,
                            [3u] = 1,
                            [4u] = 1,
                            [5u] = 1,
                            [6u] = 1,
                            [67u] = 1,
                        },
                        Field4 =
                        {
                            [1001] = 24,
                            [1008] = 24,
                            [1035] = 24,
                            [1048] = 8,
                            [1062] = 8,
                            [1066] = 57,
                        },
                        Field5 = { },
                        Field6 = { },
                    });
        }

        public override void HandleLobbyCookingInfo(CS_LobbyCookingInfo request, Connection connection)
        {
                    connection.Send(new SC_LobbyCookingInfo
                    {
                        Field1 = new SC_LobbyCookingInfo_F1Type
                        {
                            Field1 = 0,
                            Field2 = { },
                            Field4 = { },
                        },
                    });
        }

        public override void HandleLobbyBuffInfo(CS_LobbyBuffInfo request, Connection connection)
        {
                    connection.Send(1, new SC_LobbyBuffInfo
                    {
                        Field1 = 0,
                        Field2 =
                        {
                            [1001] = 5,
                            [1008] = 4,
                            [1009] = 5,
                            [1013] = 48,
                            [1015] = 5,
                            [1017] = 5,
                            [1021] = 5,
                            [1022] = 4,
                            [1023] = 4,
                            [1024] = 5,
                            [1025] = 4,
                            [1026] = 5,
                            [1027] = 4,
                            [1029] = 4,
                            [1032] = 7,
                            [1033] = 4,
                            [1034] = 5,
                            [1035] = 4,
                            [1036] = 4,
                            [1038] = 5,
                            [1039] = 8,
                            [1040] = 4,
                            [1042] = 5,
                            [1043] = 4,
                            [1044] = 5,
                            [1045] = 5,
                            [1047] = 4,
                            [1048] = 4,
                            [1049] = 4,
                            [1050] = 4,
                            [1051] = 4,
                            [1052] = 4,
                            [1053] = 5,
                            [1054] = 4,
                            [1055] = 4,
                            [1056] = 4,
                            [1057] = 4,
                            [1058] = 4,
                            [1059] = 4,
                            [1060] = 5,
                            [1061] = 5,
                            [1062] = 4,
                            [1063] = 4,
                            [1064] = 5,
                            [1065] = 5,
                            [1066] = 4,
                            [1068] = 4,
                            [1069] = 4,
                            [1070] = 5,
                            [1071] = 4,
                            [1072] = 4,
                            [1073] = 5,
                            [1074] = 4,
                            [1076] = 4,
                            [1077] = 4,
                        },
                        Field3 =
                        {
                            [1] = 1,
                            [2] = 1,
                            [3] = 1,
                            [4] = 1,
                            [5] = 1,
                            [6] = 1,
                            [7] = 1,
                            [8] = 1,
                            [9] = 1,
                            [15] = 1,
                        },
                        Field4 = 0,
                        Field5 = 0,
                        Field6 = false,
                    });
        }

        public override void HandleLobbyGetQuestInfo(CS_LobbyGetQuestInfo request, Connection connection)
        {
                    connection.Send(new SC_LobbyGetQuestInfo
                    {
                        Field1 = 0,
                        Field2 = 0,
                        Field3 = { },
                    });
        }

        public override void HandleLobbyInteract(CS_LobbyInteract request, Connection connection)
        {
            connection.Send(new SC_LobbyInteract
            {
                Field1 = request.Field1,
                Field2 = true,
                Field3 = request.Field3,
            });
        }

        public override void HandleLobbyTutorialInfo(CS_LobbyTutorialInfo request, Connection connection)
        {
                    connection.Send(1, new SC_LobbyTutorialInfo
                    {
                        Field1 =
                        {
                            [100210] = true,
                            [100306] = true,
                            [100307] = true,
                            [100407] = true,
                            [200210] = true,
                            [200306] = true,
                            [200307] = true,
                            [200407] = true,
                        },
                        Field2 =
                        {
                            [1001] = true,
                            [1002] = true,
                            [1003] = true,
                            [1004] = true,
                            [1005] = true,
                            [1006] = true,
                            [1007] = true,
                            [1008] = true,
                            [1010] = true,
                            [2002] = true,
                            [2003] = true,
                            [2004] = true,
                            [2005] = true,
                            [2006] = true,
                            [2007] = true,
                            [2008] = true,
                            [2010] = true,
                            [3007] = true,
                            [10031] = true,
                            [10041] = true,
                            [10051] = true,
                            [10081] = true,
                            [10091] = true,
                            [10101] = true,
                            [10102] = true,
                            [30100] = true,
                            [30200] = true,
                            [30300] = true,
                            [30310] = true,
                            [30410] = true,
                            [30510] = true,
                            [30610] = true,
                            [30710] = true,
                            [30810] = true,
                            [30900] = true,
                            [31000] = true,
                            [31010] = true,
                            [31110] = true,
                            [31210] = true,
                            [31310] = true,
                            [31910] = true,
                        },
                    });
        }

        public override void HandleLobbyTutorialFinish(CS_LobbyTutorialFinish request, Connection connection)
        {
            connection.Send(new SC_LobbyTutorialFinish
            {
                Field1 = { request.Field1 },
            });
        }

        public override void HandleLobbyTutorialSend(CS_LobbyTutorialSend request, Connection connection)
        {
            connection.Send(new SC_LobbyTutorialSend
            {
                Field1 = { { request.Field1, 1u } },
                Field2 = request.Field1,
            });
        }

        public override void HandleGetLobbyShareCodeIdx(CS_GetLobbyShareCodeIdx request, Connection connection)
        {
                    connection.Send(new SC_GetLobbyShareCodeIdx
                    {
                        Field1 = { },
                    });
        }

        public override void HandleGetLobbyBgm(CS_GetLobbyBgm request, Connection connection)
        {
            connection.Send(new SC_GetLobbyBgm { Field1 = 0 });
        }

        public override void HandleGetLobbyPhotoCut(CS_GetLobbyPhotoCut request, Connection connection)
        {
            connection.Send(new SC_GetLobbyPhotoCut
            {
                Field1 = { },
                Field2 = { 1, 2, 3, 4, 5, 6, 7, 53, 9, 10, 11, 12, 13, 14, 16, 17, 18, 19, 21, 22, 23, 24, 25, 26, 27, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 48, 49, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 69, 70, 71, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91 },
                Field3 = 1,
                Field4 = { },
            });
        }

                public override void HandleLobbyWelcomeSettingInfo(CS_LobbyWelcomeSettingInfo request, Connection connection)
        {
            uint nowUnix = (uint)DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            connection.Send(new SC_LobbyWelcomeSettingInfo
            {
                Field1 = new SC_LobbyWelcomeSettingInfo_F1Type
                {
                    Field1 = true,
                    Field3 = nowUnix,
                    Field4 = 1017,
                    Field5 = true,
                },
            });
        }

        public override void HandleLobbyHandmadeGiftInfo(CS_LobbyHandmadeGiftInfo request, Connection connection)
        {
            connection.Send(new SC_LobbyHandmadeGiftInfo
            {
                Field1 = { },
            });
        }

        public override void HandleGetLobbyHandmadeGiftMay(CS_GetLobbyHandmadeGiftMay request, Connection connection)
        {
            connection.Send(new SC_GetLobbyHandmadeGiftMay
            {
                Field1 = { },
            });
        }

                        public override void HandleLobbyGetGunSetting(CS_LobbyGetGunSetting request, Connection connection)
        {
            uint nowUnix = (uint)DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            connection.Send(1,
                new SC_LobbyGetGunSetting
                {
                    Field1 =
                    {
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1001, Field2 = 1100100, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1008, Field2 = 1100800, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1009, Field2 = 1100900, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1013, Field2 = 1101300, Field3 = 0, Field4 = nowUnix, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1015, Field2 = 1101500, Field3 = 0, Field4 = nowUnix, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1017, Field2 = 1101700, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1021, Field2 = 1102100, Field3 = 0, Field4 = nowUnix, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1022, Field2 = 1102200, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1023, Field2 = 1102300, Field3 = 0, Field4 = nowUnix, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1024, Field2 = 1102400, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1025, Field2 = 1102501, Field3 = 0, Field4 = nowUnix, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1026, Field2 = 1102601, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1027, Field2 = 1102700, Field3 = 0, Field4 = nowUnix, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1028, Field2 = 1102800, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1029, Field2 = 1102900, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1032, Field2 = 1103200, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1033, Field2 = 1103300, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1034, Field2 = 1103401, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1035, Field2 = 1103500, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1036, Field2 = 1103600, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1037, Field2 = 1103700, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1038, Field2 = 1103800, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1039, Field2 = 1103901, Field3 = 273, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1040, Field2 = 1104000, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1041, Field2 = 1104100, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1042, Field2 = 1104200, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1043, Field2 = 1104300, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1044, Field2 = 1104400, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1045, Field2 = 1104500, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1047, Field2 = 1104701, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1048, Field2 = 1104800, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1049, Field2 = 1104900, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1050, Field2 = 1105000, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1051, Field2 = 1105100, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1052, Field2 = 1105203, Field3 = 273, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1053, Field2 = 1105300, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1054, Field2 = 1105401, Field3 = 273, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1055, Field2 = 1105500, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1056, Field2 = 1105600, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1057, Field2 = 1105700, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1058, Field2 = 1105800, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1059, Field2 = 1105900, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1060, Field2 = 1106000, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1061, Field2 = 1106100, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1062, Field2 = 1106200, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1063, Field2 = 1106300, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1064, Field2 = 1106400, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1065, Field2 = 1106500, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1066, Field2 = 1106600, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1067, Field2 = 1106700, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1068, Field2 = 1106800, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1069, Field2 = 1106900, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1070, Field2 = 1107000, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1071, Field2 = 1107100, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1072, Field2 = 1107200, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1073, Field2 = 1107300, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1074, Field2 = 1107400, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1075, Field2 = 1107500, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1076, Field2 = 1107600, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1077, Field2 = 1107700, Field3 = 0, Field4 = 0, Field5 = 0 },
                        new CS_LobbySetScheme_F2Type_F1ValueType_F1Type { Field1 = 1078, Field2 = 1107800, Field3 = 0, Field4 = 0, Field5 = 0 },
                    },
                });
        }

        public override void HandleLobbyGunCostumeParts(CS_LobbyGunCostumeParts request, Connection connection)
        {
            connection.Send(new SC_LobbyGunCostumeParts());
        }

        public override void HandleLobbyWatchAvgDuo(CS_LobbyWatchAvgDuo request, Connection connection)
        {
            SC_LobbyWatchAvgDuo response = new SC_LobbyWatchAvgDuo
            {
                Field2 = request.Field2,
            };
            response.Field1.AddRange(request.Field1);
            connection.Send(response);
        }

        public override void HandleLobbyPlantInfo(CS_LobbyPlantInfo request, Connection connection)
        {
            connection.Send(new SC_LobbyPlantInfo
            {
                Field1 = new SC_LobbyPlantInfo_F1Type
                {
                    Field1 = 0,
                    Field2 = 0,
                    Field3 = 0,
                    Field4 = 0,
                    Field5 = 0,
                    Field6 = false,
                    Field7 = 0,
                    Field8 = false,
                    Field9 = 0,
                    Field10 = { },
                    Field11 = 0,
                },
            });
        }

        // 3d dorm lobby missing handler impl starts here
        public override void HandleLobbyPartyInfo(CS_LobbyPartyInfo request, Connection connection)
        {
            connection.Send(7, new SC_LobbyPartyInfo
            {
                Field1 =
                {
                    [101] = new SC_LobbyPartyInfo_F1ValueType
                    {
                        Field1 = 101,
                        Field2 =
                        {
                            [10101] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType
                            {
                                Field1 = 10101,
                                Field2 = true,
                                Field3 =
                                {
                                    [1010101] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010101, Field2 = true },
                                    [1010102] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010102, Field2 = true },
                                    [1010103] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010103, Field2 = true },
                                    [1010104] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010104, Field2 = true },
                                    [1010105] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010105, Field2 = true },
                                    [1010106] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010106, Field2 = true },
                                    [1010107] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010107, Field2 = true },
                                    [1010108] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010108, Field2 = true },
                                },
                                Field4 = { },
                            },
                            [10102] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType
                            {
                                Field1 = 10102,
                                Field2 = true,
                                Field3 =
                                {
                                    [1010201] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010201, Field2 = true },
                                    [1010202] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010202, Field2 = true },
                                    [1010203] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010203, Field2 = true },
                                    [1010204] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010204, Field2 = true },
                                    [1010205] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010205, Field2 = true },
                                    [1010206] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010206, Field2 = true },
                                },
                                Field4 = { },
                            },
                            [10103] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType
                            {
                                Field1 = 10103,
                                Field2 = true,
                                Field3 =
                                {
                                    [1010301] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010301, Field2 = true },
                                    [1010302] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010302, Field2 = true },
                                    [1010303] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010303, Field2 = true },
                                    [1010304] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010304, Field2 = true },
                                    [1010305] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010305, Field2 = true },
                                    [1010306] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010306, Field2 = true },
                                    [1010307] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010307, Field2 = true },
                                    [1010308] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010308, Field2 = true },
                                },
                                Field4 = { },
                            },
                            [10104] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType
                            {
                                Field1 = 10104,
                                Field2 = true,
                                Field3 =
                                {
                                    [1010401] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010401, Field2 = true },
                                    [1010402] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010402, Field2 = true },
                                    [1010403] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010403, Field2 = true },
                                    [1010404] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010404, Field2 = true },
                                    [1010405] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010405, Field2 = true },
                                },
                                Field4 = { },
                            },
                            [10105] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType
                            {
                                Field1 = 10105,
                                Field2 = true,
                                Field3 =
                                {
                                    [1010501] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010501, Field2 = true },
                                    [1010502] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010502, Field2 = true },
                                    [1010503] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010503, Field2 = true },
                                    [1010504] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1010504, Field2 = true },
                                },
                                Field4 = { },
                            },
                        },
                        Field4 = false,
                        Field5 = new SC_LobbyPartyInfo_F1ValueType_F5Type
                        {
                            Field1 =
                            {
                                [3700902] = 3700903,
                                [3700908] = 3700909,
                                [3700912] = 3700913,
                                [3700917] = 3700919,
                            },
                        },
                        Field8 = 0,
                    },
                    [102] = new SC_LobbyPartyInfo_F1ValueType
                    {
                        Field1 = 102,
                        Field2 =
                        {
                            [10201] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType
                            {
                                Field1 = 10201,
                                Field2 = true,
                                Field3 =
                                {
                                    [1020101] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020101, Field2 = true },
                                    [1020102] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020102, Field2 = true },
                                    [1020103] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020103, Field2 = true },
                                    [1020104] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020104, Field2 = true },
                                    [1020105] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020105, Field2 = true },
                                    [1020106] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020106, Field2 = true },
                                    [1020107] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020107, Field2 = true },
                                    [1020108] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020108, Field2 = true },
                                },
                                Field4 = { },
                            },
                            [10202] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType
                            {
                                Field1 = 10202,
                                Field2 = true,
                                Field3 =
                                {
                                    [1020201] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020201, Field2 = true },
                                    [1020202] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020202, Field2 = true },
                                    [1020203] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020203, Field2 = true },
                                    [1020204] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020204, Field2 = true },
                                    [1020205] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020205, Field2 = true },
                                    [1020206] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020206, Field2 = true },
                                    [1020207] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020207, Field2 = true },
                                },
                                Field4 = { },
                            },
                            [10203] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType
                            {
                                Field1 = 10203,
                                Field2 = true,
                                Field3 =
                                {
                                    [1020301] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020301, Field2 = true },
                                    [1020302] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020302, Field2 = true },
                                    [1020303] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020303, Field2 = true },
                                    [1020304] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020304, Field2 = true },
                                    [1020305] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020305, Field2 = true },
                                    [1020306] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020306, Field2 = true },
                                    [1020307] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020307, Field2 = true },
                                },
                                Field4 = { },
                            },
                            [10204] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType
                            {
                                Field1 = 10204,
                                Field2 = true,
                                Field3 =
                                {
                                    [1020401] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020401, Field2 = true },
                                    [1020402] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020402, Field2 = true },
                                    [1020403] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020403, Field2 = true },
                                    [1020404] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020404, Field2 = true },
                                    [1020405] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020405, Field2 = true },
                                    [1020406] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020406, Field2 = true },
                                    [1020407] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020407, Field2 = true },
                                    [1020408] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020408, Field2 = true },
                                },
                                Field4 = { },
                            },
                            [10205] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType
                            {
                                Field1 = 10205,
                                Field2 = true,
                                Field3 =
                                {
                                    [1020501] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020501, Field2 = true },
                                    [1020502] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020502, Field2 = true },
                                    [1020503] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020503, Field2 = true },
                                    [1020504] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020504, Field2 = true },
                                    [1020505] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1020505, Field2 = true },
                                },
                                Field4 = { },
                            },
                        },
                        Field4 = false,
                        Field5 = new SC_LobbyPartyInfo_F1ValueType_F5Type
                        {
                            Field1 =
                            {
                                [3110908] = 3110909,
                                [3110917] = 3110919,
                                [3110924] = 3110925,
                                [3110936] = 3110938,
                                [3110939] = 3110941,
                            },
                        },
                        Field8 = 0,
                    },
                    [103] = new SC_LobbyPartyInfo_F1ValueType
                    {
                        Field1 = 103,
                        Field2 =
                        {
                            [10301] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType
                            {
                                Field1 = 10301,
                                Field2 = true,
                                Field3 =
                                {
                                    [1030101] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030101, Field2 = true },
                                    [1030102] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030102, Field2 = true },
                                    [1030103] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030103, Field2 = true },
                                    [1030104] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030104, Field2 = true },
                                    [1030105] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030105, Field2 = true },
                                    [1030106] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030106, Field2 = true },
                                    [1030107] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030107, Field2 = true },
                                    [1030108] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030108, Field2 = true },
                                    [1030109] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030109, Field2 = true },
                                    [1030110] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030110, Field2 = true },
                                },
                                Field4 = { },
                            },
                            [10302] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType
                            {
                                Field1 = 10302,
                                Field2 = true,
                                Field3 =
                                {
                                    [1030201] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030201, Field2 = true },
                                    [1030202] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030202, Field2 = true },
                                    [1030203] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030203, Field2 = true },
                                    [1030204] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030204, Field2 = true },
                                    [1030205] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030205, Field2 = true },
                                    [1030206] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030206, Field2 = true },
                                    [1030207] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030207, Field2 = true },
                                },
                                Field4 = { },
                            },
                            [10303] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType
                            {
                                Field1 = 10303,
                                Field2 = true,
                                Field3 =
                                {
                                    [1030301] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030301, Field2 = true },
                                    [1030302] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030302, Field2 = true },
                                    [1030303] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030303, Field2 = true },
                                    [1030304] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030304, Field2 = true },
                                    [1030305] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030305, Field2 = true },
                                    [1030306] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030306, Field2 = true },
                                    [1030307] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030307, Field2 = true },
                                },
                                Field4 = { },
                            },
                            [10304] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType
                            {
                                Field1 = 10304,
                                Field2 = true,
                                Field3 =
                                {
                                    [1030401] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030401, Field2 = true },
                                    [1030402] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030402, Field2 = true },
                                    [1030403] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030403, Field2 = true },
                                    [1030404] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030404, Field2 = true },
                                    [1030405] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030405, Field2 = true },
                                    [1030406] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030406, Field2 = true },
                                    [1030407] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030407, Field2 = true },
                                    [1030408] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030408, Field2 = true },
                                },
                                Field4 = { },
                            },
                            [10305] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType
                            {
                                Field1 = 10305,
                                Field2 = true,
                                Field3 =
                                {
                                    [1030501] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030501, Field2 = true },
                                    [1030502] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030502, Field2 = true },
                                    [1030503] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030503, Field2 = true },
                                    [1030504] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030504, Field2 = true },
                                    [1030505] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030505, Field2 = true },
                                    [1030506] = new SC_LobbyPartyInfo_F1ValueType_F2ValueType_F3ValueType { Field1 = 1030506, Field2 = true },
                                },
                                Field4 = { },
                            },
                        },
                        Field4 = false,
                        Field5 = new SC_LobbyPartyInfo_F1ValueType_F5Type
                        {
                            Field1 =
                            {
                                [3160910] = 3160911,
                                [3160915] = 3160916,
                                [3160919] = 3160920,
                                [3160925] = 3160926,
                                [3160936] = 3160937,
                            },
                        },
                        Field8 = 0,
                    },
                },
            });
        }

        // HandleDarkZoneGetEthnicInfo 

        // HandleDarkZoneGetUnlockEggStage 

        public override void HandleLobbyBirthdayCareInfo(CS_LobbyBirthdayCareInfo request, Connection connection)
        {
            connection.Send(new SC_LobbyBirthdayCareInfo
            {
                Field1 = (uint)DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                Field2 = false,
            });
        }

        public override void HandleLobbyMessageBoardInfo(CS_LobbyMessageBoardInfo request, Connection connection)
        {
            uint nowUnix = (uint)DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            connection.Send(new SC_LobbyMessageBoardInfo
            {
                Field1 = new SC_LobbyMessageBoardCreate_F1Type
                {
                    Field1 = new SC_LobbyMessageBoardCreate_F1Type_F1Type
                    {
                        Field1 = nowUnix,
                        Field2 = 248,
                    },
                    Field5 =
                    {
                        [1] = 3,
                    },
                },
                Field2 = { },
                Field3 =
                {
                    [77] = new SC_LobbyMessageBoardCreate_F1Type_F1Type { Field1 = nowUnix, Field2 = 77 },
                    [235] = new SC_LobbyMessageBoardCreate_F1Type_F1Type { Field1 = nowUnix, Field2 = 235 },
                    [236] = new SC_LobbyMessageBoardCreate_F1Type_F1Type { Field1 = nowUnix, Field2 = 236 },
                    [248] = new SC_LobbyMessageBoardCreate_F1Type_F1Type { Field1 = nowUnix, Field2 = 248 },
                },
            });
        }

                public override void HandleLobbyAvatarInfo(CS_LobbyAvatarInfo request, Connection connection)
        {
            connection.Send(new SC_LobbyAvatarInfo
            {
                Field1 = new SC_LobbyAvatarInfo_F1Type
                {
                    Field1 = 1071,
                    Field2 = 1002,
                },
            });
        }

        public override void HandleLobbyAvatarSwitch(CS_LobbyAvatarSwitch request, Connection connection)
        {
            connection.Send(new SC_LobbyAvatarSwitch
            {
                Field1 = request.Field1,
            });
        }

        public override void HandleLobbyAvatarClotheChange(CS_LobbyAvatarClotheChange request, Connection connection)
        {
            connection.Send(new SC_LobbyAvatarClotheChange
            {
                Field1 = request.Field1,
            });
        }

        public override void HandleGetLobbyMeilingConfig(CS_GetLobbyMeilingConfig request, Connection connection)
        {
            connection.Send(new SC_GetLobbyMeilingConfig
            {
                Field1 = { 402, 403, 404, 405 },
            });
        }

                public override void HandleLobbyWelcomeSettingPlayed(CS_LobbyWelcomeSettingPlayed request, Connection connection)
        {
            uint nowUnix = (uint)DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            connection.Send(new SC_LobbyWelcomeSettingPlayed
            {
                Field1 = new SC_LobbyWelcomeSettingInfo_F1Type
                {
                    Field1 = true,
                    Field3 = nowUnix,
                    Field4 = 1017,
                    Field5 = true,
                },
            });
        }

        public override void HandleLobbyCancelEvent(CS_LobbyCancelEvent request, Connection connection)
        {
            SC_LobbyCancelEvent response = new SC_LobbyCancelEvent();
            response.Field1.AddRange(request.Field1);
            connection.Send(response);
        }

        public override void HandleLobbyTriggerEvent(CS_LobbyTriggerEvent request, Connection connection)
        {
            connection.Send(new SC_LobbyTriggerEvent
            {
                Field1 = new SC_LobbyGetEventInfo_F2ValueType
                {
                    Field1 = request.Field1,
                },
                Field2 = { },
            });
        }

        public override void HandleLobbyAsmrBegin(CS_LobbyAsmrBegin request, Connection connection)
        {
            connection.Send(new SC_LobbyAsmrBegin
            {
                Field1 = request.Field1,
            });
        }
    }
}
