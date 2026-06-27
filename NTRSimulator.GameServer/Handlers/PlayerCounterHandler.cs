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
                                SystemId = (PlayerCounterSystem)1, UniqueId = 72001,
                                Counter = true,
                                GBBABCAJHBL = 72001
                            },
                        },
                        Counter = new Counter { Id = 36, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 4, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 5, 8100 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 44,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 1203,
                                Counter = true,
                                GBBABCAJHBL = 1203
                            },
                        },
                        Counter = new Counter { Id = 44, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 200, 10108, 1 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 23,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 46028,
                                Counter = true,
                                GBBABCAJHBL = 46028
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 70001,
                                Counter = true,
                                GBBABCAJHBL = 70001
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 44008,
                                Counter = true,
                                GBBABCAJHBL = 44008
                            },
                        },
                        Counter = new Counter { Id = 23, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 5, 1024 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 99,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 46028,
                                Counter = true,
                                GBBABCAJHBL = 46028
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 70001,
                                Counter = true,
                                GBBABCAJHBL = 70001
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 44008,
                                Counter = true,
                                GBBABCAJHBL = 44008
                            },
                        },
                        Counter = new Counter { Id = 99, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 5, 1032 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 13,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 46035,
                                Counter = true,
                                GBBABCAJHBL = 46035
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)30, UniqueId = 23011,
                                Counter = true,
                                GBBABCAJHBL = 23011
                            },
                        },
                        Counter = new Counter { Id = 13, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 486800, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 5, 2 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 8,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 99997,
                                Counter = true,
                                GBBABCAJHBL = 99997
                            },
                        },
                        Counter = new Counter { Id = 8, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 200, 10102, 1 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 43,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)2, UniqueId = 9,
                                Counter = true,
                                GBBABCAJHBL = 9
                            },
                        },
                        Counter = new Counter { Id = 43, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 3, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 51, -1, -1, 8 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 45,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)2, UniqueId = 8,
                                Counter = true,
                                GBBABCAJHBL = 8
                            },
                        },
                        Counter = new Counter { Id = 45, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 200, 10143, 1 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 1234,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)63, UniqueId = 1201,
                                Counter = true,
                                GBBABCAJHBL = 1201
                            },
                        },
                        Counter = new Counter { Id = 1234, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 11, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 750,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 750 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 9,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020006,
                                Counter = true,
                                GBBABCAJHBL = 3020006
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020007,
                                Counter = true,
                                GBBABCAJHBL = 3020007
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020010,
                                Counter = true,
                                GBBABCAJHBL = 3020010
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020019,
                                Counter = true,
                                GBBABCAJHBL = 3020019
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020003,
                                Counter = true,
                                GBBABCAJHBL = 3020003
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 48039,
                                Counter = true,
                                GBBABCAJHBL = 48039
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020001,
                                Counter = true,
                                GBBABCAJHBL = 3020001
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020016,
                                Counter = true,
                                GBBABCAJHBL = 3020016
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020020,
                                Counter = true,
                                GBBABCAJHBL = 3020020
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020021,
                                Counter = true,
                                GBBABCAJHBL = 3020021
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020025,
                                Counter = true,
                                GBBABCAJHBL = 3020025
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020027,
                                Counter = true,
                                GBBABCAJHBL = 3020027
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020011,
                                Counter = true,
                                GBBABCAJHBL = 3020011
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020015,
                                Counter = true,
                                GBBABCAJHBL = 3020015
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020017,
                                Counter = true,
                                GBBABCAJHBL = 3020017
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020008,
                                Counter = true,
                                GBBABCAJHBL = 3020008
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020004,
                                Counter = true,
                                GBBABCAJHBL = 3020004
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020013,
                                Counter = true,
                                GBBABCAJHBL = 3020013
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020022,
                                Counter = true,
                                GBBABCAJHBL = 3020022
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020028,
                                Counter = true,
                                GBBABCAJHBL = 3020028
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020009,
                                Counter = true,
                                GBBABCAJHBL = 3020009
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020014,
                                Counter = true,
                                GBBABCAJHBL = 3020014
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020018,
                                Counter = true,
                                GBBABCAJHBL = 3020018
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020024,
                                Counter = true,
                                GBBABCAJHBL = 3020024
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020002,
                                Counter = true,
                                GBBABCAJHBL = 3020002
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020005,
                                Counter = true,
                                GBBABCAJHBL = 3020005
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020012,
                                Counter = true,
                                GBBABCAJHBL = 3020012
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020023,
                                Counter = true,
                                GBBABCAJHBL = 3020023
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 3020026,
                                Counter = true,
                                GBBABCAJHBL = 3020026
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)30, UniqueId = 22020,
                                Counter = false,
                                GBBABCAJHBL = 22020
                            },
                        },
                        Counter = new Counter { Id = 9, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 28430, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 2, 101 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 66,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)18, UniqueId = 6,
                                Counter = false,
                                GBBABCAJHBL = 6
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)18, UniqueId = 24,
                                Counter = false,
                                GBBABCAJHBL = 24
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)49, UniqueId = 102431,
                                Counter = true,
                                GBBABCAJHBL = 102431
                            },
                        },
                        Counter = new Counter { Id = 66, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 1001, 1024, -1, 1 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 4,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 70003,
                                Counter = true,
                                GBBABCAJHBL = 70003
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)49, UniqueId = 101721,
                                Counter = true,
                                GBBABCAJHBL = 101721
                            },
                        },
                        Counter = new Counter { Id = 4, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 5, 1017 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 28,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 1022,
                                Counter = true,
                                GBBABCAJHBL = 1022
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 44004,
                                Counter = true,
                                GBBABCAJHBL = 44004
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 46024,
                                Counter = true,
                                GBBABCAJHBL = 46024
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 70000,
                                Counter = true,
                                GBBABCAJHBL = 70000
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)49, UniqueId = 100121,
                                Counter = true,
                                GBBABCAJHBL = 100121
                            },
                        },
                        Counter = new Counter { Id = 28, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 5, 1001 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 18,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 48038,
                                Counter = true,
                                GBBABCAJHBL = 48038
                            },
                        },
                        Counter = new Counter { Id = 18, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 292, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 401 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 27,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 400101,
                                Counter = false,
                                GBBABCAJHBL = 400101
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 400104,
                                Counter = false,
                                GBBABCAJHBL = 400104
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 400105,
                                Counter = false,
                                GBBABCAJHBL = 400105
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 400107,
                                Counter = false,
                                GBBABCAJHBL = 400107
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 400108,
                                Counter = false,
                                GBBABCAJHBL = 400108
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 400109,
                                Counter = false,
                                GBBABCAJHBL = 400109
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 50078,
                                Counter = true,
                                GBBABCAJHBL = 50078
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 400102,
                                Counter = false,
                                GBBABCAJHBL = 400102
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 400103,
                                Counter = false,
                                GBBABCAJHBL = 400103
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 400106,
                                Counter = false,
                                GBBABCAJHBL = 400106
                            },
                        },
                        Counter = new Counter { Id = 27, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 0, Max = 9, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 58, 1001 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 3,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 401709,
                                Counter = false,
                                GBBABCAJHBL = 401709
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 401703,
                                Counter = false,
                                GBBABCAJHBL = 401703
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 401701,
                                Counter = false,
                                GBBABCAJHBL = 401701
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 401702,
                                Counter = false,
                                GBBABCAJHBL = 401702
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 401704,
                                Counter = false,
                                GBBABCAJHBL = 401704
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 401705,
                                Counter = false,
                                GBBABCAJHBL = 401705
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 401706,
                                Counter = false,
                                GBBABCAJHBL = 401706
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 401707,
                                Counter = false,
                                GBBABCAJHBL = 401707
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 401708,
                                Counter = false,
                                GBBABCAJHBL = 401708
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 50077,
                                Counter = true,
                                GBBABCAJHBL = 50077
                            },
                        },
                        Counter = new Counter { Id = 3, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 0, Max = 9, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 58, 1017 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 49,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 1040,
                                Counter = true,
                                GBBABCAJHBL = 1040
                            },
                        },
                        Counter = new Counter { Id = 49, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 5, 11023 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 17,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 1202,
                                Counter = true,
                                GBBABCAJHBL = 1202
                            },
                        },
                        Counter = new Counter { Id = 17, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 200, 10184, 1 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 47,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 1210,
                                Counter = true,
                                GBBABCAJHBL = 1210
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 99001,
                                Counter = true,
                                GBBABCAJHBL = 99001
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 1204,
                                Counter = true,
                                GBBABCAJHBL = 1204
                            },
                        },
                        Counter = new Counter { Id = 47, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 200, 10110, 1 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 2,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 71000,
                                Counter = true,
                                GBBABCAJHBL = 71000
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)49, UniqueId = 100821,
                                Counter = true,
                                GBBABCAJHBL = 100821
                            },
                        },
                        Counter = new Counter { Id = 2, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 5, 1008 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 19,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010040,
                                Counter = true,
                                GBBABCAJHBL = 4010040
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010042,
                                Counter = true,
                                GBBABCAJHBL = 4010042
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010059,
                                Counter = true,
                                GBBABCAJHBL = 4010059
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010062,
                                Counter = true,
                                GBBABCAJHBL = 4010062
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010018,
                                Counter = true,
                                GBBABCAJHBL = 4010018
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010025,
                                Counter = true,
                                GBBABCAJHBL = 4010025
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010028,
                                Counter = true,
                                GBBABCAJHBL = 4010028
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010036,
                                Counter = true,
                                GBBABCAJHBL = 4010036
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010005,
                                Counter = true,
                                GBBABCAJHBL = 4010005
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010056,
                                Counter = true,
                                GBBABCAJHBL = 4010056
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010058,
                                Counter = true,
                                GBBABCAJHBL = 4010058
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010063,
                                Counter = true,
                                GBBABCAJHBL = 4010063
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010041,
                                Counter = true,
                                GBBABCAJHBL = 4010041
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010048,
                                Counter = true,
                                GBBABCAJHBL = 4010048
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010052,
                                Counter = true,
                                GBBABCAJHBL = 4010052
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010001,
                                Counter = true,
                                GBBABCAJHBL = 4010001
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010037,
                                Counter = true,
                                GBBABCAJHBL = 4010037
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010016,
                                Counter = true,
                                GBBABCAJHBL = 4010016
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010019,
                                Counter = true,
                                GBBABCAJHBL = 4010019
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010023,
                                Counter = true,
                                GBBABCAJHBL = 4010023
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010034,
                                Counter = true,
                                GBBABCAJHBL = 4010034
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010043,
                                Counter = true,
                                GBBABCAJHBL = 4010043
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010047,
                                Counter = true,
                                GBBABCAJHBL = 4010047
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010061,
                                Counter = true,
                                GBBABCAJHBL = 4010061
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 48037,
                                Counter = true,
                                GBBABCAJHBL = 48037
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010006,
                                Counter = true,
                                GBBABCAJHBL = 4010006
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010007,
                                Counter = true,
                                GBBABCAJHBL = 4010007
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010017,
                                Counter = true,
                                GBBABCAJHBL = 4010017
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010021,
                                Counter = true,
                                GBBABCAJHBL = 4010021
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010057,
                                Counter = true,
                                GBBABCAJHBL = 4010057
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010008,
                                Counter = true,
                                GBBABCAJHBL = 4010008
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010032,
                                Counter = true,
                                GBBABCAJHBL = 4010032
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010053,
                                Counter = true,
                                GBBABCAJHBL = 4010053
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010003,
                                Counter = true,
                                GBBABCAJHBL = 4010003
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010027,
                                Counter = true,
                                GBBABCAJHBL = 4010027
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010044,
                                Counter = true,
                                GBBABCAJHBL = 4010044
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010013,
                                Counter = true,
                                GBBABCAJHBL = 4010013
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010030,
                                Counter = true,
                                GBBABCAJHBL = 4010030
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010035,
                                Counter = true,
                                GBBABCAJHBL = 4010035
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010038,
                                Counter = true,
                                GBBABCAJHBL = 4010038
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010039,
                                Counter = true,
                                GBBABCAJHBL = 4010039
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010004,
                                Counter = true,
                                GBBABCAJHBL = 4010004
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010011,
                                Counter = true,
                                GBBABCAJHBL = 4010011
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010015,
                                Counter = true,
                                GBBABCAJHBL = 4010015
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010020,
                                Counter = true,
                                GBBABCAJHBL = 4010020
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010045,
                                Counter = true,
                                GBBABCAJHBL = 4010045
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010050,
                                Counter = true,
                                GBBABCAJHBL = 4010050
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010054,
                                Counter = true,
                                GBBABCAJHBL = 4010054
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010002,
                                Counter = true,
                                GBBABCAJHBL = 4010002
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010010,
                                Counter = true,
                                GBBABCAJHBL = 4010010
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010060,
                                Counter = true,
                                GBBABCAJHBL = 4010060
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010022,
                                Counter = true,
                                GBBABCAJHBL = 4010022
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010026,
                                Counter = true,
                                GBBABCAJHBL = 4010026
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010033,
                                Counter = true,
                                GBBABCAJHBL = 4010033
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010055,
                                Counter = true,
                                GBBABCAJHBL = 4010055
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010049,
                                Counter = true,
                                GBBABCAJHBL = 4010049
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010009,
                                Counter = true,
                                GBBABCAJHBL = 4010009
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010029,
                                Counter = true,
                                GBBABCAJHBL = 4010029
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010031,
                                Counter = true,
                                GBBABCAJHBL = 4010031
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010046,
                                Counter = true,
                                GBBABCAJHBL = 4010046
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010012,
                                Counter = true,
                                GBBABCAJHBL = 4010012
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010014,
                                Counter = true,
                                GBBABCAJHBL = 4010014
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010024,
                                Counter = true,
                                GBBABCAJHBL = 4010024
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 4010051,
                                Counter = true,
                                GBBABCAJHBL = 4010051
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)30, UniqueId = 22022,
                                Counter = false,
                                GBBABCAJHBL = 22022
                            },
                        },
                        Counter = new Counter { Id = 19, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 292, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 400 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 51,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 1030,
                                Counter = true,
                                GBBABCAJHBL = 1030
                            },
                        },
                        Counter = new Counter { Id = 51, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 227, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 409, 1 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 1435,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)9, UniqueId = 34013,
                                Counter = true,
                                GBBABCAJHBL = 34013
                            },
                        },
                        Counter = new Counter { Id = 1435, ResetPeriod = (Enum_CounterResetNone_CounterResetDaily_CounterResetWeekly_CounterResetMax)2,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 400,
                            IMMIPLFMKIF = true,
                            BBFIKDDGMFN = { 400 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 37,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)2, UniqueId = 7,
                                Counter = true,
                                GBBABCAJHBL = 7
                            },
                        },
                        Counter = new Counter { Id = 37, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 200, 10141, 1 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 14,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 46021,
                                Counter = true,
                                GBBABCAJHBL = 46021
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 46023,
                                Counter = true,
                                GBBABCAJHBL = 46023
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 1201,
                                Counter = true,
                                GBBABCAJHBL = 1201
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 44001,
                                Counter = true,
                                GBBABCAJHBL = 44001
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 44003,
                                Counter = true,
                                GBBABCAJHBL = 44003
                            },
                        },
                        Counter = new Counter { Id = 14, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 200, 10103, 1 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 1434,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)3, UniqueId = 1,
                                Counter = true,
                                GBBABCAJHBL = 1
                            },
                        },
                        Counter = new Counter { Id = 1434, ResetPeriod = (Enum_CounterResetNone_CounterResetDaily_CounterResetWeekly_CounterResetMax)1,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 400,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 400 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 63,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)2, UniqueId = 6,
                                Counter = true,
                                GBBABCAJHBL = 6
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 2020006,
                                Counter = true,
                                GBBABCAJHBL = 2020006
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 2020003,
                                Counter = true,
                                GBBABCAJHBL = 2020003
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 2020001,
                                Counter = true,
                                GBBABCAJHBL = 2020001
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 2020002,
                                Counter = true,
                                GBBABCAJHBL = 2020002
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 2020004,
                                Counter = true,
                                GBBABCAJHBL = 2020004
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 2020005,
                                Counter = true,
                                GBBABCAJHBL = 2020005
                            },
                        },
                        Counter = new Counter { Id = 63, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 2835, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 201, 21, 1 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 46,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 48019,
                                Counter = true,
                                GBBABCAJHBL = 48019
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 2000001,
                                Counter = true,
                                GBBABCAJHBL = 2000001
                            },
                        },
                        Counter = new Counter { Id = 46, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 200, 10110, 1, 1 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 16,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 1021,
                                Counter = true,
                                GBBABCAJHBL = 1021
                            },
                        },
                        Counter = new Counter { Id = 16, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 191, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 5, 12 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 48,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040016,
                                Counter = true,
                                GBBABCAJHBL = 5040016
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040024,
                                Counter = true,
                                GBBABCAJHBL = 5040024
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040026,
                                Counter = true,
                                GBBABCAJHBL = 5040026
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040001,
                                Counter = true,
                                GBBABCAJHBL = 5040001
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040002,
                                Counter = true,
                                GBBABCAJHBL = 5040002
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040010,
                                Counter = true,
                                GBBABCAJHBL = 5040010
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040014,
                                Counter = true,
                                GBBABCAJHBL = 5040014
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040015,
                                Counter = true,
                                GBBABCAJHBL = 5040015
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040017,
                                Counter = true,
                                GBBABCAJHBL = 5040017
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040027,
                                Counter = true,
                                GBBABCAJHBL = 5040027
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040028,
                                Counter = true,
                                GBBABCAJHBL = 5040028
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040007,
                                Counter = true,
                                GBBABCAJHBL = 5040007
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040009,
                                Counter = true,
                                GBBABCAJHBL = 5040009
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040019,
                                Counter = true,
                                GBBABCAJHBL = 5040019
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040021,
                                Counter = true,
                                GBBABCAJHBL = 5040021
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040003,
                                Counter = true,
                                GBBABCAJHBL = 5040003
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040005,
                                Counter = true,
                                GBBABCAJHBL = 5040005
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040020,
                                Counter = true,
                                GBBABCAJHBL = 5040020
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040023,
                                Counter = true,
                                GBBABCAJHBL = 5040023
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040004,
                                Counter = true,
                                GBBABCAJHBL = 5040004
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040011,
                                Counter = true,
                                GBBABCAJHBL = 5040011
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040018,
                                Counter = true,
                                GBBABCAJHBL = 5040018
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040025,
                                Counter = true,
                                GBBABCAJHBL = 5040025
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040030,
                                Counter = true,
                                GBBABCAJHBL = 5040030
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040008,
                                Counter = true,
                                GBBABCAJHBL = 5040008
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040012,
                                Counter = true,
                                GBBABCAJHBL = 5040012
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040006,
                                Counter = true,
                                GBBABCAJHBL = 5040006
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040013,
                                Counter = true,
                                GBBABCAJHBL = 5040013
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040022,
                                Counter = true,
                                GBBABCAJHBL = 5040022
                            },
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 5040029,
                                Counter = true,
                                GBBABCAJHBL = 5040029
                            },
                        },
                        Counter = new Counter { Id = 48, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 105, 4 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 1436,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)59, UniqueId = 12005,
                                Counter = true,
                                GBBABCAJHBL = 12005
                            },
                        },
                        Counter = new Counter { Id = 1436, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 400,
                            IMMIPLFMKIF = true,
                            BBFIKDDGMFN = { 400 }
                        }
                    },
                    new PlayerCounter
                    {
                        Id = 7,
                        Watchers =
                        {
                            new Watcher
                            {
                                SystemId = (PlayerCounterSystem)1, UniqueId = 99998,
                                Counter = true,
                                GBBABCAJHBL = 99998
                            },
                        },
                        Counter = new Counter { Id = 7, ResetPeriod = 0,
                            Num = new Num { Continuous = 0, Summary = 1, Max = 0, ValueCase = 0 },
                            DNGBLDDNGIN = 0,
                            IMMIPLFMKIF = false,
                            BBFIKDDGMFN = { 200, 10101, 1 }
                        }
                    },
                }
            };

            //scPlayerCounterSync = PcapUtils.GetPacketFromPcap<SC_PlayerCounterSync>(MsgId.MsgScPlayerCounterSync, PacketType.RESPONSE);

            connection.SendAutoEncrypted(scPlayerCounterSync);

            SC_PlayerStatusCounterSync playerStatusCounterSync = new SC_PlayerStatusCounterSync
            {
                Num = 4,
                Watchers =
                {
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 1571 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 48026 },
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 1341 },
                    new PELLFAAPKOL { SystemId = 30, UniqueId = 22009 },
                }
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync2 = new SC_PlayerStatusCounterSync
            {
                Num = 2,
                Watchers =
                {
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 1561 },
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 1261 },
                }
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync3 = new SC_PlayerStatusCounterSync
            {
                Num = 8,
                Watchers =
                {
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 1581 },
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 40011 },
                }
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync4 = new SC_PlayerStatusCounterSync
            {
                Num = 60,
                Watchers =
                {
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4000010 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 11012 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 73012 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4000004 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 1011 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 73008 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 29202 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 11008 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 99106 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 1010 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 33003 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 1033 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 48036 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 1043 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 29000 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4000019 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 1018 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 99102 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 28000 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 99101 },
                    new PELLFAAPKOL { SystemId = 37, UniqueId = 380020 },
                    new PELLFAAPKOL { SystemId = 45, UniqueId = 3 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4000014 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 99110 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4000005 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 33001 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 11003 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 99109 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 2011 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 14005 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 34001 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4000015 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 1012 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 11011 },
                    new PELLFAAPKOL { SystemId = 45, UniqueId = 2 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 99100 },
                    new PELLFAAPKOL { SystemId = 64, UniqueId = 19 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 99201 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 73009 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 99207 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 12008 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4000012 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 11007 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 33002 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 99108 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4000011 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 1020 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 41002 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4000001 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 1017 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 1013 },
                    new PELLFAAPKOL { SystemId = 71, UniqueId = 38003 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4000006 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 29004 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 11005 },
                    new PELLFAAPKOL { SystemId = 45, UniqueId = 1 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 2001 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 2010 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 10999 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 73001 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 73005 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 32001 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4000003 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 1045 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 73002 },
                    new PELLFAAPKOL { SystemId = 37, UniqueId = 280110 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4000017 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 1019 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4000016 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4000007 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 1044 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 73007 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 73010 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 29001 },
                    new PELLFAAPKOL { SystemId = 37, UniqueId = 390020 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 99204 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 99209 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 99103 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 99999 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 1042 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 2000 },
                    new PELLFAAPKOL { SystemId = 37, UniqueId = 110141 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 99105 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 99203 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 1015 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 11006 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 14000 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 73011 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 12007 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 73004 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 11004 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4000009 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 99205 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 21000 },
                    new PELLFAAPKOL { SystemId = 45, UniqueId = 5 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 99111 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 29301 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 16008 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 99104 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 29401 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 73003 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 99206 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4000020 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 11002 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4000018 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 73006 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 11009 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4000013 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 1041 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 1014 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4000002 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 99107 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 12009 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4000008 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 10998 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 1016 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 1039 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 10997 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 38001 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 99202 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 91005 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 99208 },
                    new PELLFAAPKOL { SystemId = 45, UniqueId = 4 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 99210 },
                }
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync5 = new SC_PlayerStatusCounterSync
            {
                Num = 3,
                Watchers =
                {
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 402405 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 402402 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 402410 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 402404 },
                    new PELLFAAPKOL { SystemId = 49, UniqueId = 102411 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 20002 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 402406 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 402401 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 402409 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 402403 },
                    new PELLFAAPKOL { SystemId = 64, UniqueId = 16 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 402408 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 402407 },
                }
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync6 = new SC_PlayerStatusCounterSync
            {
                Num = 30,
                Watchers =
                {
                    new PELLFAAPKOL { SystemId = 31, UniqueId = 1070 },
                    new PELLFAAPKOL { SystemId = 31, UniqueId = 1063 },
                    new PELLFAAPKOL { SystemId = 31, UniqueId = 1061 },
                    new PELLFAAPKOL { SystemId = 31, UniqueId = 1078 },
                    new PELLFAAPKOL { SystemId = 31, UniqueId = 1067 },
                    new PELLFAAPKOL { SystemId = 31, UniqueId = 1071 },
                    new PELLFAAPKOL { SystemId = 31, UniqueId = 1079 },
                    new PELLFAAPKOL { SystemId = 31, UniqueId = 1073 },
                    new PELLFAAPKOL { SystemId = 31, UniqueId = 1076 },
                    new PELLFAAPKOL { SystemId = 31, UniqueId = 1065 },
                    new PELLFAAPKOL { SystemId = 31, UniqueId = 1062 },
                    new PELLFAAPKOL { SystemId = 31, UniqueId = 1075 },
                    new PELLFAAPKOL { SystemId = 31, UniqueId = 1064 },
                    new PELLFAAPKOL { SystemId = 31, UniqueId = 1069 },
                    new PELLFAAPKOL { SystemId = 31, UniqueId = 1080 },
                    new PELLFAAPKOL { SystemId = 31, UniqueId = 1072 },
                    new PELLFAAPKOL { SystemId = 31, UniqueId = 1068 },
                    new PELLFAAPKOL { SystemId = 31, UniqueId = 1077 },
                    new PELLFAAPKOL { SystemId = 31, UniqueId = 1066 },
                    new PELLFAAPKOL { SystemId = 31, UniqueId = 1074 },
                }
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync7 = new SC_PlayerStatusCounterSync
            {
                Num = 9,
                Watchers =
                {
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 401707 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 401701 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 401703 },
                    new PELLFAAPKOL { SystemId = 64, UniqueId = 18 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 400110 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 400103 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 401710 },
                    new PELLFAAPKOL { SystemId = 49, UniqueId = 101711 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 400106 },
                    new PELLFAAPKOL { SystemId = 49, UniqueId = 100111 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 400105 },
                    new PELLFAAPKOL { SystemId = 49, UniqueId = 100811 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 400102 },
                    new PELLFAAPKOL { SystemId = 64, UniqueId = 20 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 401702 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 400108 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 400805 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 400801 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 400803 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 400101 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 400806 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 400107 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 400802 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 401705 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 400810 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 400804 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 401708 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 401706 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 401704 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 400807 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 401709 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 400104 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 400808 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 400109 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 400809 },
                    new PELLFAAPKOL { SystemId = 64, UniqueId = 15 },
                }
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync8 = new SC_PlayerStatusCounterSync
            {
                Num = 5,
                Watchers =
                {
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 1311 },
                }
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync9 = new SC_PlayerStatusCounterSync
            {
                Num = 6,
                Watchers =
                {
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 1361 },
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 40145 },
                }
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync10 = new SC_PlayerStatusCounterSync
            {
                Num = 724,
                Watchers =
                {
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 14002 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 14007 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 14001 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 14003 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 14006 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 14004 },
                }
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync11 = new SC_PlayerStatusCounterSync
            {
                Num = 10,
                Watchers =
                {
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 40140 },
                }
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync12 = new SC_PlayerStatusCounterSync
            {
                Num = 1,
                Watchers =
                {
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 16101 },
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 40059 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 26001 },
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 40063 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 10997 },
                    new PELLFAAPKOL { SystemId = 2, UniqueId = 2 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4030005 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 12002 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 23000 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000021 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000004 },
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 1271 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 11008 },
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 40062 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 29002 },
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 1722 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 29000 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 11007 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 12002 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 24000 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000012 },
                    new PELLFAAPKOL { SystemId = 30, UniqueId = 22010 },
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 1511 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000009 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4030008 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4030011 },
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 40060 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000010 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000015 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 29002 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4030007 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000001 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 20002 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 13000 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 16004 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 24002 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 10998 },
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 40061 },
                    new PELLFAAPKOL { SystemId = 71, UniqueId = 43008 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000013 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 33002 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000020 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 12003 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 12001 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 12003 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 29005 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000016 },
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 1491 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 29003 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000008 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 29101 },
                    new PELLFAAPKOL { SystemId = 2, UniqueId = 47 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 12001 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 99103 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 31000 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 11010 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 29202 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 31002 },
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 1530 },
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 40103 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 48027 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000017 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 29005 },
                    new PELLFAAPKOL { SystemId = 49, UniqueId = 100831 },
                    new PELLFAAPKOL { SystemId = 2, UniqueId = 1 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 11012 },
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 40236 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 12000 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000026 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 11101 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 11002 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 12000 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 29003 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 16004 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 11005 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 14000 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 1240 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 16000 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 16000 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 11004 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 16201 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 24001 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 39001 },
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 40064 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 31002 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 11009 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000002 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 29001 },
                    new PELLFAAPKOL { SystemId = 64, UniqueId = 1 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 16005 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 99100 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 20000 },
                    new PELLFAAPKOL { SystemId = 49, UniqueId = 101731 },
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 1241 },
                    new PELLFAAPKOL { SystemId = 64, UniqueId = 3 },
                    new PELLFAAPKOL { SystemId = 37, UniqueId = 440080 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000027 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4030009 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 31001 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 22000 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000028 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 28000 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 10999 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 12010 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 99108 },
                    new PELLFAAPKOL { SystemId = 65, UniqueId = 10205 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000022 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 15100 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 14005 },
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 40102 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 13000 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 16005 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 11101 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 30001 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 29301 },
                    new PELLFAAPKOL { SystemId = 64, UniqueId = 2 },
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 1351 },
                    new PELLFAAPKOL { SystemId = 71, UniqueId = 43001 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000003 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000006 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 30001 },
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 40104 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 15100 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4030001 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 12010 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4030012 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4030002 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000025 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000007 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 12007 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4030003 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000014 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 11006 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000005 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 20000 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 12005 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 32001 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000019 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 99111 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 33001 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 1023 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 31001 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4030006 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000023 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000011 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000024 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4030004 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 26002 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 31000 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 11010 },
                    new PELLFAAPKOL { SystemId = 49, UniqueId = 100131 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 21000 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 26002 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 25000 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 3000018 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 16008 },
                    new PELLFAAPKOL { SystemId = 23, UniqueId = 11003 },
                    new PELLFAAPKOL { SystemId = 1, UniqueId = 4030010 },
                    new PELLFAAPKOL { SystemId = 63, UniqueId = 40105 },
                }
            };

            connection.Send(11, playerStatusCounterSync, playerStatusCounterSync2, playerStatusCounterSync3, playerStatusCounterSync4, playerStatusCounterSync5, playerStatusCounterSync6, playerStatusCounterSync7, playerStatusCounterSync8, playerStatusCounterSync9, playerStatusCounterSync10, playerStatusCounterSync11, playerStatusCounterSync12);

            SC_CountSection countSection = new SC_CountSection
            {
                Counters =
                 {
                     new CommonQuestCounters
                     {
                         Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Guide,
                         Rewards =
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
                         PhaseRewards = { },
                         JGOJBNHMJJH = { },
                     }
                 }
            };
            connection.SendUnsequenced(8, countSection);

             SC_CountSection countSection2 = new SC_CountSection
            {
                Counters =
                 {
                     new CommonQuestCounters
                     {
                         Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.WeeklySimCombat,
                         Rewards = { },
                         PhaseRewards = { },
                         JGOJBNHMJJH = { },
                     },
                     new CommonQuestCounters
                     {
                         Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.PvpDailyPoints,
                         Rewards = { },
                         PhaseRewards = { },
                         JGOJBNHMJJH = { },
                     },
                     new CommonQuestCounters
                     {
                         Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.PvpGuide,
                         Rewards = { },
                         PhaseRewards = { },
                         JGOJBNHMJJH = { },
                     },
                     new CommonQuestCounters
                     {
                         Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.BattlepassDaily,
                         Rewards = { },
                         PhaseRewards = { },
                         JGOJBNHMJJH = { },
                     },
                     new CommonQuestCounters
                     {
                         Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.BattlepassShare,
                         Rewards = { },
                         PhaseRewards = { },
                         JGOJBNHMJJH = { },
                     },
                     new CommonQuestCounters
                     {
                         Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.BattlepassWeekly,
                         Rewards = { },
                         PhaseRewards = { },
                         JGOJBNHMJJH = { },
                     },
                     new CommonQuestCounters
                     {
                         Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.DarkZoneCycle,
                         Rewards = { },
                         PhaseRewards = { },
                         JGOJBNHMJJH = { },
                     },
                     new CommonQuestCounters
                     {
                         Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.DarkZonePermanent,
                         Rewards = { },
                         PhaseRewards = { },
                         JGOJBNHMJJH = { },
                     },
                     new CommonQuestCounters
                     {
                         Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.WeeklyChallenge,
                         Rewards = { },
                         PhaseRewards = { },
                         JGOJBNHMJJH = { },
                     },
                     new CommonQuestCounters
                     {
                         Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Achievement,
                         Rewards = { },
                         PhaseRewards = { },
                         JGOJBNHMJJH = { },
                     },
                     new CommonQuestCounters
                     {
                         Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Daily,
                         Rewards =
                         {
                             { 9u, true },
                             { 8u, true },
                             { 2u, true },
                             { 6u, false },
                             { 7u, true },
                             { 1u, true },
                         },
                         PhaseRewards = { },
                         JGOJBNHMJJH = { },
                     },
                     new CommonQuestCounters
                     {
                         Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Week,
                         Rewards =
                         {
                             { 1u, false },
                         },
                         PhaseRewards = { },
                         JGOJBNHMJJH = { },
                     },
                     new CommonQuestCounters
                     {
                         Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.BattlepassAccept,
                         Rewards = { },
                         PhaseRewards = { },
                         JGOJBNHMJJH = { },
                     },
                     new CommonQuestCounters
                     {
                         Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.ThemeWarmUp,
                         Rewards = { },
                         PhaseRewards = { },
                         JGOJBNHMJJH = { },
                     },
                     new CommonQuestCounters
                     {
                         Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Newbee,
                         Rewards = { },
                         PhaseRewards = { },
                         JGOJBNHMJJH = { },
                     },
                     new CommonQuestCounters
                     {
                         Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.MonopolyDaily,
                         Rewards =
                         {
                             { 13u, false },
                             { 19u, false },
                             { 25u, false },
                             { 6u, false },
                             { 1u, false },
                             { 7u, false },
                         },
                         PhaseRewards = { },
                         JGOJBNHMJJH = { },
                     },
                     new CommonQuestCounters
                     {
                         Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.MonopolyTask,
                         Rewards = { },
                         PhaseRewards = { },
                         JGOJBNHMJJH = { },
                     },
                     new CommonQuestCounters
                     {
                         Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Amo,
                         Rewards = { },
                         PhaseRewards = { },
                         JGOJBNHMJJH = { },
                     },
                     new CommonQuestCounters
                     {
                         Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.DarkZoneAchievement,
                         Rewards =
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
                         PhaseRewards =
                         {
                             { 26u, true },
                             { 20u, true },
                             { 22u, true },
                             { 27u, true },
                             { 28u, true },
                             { 29u, true },
                         },
                         JGOJBNHMJJH = { },
                     },
                     new CommonQuestCounters
                     {
                         Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.SimCafeGrade,
                         Rewards = { },
                         PhaseRewards = { },
                         JGOJBNHMJJH = { },
                     },
                 }
            };
            connection.SendUnsequenced(1, countSection2);

            SC_CountSection countSection3 = new SC_CountSection
            {
                Counters =
                  {
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Back,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Treasure,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.SimCafeWarmUp,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Bingo,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.ActivityBingo,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.ActivityCollection,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.GeopoliticalWarmUp,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.ControlFight,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.ActivityDispatch,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.GeopoliticalDaily,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.GeopoliticalFormal,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.ActivityMainTask,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.RubyShop,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.BeginnerLevel,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.StageFight,
                          Rewards =
                          {
                              { 5u, true },
                              { 1u, true },
                              { 2u, true },
                              { 3u, true },
                              { 4u, true },
                          },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.SandBox,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Rouge,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.GunExamine,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.TpsShoot,
                          Rewards =
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
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.ActivityFreeSkin,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                  }
            };
            connection.SendUnsequenced(countSection3);

            SC_CountSection countSection4 = new SC_CountSection
            {
                Counters =
                  {
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.RichMan,
                          Rewards =
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
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Dungeon,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Shootspace,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.BattlepassSeason,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.KittyCafe,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.BackBattlePass,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.ActivityItemTask,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Motorcycle,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.AchievementChallenge,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.LoadingPicture,
                          Rewards =
                          {
                              { 20353u, false },
                              { 1581u, false },
                              { 1201u, false },
                              { 20351u, false },
                              { 20352u, false },
                          },
                          PhaseRewards = { },
                          JGOJBNHMJJH =
                          {
                              { 1201u, 1761315960L },
                              { 1581u, 1773698995L },
                          },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.NewSystem,
                          Rewards =
                          {
                              { 1u, false },
                              { 2u, false },
                              { 3u, false },
                              { 19u, false },
                          },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.PastEventStage,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Lottery,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.EventReward,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.WorldBoss,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.LobbyMiniGame,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.KittyCafe2,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.EventTask,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.YunTuChess,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.BattlepassDailyTimeLimit,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                  }
            };
            connection.SendUnsequenced(1, countSection4);

            SC_CountSection countSection5 = new SC_CountSection
            {
                Counters =
                  {
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.BattlepassWeeklyTimeLimit,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.BattlepassSeasonTimeLimit,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.LobbyPartyNotes,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.LotteryV2,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.AchievementPs,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.ButtGame,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.OneTime,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.TransformGunUnlock,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.EventEndlessTower,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.LobbyPlant,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      new CommonQuestCounters
                      {
                          Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.ButtGameV2,
                          Rewards = { },
                          PhaseRewards = { },
                          JGOJBNHMJJH = { },
                      },
                      //new CommonQuestCounters
                      //{
                      //    Counters = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.MaylingStoreSpecialRefresh,
                      //    Field4 = { },
                      //    Field5 = { },
                      //    Field6 = { },
                      //},
                  }
            };
            connection.SendUnsequenced(countSection5);

            SC_CountSection countSection6 = new SC_CountSection
            {
                Counters =
                {
                        new CommonQuestCounters
                        {
                            Type = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Guide,
                            Rewards =
                            {
                           
                                //{ 44051, false },
                            
                            },
                            PhaseRewards = { },
                            JGOJBNHMJJH = { },
                        },
                    }
            };

            List<GunData> gunData = tableService.GetTable<GunData>();

            foreach (GunEntity gun in gunService.GetPlayerGuns(connection.Account.Uid))
            {
                uint dormId = gunData.Where(g => g.GunId == gun.GunId).FirstOrDefault().Field60[0];

                countSection6.Counters[0].Rewards.Add(dormId, false);
            }

            connection.SendUnsequenced(countSection6);
        }
    }
}
