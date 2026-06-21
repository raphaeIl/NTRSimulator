using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;
using NTRSimulator.Common.Protocol;
using NTRSimulator.Database.Entities;
using NTRSimulator.GameServer.Services;
using NTRSimulator.PcapParser;
using NTRSimulator.Common.Table;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class PlayerCounterHandler(IGunService gunService, ITableService tableService) : PlayerCounterHandlerBase
    {
        public override void HandlePlayerCounterSync(CS_PlayerCounterSync request, Connection connection)
        {
            if (connection.Account == null) return;

            SC_PlayerCounterSync scPlayerCounterSync = new SC_PlayerCounterSync
            {
                Counters =
                {
                    new PlayerCounter
                    {
                        Id = 36,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 72001,
                                Field3 = true,
                                Field4 = 72001
                            },
                        },
                        Counter = new Counter { Id = 36, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 4, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 5, 8100 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 44,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 1203,
                                Field3 = true,
                                Field4 = 1203
                            },
                        },
                        Counter = new Counter { Id = 44, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 200, 10108, 1 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 23,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 46028,
                                Field3 = true,
                                Field4 = 46028
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 70001,
                                Field3 = true,
                                Field4 = 70001
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 44008,
                                Field3 = true,
                                Field4 = 44008
                            },
                        },
                        Counter = new Counter { Id = 23, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 5, 1024 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 99,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 46028,
                                Field3 = true,
                                Field4 = 46028
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 70001,
                                Field3 = true,
                                Field4 = 70001
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 44008,
                                Field3 = true,
                                Field4 = 44008
                            },
                        },
                        Counter = new Counter { Id = 99, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 5, 1032 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 13,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 46035,
                                Field3 = true,
                                Field4 = 46035
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)30, UniqueId = 23011,
                                Field3 = true,
                                Field4 = 23011
                            },
                        },
                        Counter = new Counter { Id = 13, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 486800, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 5, 2 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 8,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 99997,
                                Field3 = true,
                                Field4 = 99997
                            },
                        },
                        Counter = new Counter { Id = 8, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 200, 10102, 1 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 43,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)2, UniqueId = 9,
                                Field3 = true,
                                Field4 = 9
                            },
                        },
                        Counter = new Counter { Id = 43, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 3, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 51, -1, -1, 8 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 45,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)2, UniqueId = 8,
                                Field3 = true,
                                Field4 = 8
                            },
                        },
                        Counter = new Counter { Id = 45, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 200, 10143, 1 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 1234,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)63, UniqueId = 1201,
                                Field3 = true,
                                Field4 = 1201
                            },
                        },
                        Counter = new Counter { Id = 1234, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 11, Max = 0, ValueCase = 0 },
                            Field4 = 750,
                            Field5 = false,
                            Field6 = { 750 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 9,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020006,
                                Field3 = true,
                                Field4 = 3020006
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020007,
                                Field3 = true,
                                Field4 = 3020007
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020010,
                                Field3 = true,
                                Field4 = 3020010
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020019,
                                Field3 = true,
                                Field4 = 3020019
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020003,
                                Field3 = true,
                                Field4 = 3020003
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 48039,
                                Field3 = true,
                                Field4 = 48039
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020001,
                                Field3 = true,
                                Field4 = 3020001
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020016,
                                Field3 = true,
                                Field4 = 3020016
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020020,
                                Field3 = true,
                                Field4 = 3020020
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020021,
                                Field3 = true,
                                Field4 = 3020021
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020025,
                                Field3 = true,
                                Field4 = 3020025
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020027,
                                Field3 = true,
                                Field4 = 3020027
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020011,
                                Field3 = true,
                                Field4 = 3020011
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020015,
                                Field3 = true,
                                Field4 = 3020015
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020017,
                                Field3 = true,
                                Field4 = 3020017
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020008,
                                Field3 = true,
                                Field4 = 3020008
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020004,
                                Field3 = true,
                                Field4 = 3020004
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020013,
                                Field3 = true,
                                Field4 = 3020013
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020022,
                                Field3 = true,
                                Field4 = 3020022
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020028,
                                Field3 = true,
                                Field4 = 3020028
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020009,
                                Field3 = true,
                                Field4 = 3020009
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020014,
                                Field3 = true,
                                Field4 = 3020014
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020018,
                                Field3 = true,
                                Field4 = 3020018
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020024,
                                Field3 = true,
                                Field4 = 3020024
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020002,
                                Field3 = true,
                                Field4 = 3020002
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020005,
                                Field3 = true,
                                Field4 = 3020005
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020012,
                                Field3 = true,
                                Field4 = 3020012
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020023,
                                Field3 = true,
                                Field4 = 3020023
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 3020026,
                                Field3 = true,
                                Field4 = 3020026
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)30, UniqueId = 22020,
                                Field3 = false,
                                Field4 = 22020
                            },
                        },
                        Counter = new Counter { Id = 9, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 28430, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 2, 101 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 66,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)18, UniqueId = 6,
                                Field3 = false,
                                Field4 = 6
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)18, UniqueId = 24,
                                Field3 = false,
                                Field4 = 24
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)49, UniqueId = 102431,
                                Field3 = true,
                                Field4 = 102431
                            },
                        },
                        Counter = new Counter { Id = 66, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 1001, 1024, -1, 1 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 4,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 70003,
                                Field3 = true,
                                Field4 = 70003
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)49, UniqueId = 101721,
                                Field3 = true,
                                Field4 = 101721
                            },
                        },
                        Counter = new Counter { Id = 4, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 5, 1017 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 28,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 1022,
                                Field3 = true,
                                Field4 = 1022
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 44004,
                                Field3 = true,
                                Field4 = 44004
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 46024,
                                Field3 = true,
                                Field4 = 46024
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 70000,
                                Field3 = true,
                                Field4 = 70000
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)49, UniqueId = 100121,
                                Field3 = true,
                                Field4 = 100121
                            },
                        },
                        Counter = new Counter { Id = 28, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 5, 1001 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 18,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 48038,
                                Field3 = true,
                                Field4 = 48038
                            },
                        },
                        Counter = new Counter { Id = 18, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 292, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 401 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 27,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 400101,
                                Field3 = false,
                                Field4 = 400101
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 400104,
                                Field3 = false,
                                Field4 = 400104
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 400105,
                                Field3 = false,
                                Field4 = 400105
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 400107,
                                Field3 = false,
                                Field4 = 400107
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 400108,
                                Field3 = false,
                                Field4 = 400108
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 400109,
                                Field3 = false,
                                Field4 = 400109
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 50078,
                                Field3 = true,
                                Field4 = 50078
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 400102,
                                Field3 = false,
                                Field4 = 400102
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 400103,
                                Field3 = false,
                                Field4 = 400103
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 400106,
                                Field3 = false,
                                Field4 = 400106
                            },
                        },
                        Counter = new Counter { Id = 27, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 0, Max = 9, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 58, 1001 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 3,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 401709,
                                Field3 = false,
                                Field4 = 401709
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 401703,
                                Field3 = false,
                                Field4 = 401703
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 401701,
                                Field3 = false,
                                Field4 = 401701
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 401702,
                                Field3 = false,
                                Field4 = 401702
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 401704,
                                Field3 = false,
                                Field4 = 401704
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 401705,
                                Field3 = false,
                                Field4 = 401705
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 401706,
                                Field3 = false,
                                Field4 = 401706
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 401707,
                                Field3 = false,
                                Field4 = 401707
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 401708,
                                Field3 = false,
                                Field4 = 401708
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 50077,
                                Field3 = true,
                                Field4 = 50077
                            },
                        },
                        Counter = new Counter { Id = 3, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 0, Max = 9, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 58, 1017 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 49,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 1040,
                                Field3 = true,
                                Field4 = 1040
                            },
                        },
                        Counter = new Counter { Id = 49, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 5, 11023 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 17,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 1202,
                                Field3 = true,
                                Field4 = 1202
                            },
                        },
                        Counter = new Counter { Id = 17, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 200, 10184, 1 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 47,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 1210,
                                Field3 = true,
                                Field4 = 1210
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 99001,
                                Field3 = true,
                                Field4 = 99001
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 1204,
                                Field3 = true,
                                Field4 = 1204
                            },
                        },
                        Counter = new Counter { Id = 47, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 200, 10110, 1 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 2,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 71000,
                                Field3 = true,
                                Field4 = 71000
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)49, UniqueId = 100821,
                                Field3 = true,
                                Field4 = 100821
                            },
                        },
                        Counter = new Counter { Id = 2, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 5, 1008 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 19,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010040,
                                Field3 = true,
                                Field4 = 4010040
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010042,
                                Field3 = true,
                                Field4 = 4010042
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010059,
                                Field3 = true,
                                Field4 = 4010059
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010062,
                                Field3 = true,
                                Field4 = 4010062
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010018,
                                Field3 = true,
                                Field4 = 4010018
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010025,
                                Field3 = true,
                                Field4 = 4010025
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010028,
                                Field3 = true,
                                Field4 = 4010028
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010036,
                                Field3 = true,
                                Field4 = 4010036
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010005,
                                Field3 = true,
                                Field4 = 4010005
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010056,
                                Field3 = true,
                                Field4 = 4010056
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010058,
                                Field3 = true,
                                Field4 = 4010058
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010063,
                                Field3 = true,
                                Field4 = 4010063
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010041,
                                Field3 = true,
                                Field4 = 4010041
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010048,
                                Field3 = true,
                                Field4 = 4010048
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010052,
                                Field3 = true,
                                Field4 = 4010052
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010001,
                                Field3 = true,
                                Field4 = 4010001
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010037,
                                Field3 = true,
                                Field4 = 4010037
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010016,
                                Field3 = true,
                                Field4 = 4010016
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010019,
                                Field3 = true,
                                Field4 = 4010019
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010023,
                                Field3 = true,
                                Field4 = 4010023
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010034,
                                Field3 = true,
                                Field4 = 4010034
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010043,
                                Field3 = true,
                                Field4 = 4010043
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010047,
                                Field3 = true,
                                Field4 = 4010047
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010061,
                                Field3 = true,
                                Field4 = 4010061
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 48037,
                                Field3 = true,
                                Field4 = 48037
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010006,
                                Field3 = true,
                                Field4 = 4010006
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010007,
                                Field3 = true,
                                Field4 = 4010007
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010017,
                                Field3 = true,
                                Field4 = 4010017
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010021,
                                Field3 = true,
                                Field4 = 4010021
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010057,
                                Field3 = true,
                                Field4 = 4010057
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010008,
                                Field3 = true,
                                Field4 = 4010008
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010032,
                                Field3 = true,
                                Field4 = 4010032
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010053,
                                Field3 = true,
                                Field4 = 4010053
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010003,
                                Field3 = true,
                                Field4 = 4010003
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010027,
                                Field3 = true,
                                Field4 = 4010027
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010044,
                                Field3 = true,
                                Field4 = 4010044
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010013,
                                Field3 = true,
                                Field4 = 4010013
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010030,
                                Field3 = true,
                                Field4 = 4010030
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010035,
                                Field3 = true,
                                Field4 = 4010035
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010038,
                                Field3 = true,
                                Field4 = 4010038
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010039,
                                Field3 = true,
                                Field4 = 4010039
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010004,
                                Field3 = true,
                                Field4 = 4010004
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010011,
                                Field3 = true,
                                Field4 = 4010011
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010015,
                                Field3 = true,
                                Field4 = 4010015
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010020,
                                Field3 = true,
                                Field4 = 4010020
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010045,
                                Field3 = true,
                                Field4 = 4010045
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010050,
                                Field3 = true,
                                Field4 = 4010050
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010054,
                                Field3 = true,
                                Field4 = 4010054
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010002,
                                Field3 = true,
                                Field4 = 4010002
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010010,
                                Field3 = true,
                                Field4 = 4010010
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010060,
                                Field3 = true,
                                Field4 = 4010060
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010022,
                                Field3 = true,
                                Field4 = 4010022
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010026,
                                Field3 = true,
                                Field4 = 4010026
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010033,
                                Field3 = true,
                                Field4 = 4010033
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010055,
                                Field3 = true,
                                Field4 = 4010055
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010049,
                                Field3 = true,
                                Field4 = 4010049
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010009,
                                Field3 = true,
                                Field4 = 4010009
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010029,
                                Field3 = true,
                                Field4 = 4010029
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010031,
                                Field3 = true,
                                Field4 = 4010031
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010046,
                                Field3 = true,
                                Field4 = 4010046
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010012,
                                Field3 = true,
                                Field4 = 4010012
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010014,
                                Field3 = true,
                                Field4 = 4010014
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010024,
                                Field3 = true,
                                Field4 = 4010024
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 4010051,
                                Field3 = true,
                                Field4 = 4010051
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)30, UniqueId = 22022,
                                Field3 = false,
                                Field4 = 22022
                            },
                        },
                        Counter = new Counter { Id = 19, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 292, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 400 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 51,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 1030,
                                Field3 = true,
                                Field4 = 1030
                            },
                        },
                        Counter = new Counter { Id = 51, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 227, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 409, 1 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 1435,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)9, UniqueId = 34013,
                                Field3 = true,
                                Field4 = 34013
                            },
                        },
                        Counter = new Counter { Id = 1435, ResetPeriod = (Enum_CounterResetNone_CounterResetDaily_CounterResetWeekly_CounterResetMax)2,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            Field4 = 400,
                            Field5 = true,
                            Field6 = { 400 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 37,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)2, UniqueId = 7,
                                Field3 = true,
                                Field4 = 7
                            },
                        },
                        Counter = new Counter { Id = 37, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 200, 10141, 1 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 14,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 46021,
                                Field3 = true,
                                Field4 = 46021
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 46023,
                                Field3 = true,
                                Field4 = 46023
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 1201,
                                Field3 = true,
                                Field4 = 1201
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 44001,
                                Field3 = true,
                                Field4 = 44001
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 44003,
                                Field3 = true,
                                Field4 = 44003
                            },
                        },
                        Counter = new Counter { Id = 14, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 200, 10103, 1 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 1434,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)3, UniqueId = 1,
                                Field3 = true,
                                Field4 = 1
                            },
                        },
                        Counter = new Counter { Id = 1434, ResetPeriod = (Enum_CounterResetNone_CounterResetDaily_CounterResetWeekly_CounterResetMax)1,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            Field4 = 400,
                            Field5 = false,
                            Field6 = { 400 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 63,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)2, UniqueId = 6,
                                Field3 = true,
                                Field4 = 6
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 2020006,
                                Field3 = true,
                                Field4 = 2020006
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 2020003,
                                Field3 = true,
                                Field4 = 2020003
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 2020001,
                                Field3 = true,
                                Field4 = 2020001
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 2020002,
                                Field3 = true,
                                Field4 = 2020002
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 2020004,
                                Field3 = true,
                                Field4 = 2020004
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 2020005,
                                Field3 = true,
                                Field4 = 2020005
                            },
                        },
                        Counter = new Counter { Id = 63, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 2835, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 201, 21, 1 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 46,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 48019,
                                Field3 = true,
                                Field4 = 48019
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 2000001,
                                Field3 = true,
                                Field4 = 2000001
                            },
                        },
                        Counter = new Counter { Id = 46, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 200, 10110, 1, 1 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 16,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 1021,
                                Field3 = true,
                                Field4 = 1021
                            },
                        },
                        Counter = new Counter { Id = 16, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 191, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 5, 12 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 48,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040016,
                                Field3 = true,
                                Field4 = 5040016
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040024,
                                Field3 = true,
                                Field4 = 5040024
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040026,
                                Field3 = true,
                                Field4 = 5040026
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040001,
                                Field3 = true,
                                Field4 = 5040001
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040002,
                                Field3 = true,
                                Field4 = 5040002
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040010,
                                Field3 = true,
                                Field4 = 5040010
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040014,
                                Field3 = true,
                                Field4 = 5040014
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040015,
                                Field3 = true,
                                Field4 = 5040015
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040017,
                                Field3 = true,
                                Field4 = 5040017
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040027,
                                Field3 = true,
                                Field4 = 5040027
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040028,
                                Field3 = true,
                                Field4 = 5040028
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040007,
                                Field3 = true,
                                Field4 = 5040007
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040009,
                                Field3 = true,
                                Field4 = 5040009
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040019,
                                Field3 = true,
                                Field4 = 5040019
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040021,
                                Field3 = true,
                                Field4 = 5040021
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040003,
                                Field3 = true,
                                Field4 = 5040003
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040005,
                                Field3 = true,
                                Field4 = 5040005
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040020,
                                Field3 = true,
                                Field4 = 5040020
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040023,
                                Field3 = true,
                                Field4 = 5040023
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040004,
                                Field3 = true,
                                Field4 = 5040004
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040011,
                                Field3 = true,
                                Field4 = 5040011
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040018,
                                Field3 = true,
                                Field4 = 5040018
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040025,
                                Field3 = true,
                                Field4 = 5040025
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040030,
                                Field3 = true,
                                Field4 = 5040030
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040008,
                                Field3 = true,
                                Field4 = 5040008
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040012,
                                Field3 = true,
                                Field4 = 5040012
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040006,
                                Field3 = true,
                                Field4 = 5040006
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040013,
                                Field3 = true,
                                Field4 = 5040013
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040022,
                                Field3 = true,
                                Field4 = 5040022
                            },
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 5040029,
                                Field3 = true,
                                Field4 = 5040029
                            },
                        },
                        Counter = new Counter { Id = 48, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 105, 4 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 1436,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)59, UniqueId = 12005,
                                Field3 = true,
                                Field4 = 12005
                            },
                        },
                        Counter = new Counter { Id = 1436, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            Field4 = 400,
                            Field5 = true,
                            Field6 = { 400 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 7,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1, UniqueId = 99998,
                                Field3 = true,
                                Field4 = 99998
                            },
                        },
                        Counter = new Counter { Id = 7, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            Field4 = 0,
                            Field5 = false,
                            Field6 = { 200, 10101, 1 }
                        }
                    },
                }
            };

            //scPlayerCounterSync = PcapUtils.GetPacketFromPcap<SC_PlayerCounterSync>(MsgId.MsgScPlayerCounterSync, PacketType.RESPONSE);

            connection.SendAutoEncrypted(scPlayerCounterSync);

            SC_PlayerStatusCounterSync playerStatusCounterSync = new SC_PlayerStatusCounterSync
            {
                Field2 = 4,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1571 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 48026 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1341 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 30, Field2 = 22009 },
                }
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync2 = new SC_PlayerStatusCounterSync
            {
                Field2 = 2,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1561 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1261 },
                }
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync3 = new SC_PlayerStatusCounterSync
            {
                Field2 = 8,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1581 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40011 },
                }
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync4 = new SC_PlayerStatusCounterSync
            {
                Field2 = 60,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4000010 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 11012 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 73012 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4000004 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 1011 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 73008 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 29202 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 11008 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 99106 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 1010 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 33003 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 1033 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 48036 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 1043 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 29000 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4000019 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 1018 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 99102 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 28000 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 99101 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 37, Field2 = 380020 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 45, Field2 = 3 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4000014 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 99110 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4000005 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 33001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 11003 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 99109 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 2011 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 14005 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 34001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4000015 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 1012 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 11011 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 45, Field2 = 2 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 99100 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 64, Field2 = 19 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 99201 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 73009 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 99207 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 12008 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4000012 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 11007 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 33002 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 99108 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4000011 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 1020 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 41002 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4000001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 1017 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 1013 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 71, Field2 = 38003 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4000006 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 29004 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 11005 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 45, Field2 = 1 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 2001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 2010 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 10999 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 73001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 73005 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 32001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4000003 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 1045 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 73002 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 37, Field2 = 280110 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4000017 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 1019 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4000016 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4000007 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 1044 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 73007 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 73010 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 29001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 37, Field2 = 390020 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 99204 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 99209 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 99103 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 99999 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 1042 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 2000 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 37, Field2 = 110141 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 99105 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 99203 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 1015 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 11006 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 14000 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 73011 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 12007 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 73004 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 11004 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4000009 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 99205 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 21000 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 45, Field2 = 5 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 99111 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 29301 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 16008 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 99104 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 29401 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 73003 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 99206 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4000020 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 11002 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4000018 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 73006 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 11009 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4000013 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 1041 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 1014 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4000002 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 99107 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 12009 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4000008 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 10998 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 1016 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 1039 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 10997 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 38001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 99202 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 91005 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 99208 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 45, Field2 = 4 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 99210 },
                }
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync5 = new SC_PlayerStatusCounterSync
            {
                Field2 = 3,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 402405 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 402402 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 402410 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 402404 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 49, Field2 = 102411 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 20002 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 402406 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 402401 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 402409 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 402403 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 64, Field2 = 16 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 402408 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 402407 },
                }
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync6 = new SC_PlayerStatusCounterSync
            {
                Field2 = 30,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 31, Field2 = 1070 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 31, Field2 = 1063 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 31, Field2 = 1061 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 31, Field2 = 1078 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 31, Field2 = 1067 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 31, Field2 = 1071 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 31, Field2 = 1079 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 31, Field2 = 1073 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 31, Field2 = 1076 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 31, Field2 = 1065 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 31, Field2 = 1062 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 31, Field2 = 1075 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 31, Field2 = 1064 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 31, Field2 = 1069 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 31, Field2 = 1080 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 31, Field2 = 1072 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 31, Field2 = 1068 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 31, Field2 = 1077 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 31, Field2 = 1066 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 31, Field2 = 1074 },
                }
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync7 = new SC_PlayerStatusCounterSync
            {
                Field2 = 9,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 401707 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 401701 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 401703 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 64, Field2 = 18 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 400110 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 400103 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 401710 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 49, Field2 = 101711 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 400106 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 49, Field2 = 100111 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 400105 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 49, Field2 = 100811 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 400102 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 64, Field2 = 20 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 401702 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 400108 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 400805 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 400801 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 400803 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 400101 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 400806 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 400107 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 400802 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 401705 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 400810 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 400804 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 401708 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 401706 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 401704 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 400807 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 401709 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 400104 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 400808 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 400109 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 400809 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 64, Field2 = 15 },
                }
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync8 = new SC_PlayerStatusCounterSync
            {
                Field2 = 5,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1311 },
                }
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync9 = new SC_PlayerStatusCounterSync
            {
                Field2 = 6,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1361 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40145 },
                }
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync10 = new SC_PlayerStatusCounterSync
            {
                Field2 = 724,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 14002 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 14007 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 14001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 14003 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 14006 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 14004 },
                }
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync11 = new SC_PlayerStatusCounterSync
            {
                Field2 = 10,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40140 },
                }
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync12 = new SC_PlayerStatusCounterSync
            {
                Field2 = 1,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 16101 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40059 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 26001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40063 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 10997 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 2, Field2 = 2 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4030005 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 12002 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 23000 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000021 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000004 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1271 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 11008 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40062 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 29002 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1722 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 29000 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 11007 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 12002 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 24000 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000012 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 30, Field2 = 22010 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1511 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000009 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4030008 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4030011 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40060 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000010 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000015 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 29002 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4030007 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 20002 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 13000 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 16004 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 24002 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 10998 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40061 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 71, Field2 = 43008 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000013 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 33002 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000020 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 12003 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 12001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 12003 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 29005 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000016 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1491 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 29003 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000008 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 29101 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 2, Field2 = 47 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 12001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 99103 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 31000 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 11010 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 29202 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 31002 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1530 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40103 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 48027 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000017 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 29005 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 49, Field2 = 100831 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 2, Field2 = 1 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 11012 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40236 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 12000 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000026 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 11101 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 11002 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 12000 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 29003 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 16004 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 11005 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 14000 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 1240 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 16000 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 16000 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 11004 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 16201 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 24001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 39001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40064 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 31002 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 11009 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000002 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 29001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 64, Field2 = 1 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 16005 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 99100 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 20000 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 49, Field2 = 101731 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1241 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 64, Field2 = 3 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 37, Field2 = 440080 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000027 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4030009 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 31001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 22000 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000028 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 28000 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 10999 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 12010 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 99108 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 65, Field2 = 10205 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000022 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 15100 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 14005 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40102 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 13000 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 16005 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 11101 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 30001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 29301 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 64, Field2 = 2 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 1351 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 71, Field2 = 43001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000003 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000006 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 30001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40104 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 15100 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4030001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 12010 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4030012 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4030002 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000025 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000007 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 12007 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4030003 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000014 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 11006 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000005 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 20000 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 12005 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 32001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000019 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 99111 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 33001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 1023 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 31001 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4030006 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000023 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000011 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000024 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4030004 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 26002 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 31000 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 11010 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 49, Field2 = 100131 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 21000 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 26002 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 25000 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 3000018 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 16008 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 23, Field2 = 11003 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 1, Field2 = 4030010 },
                    new SC_PlayerStatusCounterSync_F1Type { Field1 = 63, Field2 = 40105 },
                }
            };

            connection.Send(11, playerStatusCounterSync, playerStatusCounterSync2, playerStatusCounterSync3, playerStatusCounterSync4, playerStatusCounterSync5, playerStatusCounterSync6, playerStatusCounterSync7, playerStatusCounterSync8, playerStatusCounterSync9, playerStatusCounterSync10, playerStatusCounterSync11, playerStatusCounterSync12);

            SC_CountSection countSection = new SC_CountSection
            {
                Field1 =
                 {
                     new SC_CommonQuestCountReset_F1Type
                     {
                         Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Guide,
                         Field4 =
                         {
                             { 4010031u, false },
                             { 70000u, false },
                             { 15100u, false },
                             { 26001u, false },
                             { 4010034u, false },
                             { 29202u, false },
                             { 2020006u, false },
                             { 39001u, false },
                             { 4010025u, false },
                             { 1039u, false },
                             { 46024u, false },
                             { 12003u, false },
                             { 29001u, false },
                             { 4000017u, false },
                             { 99206u, false },
                             { 4010044u, false },
                             { 16008u, false },
                             { 1042u, false },
                             { 4010024u, false },
                             { 11002u, false },
                             { 3020028u, false },
                             { 4000004u, false },
                             { 28000u, false },
                             { 4010050u, false },
                             { 3020022u, false },
                             { 99202u, false },
                             { 1010u, false },
                             { 99100u, false },
                             { 99205u, false },
                             { 4000013u, false },
                             { 99111u, false },
                             { 31002u, false },
                             { 70003u, false },
                             { 4010058u, false },
                             { 4010015u, false },
                             { 4010038u, false },
                             { 4010054u, false },
                             { 4010012u, false },
                             { 99103u, false },
                             { 4010055u, false },
                             { 3020014u, false },
                             { 4010037u, false },
                             { 73009u, false },
                             { 1021u, false },
                             { 1043u, false },
                             { 25000u, false },
                             { 4010001u, true },
                             { 29003u, false },
                             { 1014u, false },
                             { 4010056u, false },
                             { 2020003u, false },
                             { 3020002u, false },
                             { 2011u, false },
                             { 4010035u, false },
                             { 2020001u, false },
                             { 3020018u, false },
                             { 4000001u, true },
                             { 4010007u, false },
                             { 73004u, false },
                             { 1030u, false },
                             { 4000008u, false },
                             { 4010018u, false },
                             { 44004u, false },
                             { 29401u, false },
                             { 73010u, false },
                             { 1202u, false },
                             { 2001u, false },
                             { 4010019u, false },
                             { 4010008u, false },
                             { 4000009u, false },
                             { 1011u, false },
                             { 4010039u, false },
                             { 48019u, false },
                             { 46028u, false },
                             { 4010048u, false },
                             { 1040u, false },
                             { 12010u, false },
                             { 2010u, false },
                             { 16000u, false },
                             { 16201u, false },
                             { 1210u, false },
                             { 48037u, false },
                             { 402401u, false },
                             { 24000u, false },
                             { 4000007u, false },
                             { 4010006u, true },
                             { 3020005u, false },
                             { 34001u, false },
                             { 1033u, false },
                             { 11005u, false },
                             { 4010057u, false },
                             { 16005u, false },
                             { 14005u, false },
                             { 1016u, false },
                             { 1201u, false },
                             { 3020008u, false },
                             { 3020016u, false },
                             { 29101u, false },
                             { 4010023u, false },
                             { 3020011u, false },
                             { 12001u, false },
                             { 31000u, false },
                             { 1044u, false },
                             { 4010021u, false },
                             { 99107u, false },
                             { 26002u, false },
                             { 5040001u, true },
                             { 21000u, false },
                             { 4010042u, false },
                             { 99105u, false },
                             { 46021u, false },
                             { 4010033u, false },
                             { 4010028u, false },
                             { 4000014u, false },
                             { 11007u, false },
                             { 1017u, false },
                             { 1041u, false },
                             { 99109u, false },
                             { 4010029u, false },
                             { 12002u, false },
                             { 3020003u, false },
                             { 4010013u, false },
                             { 4010005u, true },
                             { 4010027u, false },
                             { 4000015u, false },
                             { 4000019u, false },
                             { 33001u, false },
                             { 4000011u, false },
                             { 4010049u, false },
                             { 4010030u, false },
                             { 44001u, false },
                             { 2000u, false },
                             { 4010020u, false },
                             { 1015u, false },
                             { 3020010u, false },
                             { 16004u, false },
                             { 4000012u, false },
                             { 73005u, false },
                             { 73001u, false },
                             { 4010036u, false },
                             { 2020002u, false },
                             { 4010011u, false },
                             { 24001u, false },
                             { 3020007u, false },
                             { 4010053u, false },
                             { 3020012u, false },
                             { 400101u, false },
                             { 99998u, false },
                             { 48039u, false },
                             { 20002u, false },
                             { 99203u, false },
                             { 1023u, false },
                             { 33002u, false },
                             { 29004u, false },
                             { 1203u, false },
                             { 11012u, false },
                             { 46023u, false },
                             { 4010046u, false },
                             { 3020021u, false },
                             { 1019u, false },
                             { 11010u, false },
                             { 3020004u, false },
                             { 4000010u, false },
                             { 3020019u, false },
                             { 11004u, false },
                             { 11006u, false },
                             { 11008u, false },
                             { 4010032u, false },
                             { 3020001u, false },
                             { 3020006u, false },
                             { 99204u, false },
                             { 12007u, false },
                             { 4000006u, false },
                             { 3020015u, false },
                             { 10997u, false },
                             { 70001u, false },
                             { 4000016u, false },
                             { 99106u, false },
                             { 73007u, false },
                             { 99001u, false },
                             { 4010052u, false },
                             { 29002u, false },
                             { 12008u, false },
                             { 20000u, false },
                             { 24002u, false },
                             { 3020017u, false },
                             { 72001u, false },
                             { 4000020u, false },
                             { 1012u, false },
                             { 4000002u, true },
                             { 3020020u, false },
                             { 4000018u, false },
                             { 3020024u, false },
                             { 11011u, false },
                             { 12000u, false },
                             { 23000u, false },
                             { 1240u, false },
                             { 30001u, false },
                             { 4010040u, false },
                             { 4010017u, false },
                             { 14000u, false },
                             { 12005u, false },
                             { 73011u, false },
                             { 4010010u, false },
                             { 3020026u, false },
                             { 4010045u, false },
                             { 1204u, false },
                             { 1022u, false },
                             { 4010009u, false },
                             { 31001u, false },
                             { 2020005u, false },
                             { 4010051u, false },
                             { 48038u, false },
                             { 4010014u, false },
                             { 2000001u, true },
                             { 32001u, false },
                             { 4010026u, false },
                             { 73008u, false },
                             { 4010022u, false },
                             { 99108u, false },
                             { 4010016u, false },
                             { 3020009u, false },
                             { 3020013u, false },
                             { 2020004u, false },
                             { 4010002u, true },
                             { 48036u, false },
                             { 4000005u, false },
                             { 44003u, false },
                             { 4010003u, true },
                             { 41002u, false },
                             { 13000u, false },
                             { 1018u, false },
                             { 11101u, false },
                             { 99101u, false },
                             { 71000u, false },
                             { 11003u, false },
                             { 4010059u, false },
                             { 11009u, false },
                             { 73002u, false },
                             { 4010043u, false },
                             { 91005u, false },
                             { 99201u, false },
                             { 4010047u, false },
                             { 400801u, false },
                             { 4010041u, false },
                             { 3020027u, false },
                             { 10998u, false },
                             { 3020023u, false },
                             { 16101u, false },
                             { 29301u, false },
                             { 99102u, false },
                             { 4010004u, true },
                             { 44008u, false },
                             { 1020u, false },
                             { 29005u, false },
                             { 73003u, false },
                             { 99104u, false },
                             { 10999u, false },
                             { 1013u, false },
                             { 4000003u, false },
                             { 99110u, false },
                             { 22000u, false },
                             { 73012u, false },
                             { 1045u, false },
                             { 29000u, false },
                             { 3020025u, false },
                             { 12009u, false },
                             { 38001u, false },
                             { 401701u, false },
                             { 99997u, false },
                             { 73006u, false },
                         },
                         Field5 = { },
                         Field6 = { },
                     }
                 }
            };
            connection.SendUnsequenced(8, countSection);

             SC_CountSection countSection2 = new SC_CountSection
            {
                Field1 =
                 {
                     new SC_CommonQuestCountReset_F1Type
                     {
                         Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.WeeklySimCombat,
                         Field4 = { },
                         Field5 = { },
                         Field6 = { },
                     },
                     new SC_CommonQuestCountReset_F1Type
                     {
                         Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.PvpDailyPoints,
                         Field4 = { },
                         Field5 = { },
                         Field6 = { },
                     },
                     new SC_CommonQuestCountReset_F1Type
                     {
                         Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.PvpGuide,
                         Field4 = { },
                         Field5 = { },
                         Field6 = { },
                     },
                     new SC_CommonQuestCountReset_F1Type
                     {
                         Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.BattlepassDaily,
                         Field4 = { },
                         Field5 = { },
                         Field6 = { },
                     },
                     new SC_CommonQuestCountReset_F1Type
                     {
                         Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.BattlepassShare,
                         Field4 = { },
                         Field5 = { },
                         Field6 = { },
                     },
                     new SC_CommonQuestCountReset_F1Type
                     {
                         Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.BattlepassWeekly,
                         Field4 = { },
                         Field5 = { },
                         Field6 = { },
                     },
                     new SC_CommonQuestCountReset_F1Type
                     {
                         Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.DarkZoneCycle,
                         Field4 = { },
                         Field5 = { },
                         Field6 = { },
                     },
                     new SC_CommonQuestCountReset_F1Type
                     {
                         Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.DarkZonePermanent,
                         Field4 = { },
                         Field5 = { },
                         Field6 = { },
                     },
                     new SC_CommonQuestCountReset_F1Type
                     {
                         Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.WeeklyChallenge,
                         Field4 = { },
                         Field5 = { },
                         Field6 = { },
                     },
                     new SC_CommonQuestCountReset_F1Type
                     {
                         Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Achievement,
                         Field4 = { },
                         Field5 = { },
                         Field6 = { },
                     },
                     new SC_CommonQuestCountReset_F1Type
                     {
                         Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Daily,
                         Field4 =
                         {
                             { 9u, true },
                             { 8u, true },
                             { 2u, true },
                             { 6u, false },
                             { 7u, true },
                             { 1u, true },
                         },
                         Field5 = { },
                         Field6 = { },
                     },
                     new SC_CommonQuestCountReset_F1Type
                     {
                         Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Week,
                         Field4 =
                         {
                             { 1u, false },
                         },
                         Field5 = { },
                         Field6 = { },
                     },
                     new SC_CommonQuestCountReset_F1Type
                     {
                         Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.BattlepassAccept,
                         Field4 = { },
                         Field5 = { },
                         Field6 = { },
                     },
                     new SC_CommonQuestCountReset_F1Type
                     {
                         Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.ThemeWarmUp,
                         Field4 = { },
                         Field5 = { },
                         Field6 = { },
                     },
                     new SC_CommonQuestCountReset_F1Type
                     {
                         Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Newbee,
                         Field4 = { },
                         Field5 = { },
                         Field6 = { },
                     },
                     new SC_CommonQuestCountReset_F1Type
                     {
                         Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.MonopolyDaily,
                         Field4 =
                         {
                             { 13u, false },
                             { 19u, false },
                             { 25u, false },
                             { 6u, false },
                             { 1u, false },
                             { 7u, false },
                         },
                         Field5 = { },
                         Field6 = { },
                     },
                     new SC_CommonQuestCountReset_F1Type
                     {
                         Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.MonopolyTask,
                         Field4 = { },
                         Field5 = { },
                         Field6 = { },
                     },
                     new SC_CommonQuestCountReset_F1Type
                     {
                         Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Amo,
                         Field4 = { },
                         Field5 = { },
                         Field6 = { },
                     },
                     new SC_CommonQuestCountReset_F1Type
                     {
                         Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.DarkZoneAchievement,
                         Field4 =
                         {
                             { 1090u, false },
                             { 1054u, false },
                             { 1066u, false },
                             { 1062u, false },
                             { 1051u, false },
                             { 1092u, false },
                             { 1078u, false },
                             { 1046u, false },
                             { 1039u, false },
                             { 1052u, false },
                             { 1043u, false },
                             { 1053u, false },
                             { 1044u, false },
                             { 1060u, false },
                             { 1068u, false },
                             { 1050u, false },
                             { 1058u, false },
                             { 1082u, false },
                             { 1042u, false },
                             { 1056u, false },
                             { 1055u, false },
                             { 1076u, false },
                             { 1057u, false },
                             { 1086u, false },
                             { 1064u, false },
                             { 1040u, false },
                             { 1072u, false },
                         },
                         Field5 =
                         {
                             { 26u, true },
                             { 20u, true },
                             { 22u, true },
                             { 27u, true },
                             { 28u, true },
                             { 29u, true },
                         },
                         Field6 = { },
                     },
                     new SC_CommonQuestCountReset_F1Type
                     {
                         Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.SimCafeGrade,
                         Field4 = { },
                         Field5 = { },
                         Field6 = { },
                     },
                 }
            };
            connection.SendUnsequenced(1, countSection2);

            SC_CountSection countSection3 = new SC_CountSection
            {
                Field1 =
                  {
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Back,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Treasure,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.SimCafeWarmUp,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Bingo,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.ActivityBingo,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.ActivityCollection,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.GeopoliticalWarmUp,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.ControlFight,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.ActivityDispatch,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.GeopoliticalDaily,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.GeopoliticalFormal,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.ActivityMainTask,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.RubyShop,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.BeginnerLevel,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.StageFight,
                          Field4 =
                          {
                              { 5u, true },
                              { 1u, true },
                              { 2u, true },
                              { 3u, true },
                              { 4u, true },
                          },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.SandBox,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Rouge,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.GunExamine,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.TpsShoot,
                          Field4 =
                          {
                              { 100121u, false },
                              { 102431u, false },
                              { 100111u, false },
                              { 100821u, false },
                              { 100131u, false },
                              { 101711u, false },
                              { 100811u, false },
                              { 100831u, false },
                              { 101731u, false },
                              { 101721u, false },
                          },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.ActivityFreeSkin,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                  }
            };
            connection.SendUnsequenced(countSection3);

            SC_CountSection countSection4 = new SC_CountSection
            {
                Field1 =
                  {
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.RichMan,
                          Field4 =
                          {
                              { 2005u, false },
                              { 3002u, false },
                              { 3009u, false },
                              { 3010u, false },
                              { 7001u, false },
                              { 4006u, false },
                              { 4005u, false },
                              { 5006u, false },
                              { 3001u, false },
                              { 2004u, false },
                              { 7005u, false },
                              { 2010u, false },
                              { 5001u, false },
                              { 3004u, false },
                              { 2009u, false },
                              { 3005u, false },
                              { 2001u, false },
                              { 2006u, false },
                              { 2002u, false },
                              { 3006u, false },
                              { 4001u, false },
                              { 5005u, false },
                          },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Dungeon,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Shootspace,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.BattlepassSeason,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.KittyCafe,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.BackBattlePass,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.ActivityItemTask,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Motorcycle,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.AchievementChallenge,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.LoadingPicture,
                          Field4 =
                          {
                              { 20353u, false },
                              { 1581u, false },
                              { 1201u, false },
                              { 20351u, false },
                              { 20352u, false },
                          },
                          Field5 = { },
                          Field6 =
                          {
                              { 1201u, 1761315960L },
                              { 1581u, 1773698995L },
                          },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.NewSystem,
                          Field4 =
                          {
                              { 1u, false },
                              { 2u, false },
                              { 3u, false },
                              { 19u, false },
                          },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.PastEventStage,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Lottery,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.EventReward,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.WorldBoss,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.LobbyMiniGame,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.KittyCafe2,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.EventTask,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.YunTuChess,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.BattlepassDailyTimeLimit,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                  }
            };
            connection.SendUnsequenced(1, countSection4);

            SC_CountSection countSection5 = new SC_CountSection
            {
                Field1 =
                  {
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.BattlepassWeeklyTimeLimit,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.BattlepassSeasonTimeLimit,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.LobbyPartyNotes,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.LotteryV2,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.AchievementPs,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.ButtGame,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.OneTime,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.TransformGunUnlock,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.EventEndlessTower,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.LobbyPlant,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      new SC_CommonQuestCountReset_F1Type
                      {
                          Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.ButtGameV2,
                          Field4 = { },
                          Field5 = { },
                          Field6 = { },
                      },
                      //new SC_CommonQuestCountReset_F1Type
                      //{
                      //    Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.MaylingStoreSpecialRefresh,
                      //    Field4 = { },
                      //    Field5 = { },
                      //    Field6 = { },
                      //},
                  }
            };
            connection.SendUnsequenced(countSection5);

            SC_CountSection countSection6 = new SC_CountSection
            {
                Field1 =
                {
                        new SC_CommonQuestCountReset_F1Type
                        {
                            Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Guide,
                            Field4 =
                            {
                           
                                //{ 44051, false },
                            
                            },
                            Field5 = { },
                            Field6 = { },
                        },
                    }
            };

            List<GunData> gunData = tableService.GetTable<GunData>();

            foreach (Gun gun in gunService.GetPlayerGuns(connection.Account.Uid))
            {
                uint dormId = gunData.Where(g => g.GunId == gun.GunId).FirstOrDefault().Field60[0];

                countSection6.Field1[0].Field4.Add(dormId, false);
            }

            connection.SendUnsequenced(countSection6);
        }
    }
}
