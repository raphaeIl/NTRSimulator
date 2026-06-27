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
                ELPBKBNCKBP =
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
                MAPKAGCPLIM =
                {
                    [2000003] = new KMIAGEBIMIP
                    {
                        EventId = 2000003,
                        CGPNIPFNENP = nowUnix,
                        FJBJIJIFACH = 0,
                    },
                    [2000012] = new KMIAGEBIMIP
                    {
                        EventId = 2000012,
                        CGPNIPFNENP = nowUnix,
                        FJBJIJIFACH = 0,
                    },
                    [2000019] = new KMIAGEBIMIP
                    {
                        EventId = 2000019,
                        CGPNIPFNENP = nowUnix,
                        FJBJIJIFACH = 0,
                    },
                    [2000015] = new KMIAGEBIMIP
                    {
                        EventId = 2000015,
                        CGPNIPFNENP = nowUnix,
                        FJBJIJIFACH = 0,
                    },
                    [2000020] = new KMIAGEBIMIP
                    {
                        EventId = 2000020,
                        CGPNIPFNENP = nowUnix,
                        FJBJIJIFACH = 0,
                    },
                    [31410] = new KMIAGEBIMIP
                    {
                        EventId = 31410,
                        CGPNIPFNENP = nowUnix,
                        FJBJIJIFACH = 0,
                    },
                },
                INCNFOFGJFB = { },
                DAHKBJPOFCP = { 43016, 43015, 38003, 43008, 44001, 44002, 44003, 43001 },
                DBNONLHDHLM = { },
                HINGCIJFHAC = { 3, 1, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 },
            });
        }

        public override void HandleLobbyGetBuildInfo(CS_LobbyGetBuildInfo request, Connection connection)
        {
                    lobbyGetBuildInfoCount++;

                    connection.Send(
                        new SC_PlayerStatusCounterSync
                        {
                            Num = 28,
                            Watchers =
                            {
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 40140 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 40141 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 40142 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Num = 31,
                            Watchers =
                            {
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1562 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1563 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1564 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1565 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1566 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1561 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Num = 28,
                            Watchers =
                            {
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 40142 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 40140 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 40141 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Num = 31,
                            Watchers =
                            {
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1564 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1565 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1566 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1561 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1562 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1563 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Num = 28,
                            Watchers =
                            {
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 40140 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 40141 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 40142 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Num = 31,
                            Watchers =
                            {
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1561 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1562 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1563 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1564 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1565 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1566 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Num = 28,
                            Watchers =
                            {
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 40140 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 40141 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 40142 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Num = 31,
                            Watchers =
                            {
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1561 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1562 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1563 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1564 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1565 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1566 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Num = 28,
                            Watchers =
                            {
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 40140 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 40141 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 40142 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Num = 31,
                            Watchers =
                            {
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1561 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1562 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1563 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1564 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1565 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1566 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Num = 28,
                            Watchers =
                            {
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 40140 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 40141 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 40142 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Num = 31,
                            Watchers =
                            {
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1562 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1563 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1564 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1565 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1566 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1561 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Num = 28,
                            Watchers =
                            {
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 40140 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 40141 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 40142 },
                            },
                        },
                        new SC_PlayerStatusCounterSync
                        {
                            Num = 31,
                            Watchers =
                            {
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1562 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1563 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1564 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1565 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1566 },
                                new PELLFAAPKOL { SystemId = 63, UniqueId = 1561 },
                            },
                        },
                        new SC_LobbyGetBuildInfo
                        {
                            CPJOGIOCNMM =
                            {
                                [101] = new OICGGHHHFBI { KICFGBGNDGF = { 10131, 10101, 10122, 10123, 10115, 10130, 10108, 10125, 10128, 10132, 10124, 10136, 10116, 10153, 10133 } },
                                [102] = new OICGGHHHFBI { KICFGBGNDGF = { 10204, 10205, 10212, 10226, 10231, 10211, 10201, 10206, 10218 } },
                                [103] = new OICGGHHHFBI { KICFGBGNDGF = { 10304, 10302, 10301 } },
                                [104] = new OICGGHHHFBI { KICFGBGNDGF = { 10401, 10402 } },
                                [106] = new OICGGHHHFBI { KICFGBGNDGF = { 10601, 10602, 10603, 10607 } },
                                [107] = new OICGGHHHFBI { KICFGBGNDGF = { 10716, 10701, 10702, 10704, 10703 } },
                                [201] = new OICGGHHHFBI { KICFGBGNDGF = { } },
                                [202] = new OICGGHHHFBI { KICFGBGNDGF = { 20202, 20203 } },
                            },
                            Level = 49,
                            CFOCLIHKKJL = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49 },
                        });

                    if (lobbyGetBuildInfoCount != 2)
                    {
                        return;
                    }

                    connection.SendUnsequenced(
                        new SC_RecordStatisticUpdate
                        {
                            CHEOLEADCCB = 1,
                            MDAIIFCGJMO = 11,
                            BCGNJMDFLDG = 0,
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
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 410261,
                                            Focused = true,
                                            GBBABCAJHBL = 410261,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 410262,
                                            Focused = true,
                                            GBBABCAJHBL = 410262,
                                        },
                                    },
                                    Counter = new PlayerCounter.Types.Counter { Id = 1437, SummaryCounter = 0,
                                        DNGBLDDNGIN = 58,
                                        IMMIPLFMKIF = false,
                                        BBFIKDDGMFN = { 58, 1026 },
                                        EndTime = 0,
                                        FKPIGDOCHOB = 0,
                                        GBBFJEBJPEC = { },
                                        
                                        
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
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 410261,
                                            Focused = true,
                                            GBBABCAJHBL = 410261,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 410262,
                                            Focused = true,
                                            GBBABCAJHBL = 410262,
                                        },
                                    },
                                    Counter = new PlayerCounter.Types.Counter { Id = 1437, SummaryCounter = 0,
                                        DNGBLDDNGIN = 58,
                                        IMMIPLFMKIF = false,
                                        BBFIKDDGMFN = { 58, 1026 },
                                        EndTime = 0,
                                        FKPIGDOCHOB = 0,
                                        GBBFJEBJPEC = { },
                                        
                                        
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
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 40001,
                                            Focused = true,
                                            GBBABCAJHBL = 40001,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 44012,
                                            Focused = true,
                                            GBBABCAJHBL = 44012,
                                        },
                                    },
                                    Counter = new PlayerCounter.Types.Counter { Id = 1439, SummaryCounter = 0,
                                        DNGBLDDNGIN = 5,
                                        IMMIPLFMKIF = false,
                                        BBFIKDDGMFN = { 5, 1026 },
                                        EndTime = 0,
                                        FKPIGDOCHOB = 0,
                                        GBBFJEBJPEC = { },
                                        
                                        
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
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 40001,
                                            Focused = true,
                                            GBBABCAJHBL = 40001,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 44012,
                                            Focused = true,
                                            GBBABCAJHBL = 44012,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 44015,
                                            Focused = true,
                                            GBBABCAJHBL = 44015,
                                        },
                                    },
                                    Counter = new PlayerCounter.Types.Counter { Id = 1439, SummaryCounter = 0,
                                        DNGBLDDNGIN = 5,
                                        IMMIPLFMKIF = false,
                                        BBFIKDDGMFN = { 5, 1026 },
                                        EndTime = 0,
                                        FKPIGDOCHOB = 0,
                                        GBBFJEBJPEC = { },
                                        
                                        
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
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 40001,
                                            Focused = true,
                                            GBBABCAJHBL = 40001,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 44012,
                                            Focused = true,
                                            GBBABCAJHBL = 44012,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 44015,
                                            Focused = true,
                                            GBBABCAJHBL = 44015,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 46032,
                                            Focused = true,
                                            GBBABCAJHBL = 46032,
                                        },
                                    },
                                    Counter = new PlayerCounter.Types.Counter { Id = 1439, SummaryCounter = 0,
                                        DNGBLDDNGIN = 5,
                                        IMMIPLFMKIF = false,
                                        BBFIKDDGMFN = { 5, 1026 },
                                        EndTime = 0,
                                        FKPIGDOCHOB = 0,
                                        GBBFJEBJPEC = { },
                                        
                                        
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
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 40001,
                                            Focused = true,
                                            GBBABCAJHBL = 40001,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 44012,
                                            Focused = true,
                                            GBBABCAJHBL = 44012,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 44015,
                                            Focused = true,
                                            GBBABCAJHBL = 44015,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 46032,
                                            Focused = true,
                                            GBBABCAJHBL = 46032,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 71007,
                                            Focused = true,
                                            GBBABCAJHBL = 71007,
                                        },
                                    },
                                    Counter = new PlayerCounter.Types.Counter { Id = 1439, SummaryCounter = 0,
                                        DNGBLDDNGIN = 5,
                                        IMMIPLFMKIF = false,
                                        BBFIKDDGMFN = { 5, 1026 },
                                        EndTime = 0,
                                        FKPIGDOCHOB = 0,
                                        GBBFJEBJPEC = { },
                                        
                                        
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
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 40001,
                                            Focused = true,
                                            GBBABCAJHBL = 40001,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 44012,
                                            Focused = true,
                                            GBBABCAJHBL = 44012,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 44015,
                                            Focused = true,
                                            GBBABCAJHBL = 44015,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 46032,
                                            Focused = true,
                                            GBBABCAJHBL = 46032,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 71007,
                                            Focused = true,
                                            GBBABCAJHBL = 71007,
                                        },
                                    },
                                    Counter = new PlayerCounter.Types.Counter { Id = 1439, SummaryCounter = 0,
                                        DNGBLDDNGIN = 5,
                                        IMMIPLFMKIF = false,
                                        BBFIKDDGMFN = { 5, 1026 },
                                        EndTime = 0,
                                        FKPIGDOCHOB = 0,
                                        GBBFJEBJPEC = { },
                                        
                                        
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
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 40001,
                                            Focused = true,
                                            GBBABCAJHBL = 40001,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 44012,
                                            Focused = true,
                                            GBBABCAJHBL = 44012,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 44015,
                                            Focused = true,
                                            GBBABCAJHBL = 44015,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 46032,
                                            Focused = true,
                                            GBBABCAJHBL = 46032,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 71007,
                                            Focused = true,
                                            GBBABCAJHBL = 71007,
                                        },
                                    },
                                    Counter = new PlayerCounter.Types.Counter { Id = 1439, SummaryCounter = 0,
                                        DNGBLDDNGIN = 5,
                                        IMMIPLFMKIF = false,
                                        BBFIKDDGMFN = { 5, 1026 },
                                        EndTime = 0,
                                        FKPIGDOCHOB = 0,
                                        GBBFJEBJPEC = { },
                                        
                                        
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
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 40001,
                                            Focused = true,
                                            GBBABCAJHBL = 40001,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 44012,
                                            Focused = true,
                                            GBBABCAJHBL = 44012,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 44015,
                                            Focused = true,
                                            GBBABCAJHBL = 44015,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 46032,
                                            Focused = true,
                                            GBBABCAJHBL = 46032,
                                        },
                                        new PlayerCounter.Types.Watcher
                                        {
                                            SystemId = (PlayerCounterSystem)1, UniqueId = 71007,
                                            Focused = true,
                                            GBBABCAJHBL = 71007,
                                        },
                                    },
                                    Counter = new PlayerCounter.Types.Counter { Id = 1439, SummaryCounter = 0,
                                        DNGBLDDNGIN = 5,
                                        IMMIPLFMKIF = false,
                                        BBFIKDDGMFN = { 5, 1026 },
                                        EndTime = 0,
                                        FKPIGDOCHOB = 0,
                                        GBBFJEBJPEC = { },
                                        
                                        
                                    },
                                },
                            },
                        },
                        new SC_DropCollect
                        {
                            Drops =
                            {
                                new UserDropCache
                                {
                                    ItemId = 16,
                                    ItemNum = 18,
                                    Relate = 0,
                                    OverflowNum = 0,
                                    ExtItems = { },
                                    TranItems = { },
                                    DropUp = false,
                                    CIPFHAHNMBM = (FMMNODBGEJC)62,
                                    WeaponModDisplay = null,
                                    
                                },
                                new UserDropCache
                                {
                                    ItemId = 47,
                                    ItemNum = 12,
                                    Relate = 0,
                                    OverflowNum = 0,
                                    ExtItems = { },
                                    TranItems = { },
                                    DropUp = false,
                                    CIPFHAHNMBM = (FMMNODBGEJC)62,
                                    WeaponModDisplay = null,
                                    
                                },
                                new UserDropCache
                                {
                                    ItemId = 23023,
                                    ItemNum = 1,
                                    Relate = 0,
                                    OverflowNum = 0,
                                    ExtItems = { },
                                    TranItems = { },
                                    DropUp = false,
                                    CIPFHAHNMBM = (FMMNODBGEJC)328,
                                    WeaponModDisplay = null,
                                    
                                },
                                new UserDropCache
                                {
                                    ItemId = 21011,
                                    ItemNum = 1,
                                    Relate = 0,
                                    OverflowNum = 0,
                                    ExtItems = { },
                                    TranItems = { },
                                    DropUp = false,
                                    CIPFHAHNMBM = (FMMNODBGEJC)328,
                                    WeaponModDisplay = null,
                                    
                                },
                            },
                        });
        }

        public override void HandleLobbyGetSchemeV2(CS_LobbyGetSchemeV2 request, Connection connection)
        {
            connection.Send(new SC_LobbyGetSchemeV2
            {
                CNLAIIIHBIK = new AFHDBEJPOHJ
                {
                    PKDLBOBNCBJ =
                    {
                        [101] = new AGGNMOGPNDI
                        {
                            Guns = { },
                            PPKDIKDPBIG = { },
                            ThemeId = 0,
                            HOCKKBJALMM = { },
                            JOCPKDIKBPF =
                            {
                                [1] = new OBLDJNGKIFA
                                {
                                    KHJPJMJHHCK = 0,
                                    AABKAFBKBCF = { 660736 },
                                    DLNCGLAONAH = { },
                                },
                                [2] = new OBLDJNGKIFA
                                {
                                    KHJPJMJHHCK = 1,
                                    AABKAFBKBCF = { 809472, 1073152, 1452288, 929536 },
                                    DLNCGLAONAH = { },
                                },
                                [3] = new OBLDJNGKIFA
                                {
                                    KHJPJMJHHCK = 0,
                                    AABKAFBKBCF = { 2622906368, 2622658560, 2623308800 },
                                    DLNCGLAONAH = { },
                                },
                            },
                        },
                        [102] = new AGGNMOGPNDI
                        {
                            Guns = { },
                            PPKDIKDPBIG =
                            {
                                [10202] = 202802,
                                [10204] = 113204,
                                [10201] = 202801,
                            },
                            ThemeId = 0,
                            HOCKKBJALMM = { },
                            JOCPKDIKBPF = { },
                        },
                    },
                    Name = "",
                },
                MPDOHKILMCA =
                {
                    new AFHDBEJPOHJ { PKDLBOBNCBJ = { }, Name = "" },
                    new AFHDBEJPOHJ { PKDLBOBNCBJ = { }, Name = "" },
                    new AFHDBEJPOHJ { PKDLBOBNCBJ = { }, Name = "" },
                    new AFHDBEJPOHJ { PKDLBOBNCBJ = { }, Name = "" },
                },
            });
        }

                public override void HandleLobbyGetCafeInfo(CS_LobbyGetCafeInfo request, Connection connection)
        {
                    connection.Send(new SC_LobbyGetCafeInfo
                    {
                        FMICMDLIOJD = 0,
                        CMADKJPJPHF = 5,
                        FFNCCJADIDB =
                        {
                            [1u] = 1,
                            [2u] = 1,
                            [3u] = 1,
                            [4u] = 1,
                            [5u] = 1,
                            [6u] = 1,
                            [67u] = 1,
                        },
                        IAOJDFGPGKA =
                        {
                            [1001] = 24,
                            [1008] = 24,
                            [1035] = 24,
                            [1048] = 8,
                            [1062] = 8,
                            [1066] = 57,
                        },
                        PMNDAICHKKO = { },
                        POFLALGADAO = { },
                    });
        }

        public override void HandleLobbyCookingInfo(CS_LobbyCookingInfo request, Connection connection)
        {
                    connection.Send(new SC_LobbyCookingInfo
                    {
                        Info = new EOBBIJAPFPD
                        {
                            CLLCFMCMONP = 0,
                            DJCLEPBDFJD = { },
                            EGOAOKPKFKF = { },
                        },
                    });
        }

        public override void HandleLobbyBuffInfo(CS_LobbyBuffInfo request, Connection connection)
        {
                    connection.Send(1, new SC_LobbyBuffInfo
                    {
                        KFNCPJPPGEF = 0,
                        KGHAGBOFCMD =
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
                        AJLCMPKKNAA =
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
                        AEPCLIFECCC = 0,
                        MGIKONEONBF = 0,
                        LHGLNJNFIPM = false,
                    });
        }

        public override void HandleLobbyGetQuestInfo(CS_LobbyGetQuestInfo request, Connection connection)
        {
                    connection.Send(new SC_LobbyGetQuestInfo
                    {
                        PAKHJDKPENP = 0,
                        LNJNKGNGBAC = 0,
                        GKPAAEMKODB = { },
                    });
        }

        public override void HandleLobbyInteract(CS_LobbyInteract request, Connection connection)
        {
            connection.Send(new SC_LobbyInteract
            {
                EKMDGLKBILM = request.EKMDGLKBILM,
                NGCBPMPCMMJ = true,
                ECGAHCPCDDI = request.ECGAHCPCDDI,
            });
        }

        public override void HandleLobbyTutorialInfo(CS_LobbyTutorialInfo request, Connection connection)
        {
                    connection.Send(1, new SC_LobbyTutorialInfo
                    {
                        Sends =
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
                        DIPIDKNFNPH =
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
                Groups = { request.Groups },
            });
        }

        public override void HandleLobbyTutorialSend(CS_LobbyTutorialSend request, Connection connection)
        {
            connection.Send(new SC_LobbyTutorialSend
            {
                KMHOOBIHPPE = { { request.PageId, 1u } },
                PageId = request.PageId,
            });
        }

        public override void HandleGetLobbyShareCodeIdx(CS_GetLobbyShareCodeIdx request, Connection connection)
        {
                    connection.Send(new SC_GetLobbyShareCodeIdx
                    {
                        BDMOEFJJFAM = { },
                    });
        }

        public override void HandleGetLobbyBgm(CS_GetLobbyBgm request, Connection connection)
        {
            connection.Send(new SC_GetLobbyBgm { JNHHAINDALC = 0 });
        }

        public override void HandleGetLobbyPhotoCut(CS_GetLobbyPhotoCut request, Connection connection)
        {
            connection.Send(new SC_GetLobbyPhotoCut
            {
                OAGEAGJKLHB = { },
                CCNDHNDHKBO = { 1, 2, 3, 4, 5, 6, 7, 53, 9, 10, 11, 12, 13, 14, 16, 17, 18, 19, 21, 22, 23, 24, 25, 26, 27, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 48, 49, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 69, 70, 71, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91 },
                BOKKHALJCMA = 1,
                INNLIAFIMIM = { },
            });
        }

                public override void HandleLobbyWelcomeSettingInfo(CS_LobbyWelcomeSettingInfo request, Connection connection)
        {
            uint nowUnix = (uint)DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            connection.Send(new SC_LobbyWelcomeSettingInfo
            {
                OBOGLCLAIPH = new NMEMMFMPCJB
                {
                    OIKBNGNPNIM = true,
                    DHFNGECCLAK = nowUnix,
                    JCOMGOPOLOP = 1017,
                    HPNKLKLOECK = true,
                },
            });
        }

        public override void HandleLobbyHandmadeGiftInfo(CS_LobbyHandmadeGiftInfo request, Connection connection)
        {
            connection.Send(new SC_LobbyHandmadeGiftInfo
            {
                KKLPCCBIFOM = { },
            });
        }

        public override void HandleGetLobbyHandmadeGiftMay(CS_GetLobbyHandmadeGiftMay request, Connection connection)
        {
            connection.Send(new SC_GetLobbyHandmadeGiftMay
            {
                MNGLCEKHNHE = { },
            });
        }

                        public override void HandleLobbyGetGunSetting(CS_LobbyGetGunSetting request, Connection connection)
        {
            uint nowUnix = (uint)DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            connection.Send(1,
                new SC_LobbyGetGunSetting
                {
                    Guns =
                    {
                        new JBHAOOEHJOO { GunId = 1001, HHBMPKBDBAH = 1100100, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1008, HHBMPKBDBAH = 1100800, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1009, HHBMPKBDBAH = 1100900, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1013, HHBMPKBDBAH = 1101300, FCDLFDGDFOO = 0, PFPHNDEDJHN = nowUnix, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1015, HHBMPKBDBAH = 1101500, FCDLFDGDFOO = 0, PFPHNDEDJHN = nowUnix, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1017, HHBMPKBDBAH = 1101700, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1021, HHBMPKBDBAH = 1102100, FCDLFDGDFOO = 0, PFPHNDEDJHN = nowUnix, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1022, HHBMPKBDBAH = 1102200, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1023, HHBMPKBDBAH = 1102300, FCDLFDGDFOO = 0, PFPHNDEDJHN = nowUnix, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1024, HHBMPKBDBAH = 1102400, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1025, HHBMPKBDBAH = 1102501, FCDLFDGDFOO = 0, PFPHNDEDJHN = nowUnix, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1026, HHBMPKBDBAH = 1102601, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1027, HHBMPKBDBAH = 1102700, FCDLFDGDFOO = 0, PFPHNDEDJHN = nowUnix, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1028, HHBMPKBDBAH = 1102800, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1029, HHBMPKBDBAH = 1102900, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1032, HHBMPKBDBAH = 1103200, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1033, HHBMPKBDBAH = 1103300, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1034, HHBMPKBDBAH = 1103401, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1035, HHBMPKBDBAH = 1103500, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1036, HHBMPKBDBAH = 1103600, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1037, HHBMPKBDBAH = 1103700, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1038, HHBMPKBDBAH = 1103800, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1039, HHBMPKBDBAH = 1103901, FCDLFDGDFOO = 273, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1040, HHBMPKBDBAH = 1104000, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1041, HHBMPKBDBAH = 1104100, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1042, HHBMPKBDBAH = 1104200, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1043, HHBMPKBDBAH = 1104300, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1044, HHBMPKBDBAH = 1104400, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1045, HHBMPKBDBAH = 1104500, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1047, HHBMPKBDBAH = 1104701, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1048, HHBMPKBDBAH = 1104800, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1049, HHBMPKBDBAH = 1104900, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1050, HHBMPKBDBAH = 1105000, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1051, HHBMPKBDBAH = 1105100, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1052, HHBMPKBDBAH = 1105203, FCDLFDGDFOO = 273, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1053, HHBMPKBDBAH = 1105300, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1054, HHBMPKBDBAH = 1105401, FCDLFDGDFOO = 273, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1055, HHBMPKBDBAH = 1105500, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1056, HHBMPKBDBAH = 1105600, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1057, HHBMPKBDBAH = 1105700, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1058, HHBMPKBDBAH = 1105800, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1059, HHBMPKBDBAH = 1105900, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1060, HHBMPKBDBAH = 1106000, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1061, HHBMPKBDBAH = 1106100, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1062, HHBMPKBDBAH = 1106200, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1063, HHBMPKBDBAH = 1106300, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1064, HHBMPKBDBAH = 1106400, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1065, HHBMPKBDBAH = 1106500, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1066, HHBMPKBDBAH = 1106600, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1067, HHBMPKBDBAH = 1106700, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1068, HHBMPKBDBAH = 1106800, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1069, HHBMPKBDBAH = 1106900, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1070, HHBMPKBDBAH = 1107000, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1071, HHBMPKBDBAH = 1107100, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1072, HHBMPKBDBAH = 1107200, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1073, HHBMPKBDBAH = 1107300, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1074, HHBMPKBDBAH = 1107400, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1075, HHBMPKBDBAH = 1107500, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1076, HHBMPKBDBAH = 1107600, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1077, HHBMPKBDBAH = 1107700, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
                        new JBHAOOEHJOO { GunId = 1078, HHBMPKBDBAH = 1107800, FCDLFDGDFOO = 0, PFPHNDEDJHN = 0, PFIECLBKOMF = 0 },
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
                JLPAEKALOKI = request.JLPAEKALOKI,
            };
            response.Id.AddRange(request.Id);
            connection.Send(response);
        }

        public override void HandleLobbyPlantInfo(CS_LobbyPlantInfo request, Connection connection)
        {
            connection.Send(new SC_LobbyPlantInfo
            {
                Info = new FOMLKMNAKEC
                {
                    JJGNOPPPPIB = 0,
                    NPJLLHJBFBP = 0,
                    NCINIEDEDFG = 0,
                    EFEELOPBBEH = 0,
                    GILBGLLFNEK = false,
                    HMPGFCICDPF = 0,
                    APCCCCBNAJC = false,
                    RoomId = 0,
                    CCOCGNFFIGD = { },
                    PPFIKNCHBAO = 0,
                },
            });
        }

        // 3d dorm lobby missing handler impl starts here
        public override void HandleLobbyPartyInfo(CS_LobbyPartyInfo request, Connection connection)
        {
            connection.Send(7, new SC_LobbyPartyInfo
            {
                AGCMHJFOGIH =
                {
                    [101] = new KEAKDAMCBMM
                    {
                        Id = 101,
                        HFKNLIGCIBP =
                        {
                            [10101] = new BNNMKBFFNHJ
                            {
                                SectionId = 10101,
                                BAJHKMIBPDC = true,
                                LGNOAHMHJHH =
                                {
                                    [1010101] = new CIFKOJJBCHF { Id = 1010101, BAJHKMIBPDC = true },
                                    [1010102] = new CIFKOJJBCHF { Id = 1010102, BAJHKMIBPDC = true },
                                    [1010103] = new CIFKOJJBCHF { Id = 1010103, BAJHKMIBPDC = true },
                                    [1010104] = new CIFKOJJBCHF { Id = 1010104, BAJHKMIBPDC = true },
                                    [1010105] = new CIFKOJJBCHF { Id = 1010105, BAJHKMIBPDC = true },
                                    [1010106] = new CIFKOJJBCHF { Id = 1010106, BAJHKMIBPDC = true },
                                    [1010107] = new CIFKOJJBCHF { Id = 1010107, BAJHKMIBPDC = true },
                                    [1010108] = new CIFKOJJBCHF { Id = 1010108, BAJHKMIBPDC = true },
                                },
                                LDLCBHAEFHO = { },
                            },
                            [10102] = new BNNMKBFFNHJ
                            {
                                SectionId = 10102,
                                BAJHKMIBPDC = true,
                                LGNOAHMHJHH =
                                {
                                    [1010201] = new CIFKOJJBCHF { Id = 1010201, BAJHKMIBPDC = true },
                                    [1010202] = new CIFKOJJBCHF { Id = 1010202, BAJHKMIBPDC = true },
                                    [1010203] = new CIFKOJJBCHF { Id = 1010203, BAJHKMIBPDC = true },
                                    [1010204] = new CIFKOJJBCHF { Id = 1010204, BAJHKMIBPDC = true },
                                    [1010205] = new CIFKOJJBCHF { Id = 1010205, BAJHKMIBPDC = true },
                                    [1010206] = new CIFKOJJBCHF { Id = 1010206, BAJHKMIBPDC = true },
                                },
                                LDLCBHAEFHO = { },
                            },
                            [10103] = new BNNMKBFFNHJ
                            {
                                SectionId = 10103,
                                BAJHKMIBPDC = true,
                                LGNOAHMHJHH =
                                {
                                    [1010301] = new CIFKOJJBCHF { Id = 1010301, BAJHKMIBPDC = true },
                                    [1010302] = new CIFKOJJBCHF { Id = 1010302, BAJHKMIBPDC = true },
                                    [1010303] = new CIFKOJJBCHF { Id = 1010303, BAJHKMIBPDC = true },
                                    [1010304] = new CIFKOJJBCHF { Id = 1010304, BAJHKMIBPDC = true },
                                    [1010305] = new CIFKOJJBCHF { Id = 1010305, BAJHKMIBPDC = true },
                                    [1010306] = new CIFKOJJBCHF { Id = 1010306, BAJHKMIBPDC = true },
                                    [1010307] = new CIFKOJJBCHF { Id = 1010307, BAJHKMIBPDC = true },
                                    [1010308] = new CIFKOJJBCHF { Id = 1010308, BAJHKMIBPDC = true },
                                },
                                LDLCBHAEFHO = { },
                            },
                            [10104] = new BNNMKBFFNHJ
                            {
                                SectionId = 10104,
                                BAJHKMIBPDC = true,
                                LGNOAHMHJHH =
                                {
                                    [1010401] = new CIFKOJJBCHF { Id = 1010401, BAJHKMIBPDC = true },
                                    [1010402] = new CIFKOJJBCHF { Id = 1010402, BAJHKMIBPDC = true },
                                    [1010403] = new CIFKOJJBCHF { Id = 1010403, BAJHKMIBPDC = true },
                                    [1010404] = new CIFKOJJBCHF { Id = 1010404, BAJHKMIBPDC = true },
                                    [1010405] = new CIFKOJJBCHF { Id = 1010405, BAJHKMIBPDC = true },
                                },
                                LDLCBHAEFHO = { },
                            },
                            [10105] = new BNNMKBFFNHJ
                            {
                                SectionId = 10105,
                                BAJHKMIBPDC = true,
                                LGNOAHMHJHH =
                                {
                                    [1010501] = new CIFKOJJBCHF { Id = 1010501, BAJHKMIBPDC = true },
                                    [1010502] = new CIFKOJJBCHF { Id = 1010502, BAJHKMIBPDC = true },
                                    [1010503] = new CIFKOJJBCHF { Id = 1010503, BAJHKMIBPDC = true },
                                    [1010504] = new CIFKOJJBCHF { Id = 1010504, BAJHKMIBPDC = true },
                                },
                                LDLCBHAEFHO = { },
                            },
                        },
                        AACANKHENII = false,
                        MLIJIDKIFGF = new KEMPBIAFGHB
                        {
                            HFJLFAEFENH =
                            {
                                [3700902] = 3700903,
                                [3700908] = 3700909,
                                [3700912] = 3700913,
                                [3700917] = 3700919,
                            },
                        },
                        MLHIMAFLHAP = 0,
                    },
                    [102] = new KEAKDAMCBMM
                    {
                        Id = 102,
                        HFKNLIGCIBP =
                        {
                            [10201] = new BNNMKBFFNHJ
                            {
                                SectionId = 10201,
                                BAJHKMIBPDC = true,
                                LGNOAHMHJHH =
                                {
                                    [1020101] = new CIFKOJJBCHF { Id = 1020101, BAJHKMIBPDC = true },
                                    [1020102] = new CIFKOJJBCHF { Id = 1020102, BAJHKMIBPDC = true },
                                    [1020103] = new CIFKOJJBCHF { Id = 1020103, BAJHKMIBPDC = true },
                                    [1020104] = new CIFKOJJBCHF { Id = 1020104, BAJHKMIBPDC = true },
                                    [1020105] = new CIFKOJJBCHF { Id = 1020105, BAJHKMIBPDC = true },
                                    [1020106] = new CIFKOJJBCHF { Id = 1020106, BAJHKMIBPDC = true },
                                    [1020107] = new CIFKOJJBCHF { Id = 1020107, BAJHKMIBPDC = true },
                                    [1020108] = new CIFKOJJBCHF { Id = 1020108, BAJHKMIBPDC = true },
                                },
                                LDLCBHAEFHO = { },
                            },
                            [10202] = new BNNMKBFFNHJ
                            {
                                SectionId = 10202,
                                BAJHKMIBPDC = true,
                                LGNOAHMHJHH =
                                {
                                    [1020201] = new CIFKOJJBCHF { Id = 1020201, BAJHKMIBPDC = true },
                                    [1020202] = new CIFKOJJBCHF { Id = 1020202, BAJHKMIBPDC = true },
                                    [1020203] = new CIFKOJJBCHF { Id = 1020203, BAJHKMIBPDC = true },
                                    [1020204] = new CIFKOJJBCHF { Id = 1020204, BAJHKMIBPDC = true },
                                    [1020205] = new CIFKOJJBCHF { Id = 1020205, BAJHKMIBPDC = true },
                                    [1020206] = new CIFKOJJBCHF { Id = 1020206, BAJHKMIBPDC = true },
                                    [1020207] = new CIFKOJJBCHF { Id = 1020207, BAJHKMIBPDC = true },
                                },
                                LDLCBHAEFHO = { },
                            },
                            [10203] = new BNNMKBFFNHJ
                            {
                                SectionId = 10203,
                                BAJHKMIBPDC = true,
                                LGNOAHMHJHH =
                                {
                                    [1020301] = new CIFKOJJBCHF { Id = 1020301, BAJHKMIBPDC = true },
                                    [1020302] = new CIFKOJJBCHF { Id = 1020302, BAJHKMIBPDC = true },
                                    [1020303] = new CIFKOJJBCHF { Id = 1020303, BAJHKMIBPDC = true },
                                    [1020304] = new CIFKOJJBCHF { Id = 1020304, BAJHKMIBPDC = true },
                                    [1020305] = new CIFKOJJBCHF { Id = 1020305, BAJHKMIBPDC = true },
                                    [1020306] = new CIFKOJJBCHF { Id = 1020306, BAJHKMIBPDC = true },
                                    [1020307] = new CIFKOJJBCHF { Id = 1020307, BAJHKMIBPDC = true },
                                },
                                LDLCBHAEFHO = { },
                            },
                            [10204] = new BNNMKBFFNHJ
                            {
                                SectionId = 10204,
                                BAJHKMIBPDC = true,
                                LGNOAHMHJHH =
                                {
                                    [1020401] = new CIFKOJJBCHF { Id = 1020401, BAJHKMIBPDC = true },
                                    [1020402] = new CIFKOJJBCHF { Id = 1020402, BAJHKMIBPDC = true },
                                    [1020403] = new CIFKOJJBCHF { Id = 1020403, BAJHKMIBPDC = true },
                                    [1020404] = new CIFKOJJBCHF { Id = 1020404, BAJHKMIBPDC = true },
                                    [1020405] = new CIFKOJJBCHF { Id = 1020405, BAJHKMIBPDC = true },
                                    [1020406] = new CIFKOJJBCHF { Id = 1020406, BAJHKMIBPDC = true },
                                    [1020407] = new CIFKOJJBCHF { Id = 1020407, BAJHKMIBPDC = true },
                                    [1020408] = new CIFKOJJBCHF { Id = 1020408, BAJHKMIBPDC = true },
                                },
                                LDLCBHAEFHO = { },
                            },
                            [10205] = new BNNMKBFFNHJ
                            {
                                SectionId = 10205,
                                BAJHKMIBPDC = true,
                                LGNOAHMHJHH =
                                {
                                    [1020501] = new CIFKOJJBCHF { Id = 1020501, BAJHKMIBPDC = true },
                                    [1020502] = new CIFKOJJBCHF { Id = 1020502, BAJHKMIBPDC = true },
                                    [1020503] = new CIFKOJJBCHF { Id = 1020503, BAJHKMIBPDC = true },
                                    [1020504] = new CIFKOJJBCHF { Id = 1020504, BAJHKMIBPDC = true },
                                    [1020505] = new CIFKOJJBCHF { Id = 1020505, BAJHKMIBPDC = true },
                                },
                                LDLCBHAEFHO = { },
                            },
                        },
                        AACANKHENII = false,
                        MLIJIDKIFGF = new KEMPBIAFGHB
                        {
                            HFJLFAEFENH =
                            {
                                [3110908] = 3110909,
                                [3110917] = 3110919,
                                [3110924] = 3110925,
                                [3110936] = 3110938,
                                [3110939] = 3110941,
                            },
                        },
                        MLHIMAFLHAP = 0,
                    },
                    [103] = new KEAKDAMCBMM
                    {
                        Id = 103,
                        HFKNLIGCIBP =
                        {
                            [10301] = new BNNMKBFFNHJ
                            {
                                SectionId = 10301,
                                BAJHKMIBPDC = true,
                                LGNOAHMHJHH =
                                {
                                    [1030101] = new CIFKOJJBCHF { Id = 1030101, BAJHKMIBPDC = true },
                                    [1030102] = new CIFKOJJBCHF { Id = 1030102, BAJHKMIBPDC = true },
                                    [1030103] = new CIFKOJJBCHF { Id = 1030103, BAJHKMIBPDC = true },
                                    [1030104] = new CIFKOJJBCHF { Id = 1030104, BAJHKMIBPDC = true },
                                    [1030105] = new CIFKOJJBCHF { Id = 1030105, BAJHKMIBPDC = true },
                                    [1030106] = new CIFKOJJBCHF { Id = 1030106, BAJHKMIBPDC = true },
                                    [1030107] = new CIFKOJJBCHF { Id = 1030107, BAJHKMIBPDC = true },
                                    [1030108] = new CIFKOJJBCHF { Id = 1030108, BAJHKMIBPDC = true },
                                    [1030109] = new CIFKOJJBCHF { Id = 1030109, BAJHKMIBPDC = true },
                                    [1030110] = new CIFKOJJBCHF { Id = 1030110, BAJHKMIBPDC = true },
                                },
                                LDLCBHAEFHO = { },
                            },
                            [10302] = new BNNMKBFFNHJ
                            {
                                SectionId = 10302,
                                BAJHKMIBPDC = true,
                                LGNOAHMHJHH =
                                {
                                    [1030201] = new CIFKOJJBCHF { Id = 1030201, BAJHKMIBPDC = true },
                                    [1030202] = new CIFKOJJBCHF { Id = 1030202, BAJHKMIBPDC = true },
                                    [1030203] = new CIFKOJJBCHF { Id = 1030203, BAJHKMIBPDC = true },
                                    [1030204] = new CIFKOJJBCHF { Id = 1030204, BAJHKMIBPDC = true },
                                    [1030205] = new CIFKOJJBCHF { Id = 1030205, BAJHKMIBPDC = true },
                                    [1030206] = new CIFKOJJBCHF { Id = 1030206, BAJHKMIBPDC = true },
                                    [1030207] = new CIFKOJJBCHF { Id = 1030207, BAJHKMIBPDC = true },
                                },
                                LDLCBHAEFHO = { },
                            },
                            [10303] = new BNNMKBFFNHJ
                            {
                                SectionId = 10303,
                                BAJHKMIBPDC = true,
                                LGNOAHMHJHH =
                                {
                                    [1030301] = new CIFKOJJBCHF { Id = 1030301, BAJHKMIBPDC = true },
                                    [1030302] = new CIFKOJJBCHF { Id = 1030302, BAJHKMIBPDC = true },
                                    [1030303] = new CIFKOJJBCHF { Id = 1030303, BAJHKMIBPDC = true },
                                    [1030304] = new CIFKOJJBCHF { Id = 1030304, BAJHKMIBPDC = true },
                                    [1030305] = new CIFKOJJBCHF { Id = 1030305, BAJHKMIBPDC = true },
                                    [1030306] = new CIFKOJJBCHF { Id = 1030306, BAJHKMIBPDC = true },
                                    [1030307] = new CIFKOJJBCHF { Id = 1030307, BAJHKMIBPDC = true },
                                },
                                LDLCBHAEFHO = { },
                            },
                            [10304] = new BNNMKBFFNHJ
                            {
                                SectionId = 10304,
                                BAJHKMIBPDC = true,
                                LGNOAHMHJHH =
                                {
                                    [1030401] = new CIFKOJJBCHF { Id = 1030401, BAJHKMIBPDC = true },
                                    [1030402] = new CIFKOJJBCHF { Id = 1030402, BAJHKMIBPDC = true },
                                    [1030403] = new CIFKOJJBCHF { Id = 1030403, BAJHKMIBPDC = true },
                                    [1030404] = new CIFKOJJBCHF { Id = 1030404, BAJHKMIBPDC = true },
                                    [1030405] = new CIFKOJJBCHF { Id = 1030405, BAJHKMIBPDC = true },
                                    [1030406] = new CIFKOJJBCHF { Id = 1030406, BAJHKMIBPDC = true },
                                    [1030407] = new CIFKOJJBCHF { Id = 1030407, BAJHKMIBPDC = true },
                                    [1030408] = new CIFKOJJBCHF { Id = 1030408, BAJHKMIBPDC = true },
                                },
                                LDLCBHAEFHO = { },
                            },
                            [10305] = new BNNMKBFFNHJ
                            {
                                SectionId = 10305,
                                BAJHKMIBPDC = true,
                                LGNOAHMHJHH =
                                {
                                    [1030501] = new CIFKOJJBCHF { Id = 1030501, BAJHKMIBPDC = true },
                                    [1030502] = new CIFKOJJBCHF { Id = 1030502, BAJHKMIBPDC = true },
                                    [1030503] = new CIFKOJJBCHF { Id = 1030503, BAJHKMIBPDC = true },
                                    [1030504] = new CIFKOJJBCHF { Id = 1030504, BAJHKMIBPDC = true },
                                    [1030505] = new CIFKOJJBCHF { Id = 1030505, BAJHKMIBPDC = true },
                                    [1030506] = new CIFKOJJBCHF { Id = 1030506, BAJHKMIBPDC = true },
                                },
                                LDLCBHAEFHO = { },
                            },
                        },
                        AACANKHENII = false,
                        MLIJIDKIFGF = new KEMPBIAFGHB
                        {
                            HFJLFAEFENH =
                            {
                                [3160910] = 3160911,
                                [3160915] = 3160916,
                                [3160919] = 3160920,
                                [3160925] = 3160926,
                                [3160936] = 3160937,
                            },
                        },
                        MLHIMAFLHAP = 0,
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
                IJEOPLAPLIB = (uint)DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                MICAPNGJBPH = false,
            });
        }

        public override void HandleLobbyMessageBoardInfo(CS_LobbyMessageBoardInfo request, Connection connection)
        {
            uint nowUnix = (uint)DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            connection.Send(new SC_LobbyMessageBoardInfo
            {
                CECNOCLMAOG = new BNCNOLPBNBN
                {
                    Message = new OGKLGOMMLIM
                    {
                        Timestamp = nowUnix,
                        BNAJBJBNIAK = 248,
                    },
                    LMFLEGLPBPG =
                    {
                        [1] = 3,
                    },
                },
                GFOMBFKMPGC = { },
                GLCJKEFJOLA =
                {
                    [77] = new OGKLGOMMLIM { Timestamp = nowUnix, BNAJBJBNIAK = 77 },
                    [235] = new OGKLGOMMLIM { Timestamp = nowUnix, BNAJBJBNIAK = 235 },
                    [236] = new OGKLGOMMLIM { Timestamp = nowUnix, BNAJBJBNIAK = 236 },
                    [248] = new OGKLGOMMLIM { Timestamp = nowUnix, BNAJBJBNIAK = 248 },
                },
            });
        }

                public override void HandleLobbyAvatarInfo(CS_LobbyAvatarInfo request, Connection connection)
        {
            connection.Send(new SC_LobbyAvatarInfo
            {
                HIOGBPMJGON = new CGLPDAABOEP
                {
                    MPFFENCOPFP = 1071,
                    OCCAHBFCHNP = 1002,
                },
            });
        }

        public override void HandleLobbyAvatarSwitch(CS_LobbyAvatarSwitch request, Connection connection)
        {
            connection.Send(new SC_LobbyAvatarSwitch
            {
                MPFFENCOPFP = request.MPFFENCOPFP,
            });
        }

        public override void HandleLobbyAvatarClotheChange(CS_LobbyAvatarClotheChange request, Connection connection)
        {
            connection.Send(new SC_LobbyAvatarClotheChange
            {
                PPKOJNBJJFH = request.PPKOJNBJJFH,
            });
        }

        public override void HandleGetLobbyMeilingConfig(CS_GetLobbyMeilingConfig request, Connection connection)
        {
            connection.Send(new SC_GetLobbyMeilingConfig
            {
                ECGAHCPCDDI = { 402, 403, 404, 405 },
            });
        }

                public override void HandleLobbyWelcomeSettingPlayed(CS_LobbyWelcomeSettingPlayed request, Connection connection)
        {
            uint nowUnix = (uint)DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            connection.Send(new SC_LobbyWelcomeSettingPlayed
            {
                OBOGLCLAIPH = new NMEMMFMPCJB
                {
                    OIKBNGNPNIM = true,
                    DHFNGECCLAK = nowUnix,
                    JCOMGOPOLOP = 1017,
                    HPNKLKLOECK = true,
                },
            });
        }

        public override void HandleLobbyCancelEvent(CS_LobbyCancelEvent request, Connection connection)
        {
            SC_LobbyCancelEvent response = new SC_LobbyCancelEvent();
            response.MNDDGCLCMDP.AddRange(request.MNDDGCLCMDP);
            connection.Send(response);
        }

        public override void HandleLobbyTriggerEvent(CS_LobbyTriggerEvent request, Connection connection)
        {
            connection.Send(new SC_LobbyTriggerEvent
            {
                ABAPKEKAPCJ = new KMIAGEBIMIP
                {
                    EventId = request.HIOILHEPJCK,
                },
                INCNFOFGJFB = { },
            });
        }

        public override void HandleLobbyAsmrBegin(CS_LobbyAsmrBegin request, Connection connection)
        {
            connection.Send(new SC_LobbyAsmrBegin
            {
                GunId = request.GunId,
            });
        }
    }
}
