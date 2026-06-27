using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class StageHandler : StageHandlerBase
    {
        public override void HandleStageRecord(CS_StageRecord request, Connection connection)
        {
            switch (request.Type)
            {
                case 11:
                    {
                        connection.Send(1, new SC_StageRecord
                        {
                            Record = null,
                            Records =
                        {
                        {
                            10104,
                            new StageRecord()
                            {
                                StageId = 10104,
                                FirstPassTime = 1703900906,
                                CompleteChallenges = 7,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 1,
                                MCDNPPCAFOK = true,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            10105,
                            new StageRecord()
                            {
                                StageId = 10105,
                                FirstPassTime = 1703901048,
                                CompleteChallenges = 7,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 1,
                                MCDNPPCAFOK = true,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            10106,
                            new StageRecord()
                            {
                                StageId = 10106,
                                FirstPassTime = 1703901190,
                                CompleteChallenges = 7,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 1,
                                MCDNPPCAFOK = true,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            10107,
                            new StageRecord()
                            {
                                StageId = 10107,
                                FirstPassTime = 1728667765,
                                CompleteChallenges = 7,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 1,
                                MCDNPPCAFOK = true,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            10108,
                            new StageRecord()
                            {
                                StageId = 10108,
                                FirstPassTime = 1728668071,
                                CompleteChallenges = 7,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 1,
                                MCDNPPCAFOK = true,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            10109,
                            new StageRecord()
                            {
                                StageId = 10109,
                                FirstPassTime = 1728668217,
                                CompleteChallenges = 7,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 1,
                                MCDNPPCAFOK = true,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            10110,
                            new StageRecord()
                            {
                                StageId = 10110,
                                FirstPassTime = 1728668611,
                                CompleteChallenges = 7,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 1,
                                MCDNPPCAFOK = true,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            10141,
                            new StageRecord()
                            {
                                StageId = 10141,
                                FirstPassTime = 1728667617,
                                CompleteChallenges = 7,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 1,
                                MCDNPPCAFOK = true,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            10142,
                            new StageRecord()
                            {
                                StageId = 10142,
                                FirstPassTime = 1728667936,
                                CompleteChallenges = 7,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 1,
                                MCDNPPCAFOK = true,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            10143,
                            new StageRecord()
                            {
                                StageId = 10143,
                                FirstPassTime = 1728668327,
                                CompleteChallenges = 7,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 1,
                                MCDNPPCAFOK = true,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            10183,
                            new StageRecord()
                            {
                                StageId = 10183,
                                FirstPassTime = 1703901077,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 1,
                                MCDNPPCAFOK = true,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            10184,
                            new StageRecord()
                            {
                                StageId = 10184,
                                FirstPassTime = 1703901217,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 1,
                                MCDNPPCAFOK = true,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        },
                        });
                        break;
                    }
                case 12:
                    {
                        connection.Send(0, new SC_StageRecord
                        {
                            Record = null,
                            Records =
                        {
                        {
                            10101,
                            new StageRecord()
                            {
                                StageId = 10101,
                                FirstPassTime = 1703900194,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 1,
                                MCDNPPCAFOK = true,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            10102,
                            new StageRecord()
                            {
                                StageId = 10102,
                                FirstPassTime = 1703900349,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 1,
                                MCDNPPCAFOK = true,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            10103,
                            new StageRecord()
                            {
                                StageId = 10103,
                                FirstPassTime = 1703900704,
                                CompleteChallenges = 7,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 1,
                                MCDNPPCAFOK = true,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        },
                        });
                        break;
                    }
                case 13:
                    {
                        connection.Send(0, new SC_StageRecord
                        {
                            Record = null,
                            Records =
                        {
                        {
                            10001,
                            new StageRecord()
                            {
                                StageId = 10001,
                                FirstPassTime = 1703592371,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 1,
                                MCDNPPCAFOK = true,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        },
                        });
                        break;
                    }
                case 14:
                    {
                        connection.Send(28, new SC_StageRecord
                        {
                            Record = null,
                            Records =
                        {
                        {
                            30101,
                            new StageRecord()
                            {
                                StageId = 30101,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30102,
                            new StageRecord()
                            {
                                StageId = 30102,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30103,
                            new StageRecord()
                            {
                                StageId = 30103,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30104,
                            new StageRecord()
                            {
                                StageId = 30104,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30105,
                            new StageRecord()
                            {
                                StageId = 30105,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30301,
                            new StageRecord()
                            {
                                StageId = 30301,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30302,
                            new StageRecord()
                            {
                                StageId = 30302,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30303,
                            new StageRecord()
                            {
                                StageId = 30303,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30304,
                            new StageRecord()
                            {
                                StageId = 30304,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30305,
                            new StageRecord()
                            {
                                StageId = 30305,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30306,
                            new StageRecord()
                            {
                                StageId = 30306,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30307,
                            new StageRecord()
                            {
                                StageId = 30307,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30308,
                            new StageRecord()
                            {
                                StageId = 30308,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30309,
                            new StageRecord()
                            {
                                StageId = 30309,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30311,
                            new StageRecord()
                            {
                                StageId = 30311,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30312,
                            new StageRecord()
                            {
                                StageId = 30312,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30313,
                            new StageRecord()
                            {
                                StageId = 30313,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30314,
                            new StageRecord()
                            {
                                StageId = 30314,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30315,
                            new StageRecord()
                            {
                                StageId = 30315,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30316,
                            new StageRecord()
                            {
                                StageId = 30316,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30381,
                            new StageRecord()
                            {
                                StageId = 30381,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30382,
                            new StageRecord()
                            {
                                StageId = 30382,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30401,
                            new StageRecord()
                            {
                                StageId = 30401,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30402,
                            new StageRecord()
                            {
                                StageId = 30402,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30403,
                            new StageRecord()
                            {
                                StageId = 30403,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30404,
                            new StageRecord()
                            {
                                StageId = 30404,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30405,
                            new StageRecord()
                            {
                                StageId = 30405,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30406,
                            new StageRecord()
                            {
                                StageId = 30406,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30407,
                            new StageRecord()
                            {
                                StageId = 30407,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30408,
                            new StageRecord()
                            {
                                StageId = 30408,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30409,
                            new StageRecord()
                            {
                                StageId = 30409,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30461,
                            new StageRecord()
                            {
                                StageId = 30461,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30462,
                            new StageRecord()
                            {
                                StageId = 30462,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30463,
                            new StageRecord()
                            {
                                StageId = 30463,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30464,
                            new StageRecord()
                            {
                                StageId = 30464,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30465,
                            new StageRecord()
                            {
                                StageId = 30465,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30486,
                            new StageRecord()
                            {
                                StageId = 30486,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30501,
                            new StageRecord()
                            {
                                StageId = 30501,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30502,
                            new StageRecord()
                            {
                                StageId = 30502,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30503,
                            new StageRecord()
                            {
                                StageId = 30503,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30504,
                            new StageRecord()
                            {
                                StageId = 30504,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30505,
                            new StageRecord()
                            {
                                StageId = 30505,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30506,
                            new StageRecord()
                            {
                                StageId = 30506,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30507,
                            new StageRecord()
                            {
                                StageId = 30507,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30508,
                            new StageRecord()
                            {
                                StageId = 30508,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30509,
                            new StageRecord()
                            {
                                StageId = 30509,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30541,
                            new StageRecord()
                            {
                                StageId = 30541,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30542,
                            new StageRecord()
                            {
                                StageId = 30542,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30543,
                            new StageRecord()
                            {
                                StageId = 30543,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30544,
                            new StageRecord()
                            {
                                StageId = 30544,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30545,
                            new StageRecord()
                            {
                                StageId = 30545,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30546,
                            new StageRecord()
                            {
                                StageId = 30546,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30561,
                            new StageRecord()
                            {
                                StageId = 30561,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30562,
                            new StageRecord()
                            {
                                StageId = 30562,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30563,
                            new StageRecord()
                            {
                                StageId = 30563,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30564,
                            new StageRecord()
                            {
                                StageId = 30564,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30565,
                            new StageRecord()
                            {
                                StageId = 30565,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30586,
                            new StageRecord()
                            {
                                StageId = 30586,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30587,
                            new StageRecord()
                            {
                                StageId = 30587,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30701,
                            new StageRecord()
                            {
                                StageId = 30701,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30702,
                            new StageRecord()
                            {
                                StageId = 30702,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30703,
                            new StageRecord()
                            {
                                StageId = 30703,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30704,
                            new StageRecord()
                            {
                                StageId = 30704,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30705,
                            new StageRecord()
                            {
                                StageId = 30705,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30706,
                            new StageRecord()
                            {
                                StageId = 30706,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30707,
                            new StageRecord()
                            {
                                StageId = 30707,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30708,
                            new StageRecord()
                            {
                                StageId = 30708,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30709,
                            new StageRecord()
                            {
                                StageId = 30709,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30761,
                            new StageRecord()
                            {
                                StageId = 30761,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30762,
                            new StageRecord()
                            {
                                StageId = 30762,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30763,
                            new StageRecord()
                            {
                                StageId = 30763,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30764,
                            new StageRecord()
                            {
                                StageId = 30764,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30765,
                            new StageRecord()
                            {
                                StageId = 30765,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30786,
                            new StageRecord()
                            {
                                StageId = 30786,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30787,
                            new StageRecord()
                            {
                                StageId = 30787,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30788,
                            new StageRecord()
                            {
                                StageId = 30788,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30801,
                            new StageRecord()
                            {
                                StageId = 30801,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30802,
                            new StageRecord()
                            {
                                StageId = 30802,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30803,
                            new StageRecord()
                            {
                                StageId = 30803,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30804,
                            new StageRecord()
                            {
                                StageId = 30804,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30805,
                            new StageRecord()
                            {
                                StageId = 30805,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30806,
                            new StageRecord()
                            {
                                StageId = 30806,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30807,
                            new StageRecord()
                            {
                                StageId = 30807,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30808,
                            new StageRecord()
                            {
                                StageId = 30808,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30809,
                            new StageRecord()
                            {
                                StageId = 30809,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30841,
                            new StageRecord()
                            {
                                StageId = 30841,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30842,
                            new StageRecord()
                            {
                                StageId = 30842,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30843,
                            new StageRecord()
                            {
                                StageId = 30843,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30844,
                            new StageRecord()
                            {
                                StageId = 30844,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30845,
                            new StageRecord()
                            {
                                StageId = 30845,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30846,
                            new StageRecord()
                            {
                                StageId = 30846,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30861,
                            new StageRecord()
                            {
                                StageId = 30861,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30862,
                            new StageRecord()
                            {
                                StageId = 30862,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30863,
                            new StageRecord()
                            {
                                StageId = 30863,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30864,
                            new StageRecord()
                            {
                                StageId = 30864,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30865,
                            new StageRecord()
                            {
                                StageId = 30865,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30881,
                            new StageRecord()
                            {
                                StageId = 30881,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30882,
                            new StageRecord()
                            {
                                StageId = 30882,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30901,
                            new StageRecord()
                            {
                                StageId = 30901,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30902,
                            new StageRecord()
                            {
                                StageId = 30902,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30903,
                            new StageRecord()
                            {
                                StageId = 30903,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30904,
                            new StageRecord()
                            {
                                StageId = 30904,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30905,
                            new StageRecord()
                            {
                                StageId = 30905,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30906,
                            new StageRecord()
                            {
                                StageId = 30906,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30907,
                            new StageRecord()
                            {
                                StageId = 30907,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30908,
                            new StageRecord()
                            {
                                StageId = 30908,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30909,
                            new StageRecord()
                            {
                                StageId = 30909,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30910,
                            new StageRecord()
                            {
                                StageId = 30910,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30941,
                            new StageRecord()
                            {
                                StageId = 30941,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30942,
                            new StageRecord()
                            {
                                StageId = 30942,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30943,
                            new StageRecord()
                            {
                                StageId = 30943,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30944,
                            new StageRecord()
                            {
                                StageId = 30944,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30945,
                            new StageRecord()
                            {
                                StageId = 30945,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30946,
                            new StageRecord()
                            {
                                StageId = 30946,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30961,
                            new StageRecord()
                            {
                                StageId = 30961,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30962,
                            new StageRecord()
                            {
                                StageId = 30962,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30963,
                            new StageRecord()
                            {
                                StageId = 30963,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30964,
                            new StageRecord()
                            {
                                StageId = 30964,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30965,
                            new StageRecord()
                            {
                                StageId = 30965,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30981,
                            new StageRecord()
                            {
                                StageId = 30981,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30982,
                            new StageRecord()
                            {
                                StageId = 30982,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            30983,
                            new StageRecord()
                            {
                                StageId = 30983,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31001,
                            new StageRecord()
                            {
                                StageId = 31001,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31002,
                            new StageRecord()
                            {
                                StageId = 31002,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31003,
                            new StageRecord()
                            {
                                StageId = 31003,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31004,
                            new StageRecord()
                            {
                                StageId = 31004,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31005,
                            new StageRecord()
                            {
                                StageId = 31005,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31006,
                            new StageRecord()
                            {
                                StageId = 31006,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31007,
                            new StageRecord()
                            {
                                StageId = 31007,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31008,
                            new StageRecord()
                            {
                                StageId = 31008,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31009,
                            new StageRecord()
                            {
                                StageId = 31009,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31041,
                            new StageRecord()
                            {
                                StageId = 31041,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31042,
                            new StageRecord()
                            {
                                StageId = 31042,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31043,
                            new StageRecord()
                            {
                                StageId = 31043,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31044,
                            new StageRecord()
                            {
                                StageId = 31044,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31045,
                            new StageRecord()
                            {
                                StageId = 31045,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31046,
                            new StageRecord()
                            {
                                StageId = 31046,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31061,
                            new StageRecord()
                            {
                                StageId = 31061,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31062,
                            new StageRecord()
                            {
                                StageId = 31062,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31063,
                            new StageRecord()
                            {
                                StageId = 31063,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31064,
                            new StageRecord()
                            {
                                StageId = 31064,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31065,
                            new StageRecord()
                            {
                                StageId = 31065,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31081,
                            new StageRecord()
                            {
                                StageId = 31081,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31082,
                            new StageRecord()
                            {
                                StageId = 31082,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31101,
                            new StageRecord()
                            {
                                StageId = 31101,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31102,
                            new StageRecord()
                            {
                                StageId = 31102,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31103,
                            new StageRecord()
                            {
                                StageId = 31103,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31104,
                            new StageRecord()
                            {
                                StageId = 31104,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31105,
                            new StageRecord()
                            {
                                StageId = 31105,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31106,
                            new StageRecord()
                            {
                                StageId = 31106,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31107,
                            new StageRecord()
                            {
                                StageId = 31107,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31108,
                            new StageRecord()
                            {
                                StageId = 31108,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31109,
                            new StageRecord()
                            {
                                StageId = 31109,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31161,
                            new StageRecord()
                            {
                                StageId = 31161,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31162,
                            new StageRecord()
                            {
                                StageId = 31162,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31163,
                            new StageRecord()
                            {
                                StageId = 31163,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31164,
                            new StageRecord()
                            {
                                StageId = 31164,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31165,
                            new StageRecord()
                            {
                                StageId = 31165,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31181,
                            new StageRecord()
                            {
                                StageId = 31181,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31201,
                            new StageRecord()
                            {
                                StageId = 31201,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31202,
                            new StageRecord()
                            {
                                StageId = 31202,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31203,
                            new StageRecord()
                            {
                                StageId = 31203,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31204,
                            new StageRecord()
                            {
                                StageId = 31204,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31205,
                            new StageRecord()
                            {
                                StageId = 31205,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31206,
                            new StageRecord()
                            {
                                StageId = 31206,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31207,
                            new StageRecord()
                            {
                                StageId = 31207,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31208,
                            new StageRecord()
                            {
                                StageId = 31208,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31209,
                            new StageRecord()
                            {
                                StageId = 31209,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31261,
                            new StageRecord()
                            {
                                StageId = 31261,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31262,
                            new StageRecord()
                            {
                                StageId = 31262,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31263,
                            new StageRecord()
                            {
                                StageId = 31263,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31264,
                            new StageRecord()
                            {
                                StageId = 31264,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31265,
                            new StageRecord()
                            {
                                StageId = 31265,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31281,
                            new StageRecord()
                            {
                                StageId = 31281,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31282,
                            new StageRecord()
                            {
                                StageId = 31282,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31283,
                            new StageRecord()
                            {
                                StageId = 31283,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31301,
                            new StageRecord()
                            {
                                StageId = 31301,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31302,
                            new StageRecord()
                            {
                                StageId = 31302,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31303,
                            new StageRecord()
                            {
                                StageId = 31303,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31304,
                            new StageRecord()
                            {
                                StageId = 31304,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31305,
                            new StageRecord()
                            {
                                StageId = 31305,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31306,
                            new StageRecord()
                            {
                                StageId = 31306,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31307,
                            new StageRecord()
                            {
                                StageId = 31307,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31308,
                            new StageRecord()
                            {
                                StageId = 31308,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31309,
                            new StageRecord()
                            {
                                StageId = 31309,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31310,
                            new StageRecord()
                            {
                                StageId = 31310,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31341,
                            new StageRecord()
                            {
                                StageId = 31341,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31342,
                            new StageRecord()
                            {
                                StageId = 31342,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31343,
                            new StageRecord()
                            {
                                StageId = 31343,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31344,
                            new StageRecord()
                            {
                                StageId = 31344,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31345,
                            new StageRecord()
                            {
                                StageId = 31345,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31346,
                            new StageRecord()
                            {
                                StageId = 31346,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31361,
                            new StageRecord()
                            {
                                StageId = 31361,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31362,
                            new StageRecord()
                            {
                                StageId = 31362,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31363,
                            new StageRecord()
                            {
                                StageId = 31363,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31364,
                            new StageRecord()
                            {
                                StageId = 31364,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31365,
                            new StageRecord()
                            {
                                StageId = 31365,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31381,
                            new StageRecord()
                            {
                                StageId = 31381,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31382,
                            new StageRecord()
                            {
                                StageId = 31382,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31383,
                            new StageRecord()
                            {
                                StageId = 31383,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31384,
                            new StageRecord()
                            {
                                StageId = 31384,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31401,
                            new StageRecord()
                            {
                                StageId = 31401,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31402,
                            new StageRecord()
                            {
                                StageId = 31402,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31403,
                            new StageRecord()
                            {
                                StageId = 31403,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31404,
                            new StageRecord()
                            {
                                StageId = 31404,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31405,
                            new StageRecord()
                            {
                                StageId = 31405,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31406,
                            new StageRecord()
                            {
                                StageId = 31406,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31407,
                            new StageRecord()
                            {
                                StageId = 31407,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31408,
                            new StageRecord()
                            {
                                StageId = 31408,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31409,
                            new StageRecord()
                            {
                                StageId = 31409,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31410,
                            new StageRecord()
                            {
                                StageId = 31410,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31411,
                            new StageRecord()
                            {
                                StageId = 31411,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31441,
                            new StageRecord()
                            {
                                StageId = 31441,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31442,
                            new StageRecord()
                            {
                                StageId = 31442,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31443,
                            new StageRecord()
                            {
                                StageId = 31443,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31444,
                            new StageRecord()
                            {
                                StageId = 31444,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31445,
                            new StageRecord()
                            {
                                StageId = 31445,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31461,
                            new StageRecord()
                            {
                                StageId = 31461,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31462,
                            new StageRecord()
                            {
                                StageId = 31462,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31463,
                            new StageRecord()
                            {
                                StageId = 31463,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31464,
                            new StageRecord()
                            {
                                StageId = 31464,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31465,
                            new StageRecord()
                            {
                                StageId = 31465,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31481,
                            new StageRecord()
                            {
                                StageId = 31481,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31482,
                            new StageRecord()
                            {
                                StageId = 31482,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31483,
                            new StageRecord()
                            {
                                StageId = 31483,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31484,
                            new StageRecord()
                            {
                                StageId = 31484,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31485,
                            new StageRecord()
                            {
                                StageId = 31485,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31486,
                            new StageRecord()
                            {
                                StageId = 31486,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31501,
                            new StageRecord()
                            {
                                StageId = 31501,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31502,
                            new StageRecord()
                            {
                                StageId = 31502,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31503,
                            new StageRecord()
                            {
                                StageId = 31503,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31504,
                            new StageRecord()
                            {
                                StageId = 31504,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31505,
                            new StageRecord()
                            {
                                StageId = 31505,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31506,
                            new StageRecord()
                            {
                                StageId = 31506,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31507,
                            new StageRecord()
                            {
                                StageId = 31507,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31508,
                            new StageRecord()
                            {
                                StageId = 31508,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31509,
                            new StageRecord()
                            {
                                StageId = 31509,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31561,
                            new StageRecord()
                            {
                                StageId = 31561,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31562,
                            new StageRecord()
                            {
                                StageId = 31562,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31563,
                            new StageRecord()
                            {
                                StageId = 31563,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31564,
                            new StageRecord()
                            {
                                StageId = 31564,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31565,
                            new StageRecord()
                            {
                                StageId = 31565,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31581,
                            new StageRecord()
                            {
                                StageId = 31581,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31582,
                            new StageRecord()
                            {
                                StageId = 31582,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31601,
                            new StageRecord()
                            {
                                StageId = 31601,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31602,
                            new StageRecord()
                            {
                                StageId = 31602,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31603,
                            new StageRecord()
                            {
                                StageId = 31603,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31604,
                            new StageRecord()
                            {
                                StageId = 31604,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31605,
                            new StageRecord()
                            {
                                StageId = 31605,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31606,
                            new StageRecord()
                            {
                                StageId = 31606,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31607,
                            new StageRecord()
                            {
                                StageId = 31607,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31608,
                            new StageRecord()
                            {
                                StageId = 31608,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31609,
                            new StageRecord()
                            {
                                StageId = 31609,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31661,
                            new StageRecord()
                            {
                                StageId = 31661,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31662,
                            new StageRecord()
                            {
                                StageId = 31662,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31663,
                            new StageRecord()
                            {
                                StageId = 31663,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31664,
                            new StageRecord()
                            {
                                StageId = 31664,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31665,
                            new StageRecord()
                            {
                                StageId = 31665,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31681,
                            new StageRecord()
                            {
                                StageId = 31681,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31682,
                            new StageRecord()
                            {
                                StageId = 31682,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31683,
                            new StageRecord()
                            {
                                StageId = 31683,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31684,
                            new StageRecord()
                            {
                                StageId = 31684,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31685,
                            new StageRecord()
                            {
                                StageId = 31685,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31701,
                            new StageRecord()
                            {
                                StageId = 31701,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31702,
                            new StageRecord()
                            {
                                StageId = 31702,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31703,
                            new StageRecord()
                            {
                                StageId = 31703,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31704,
                            new StageRecord()
                            {
                                StageId = 31704,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31705,
                            new StageRecord()
                            {
                                StageId = 31705,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31706,
                            new StageRecord()
                            {
                                StageId = 31706,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31707,
                            new StageRecord()
                            {
                                StageId = 31707,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31708,
                            new StageRecord()
                            {
                                StageId = 31708,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31709,
                            new StageRecord()
                            {
                                StageId = 31709,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31761,
                            new StageRecord()
                            {
                                StageId = 31761,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31762,
                            new StageRecord()
                            {
                                StageId = 31762,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31763,
                            new StageRecord()
                            {
                                StageId = 31763,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31764,
                            new StageRecord()
                            {
                                StageId = 31764,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31765,
                            new StageRecord()
                            {
                                StageId = 31765,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31781,
                            new StageRecord()
                            {
                                StageId = 31781,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31782,
                            new StageRecord()
                            {
                                StageId = 31782,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31783,
                            new StageRecord()
                            {
                                StageId = 31783,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31784,
                            new StageRecord()
                            {
                                StageId = 31784,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31785,
                            new StageRecord()
                            {
                                StageId = 31785,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31786,
                            new StageRecord()
                            {
                                StageId = 31786,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31801,
                            new StageRecord()
                            {
                                StageId = 31801,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31802,
                            new StageRecord()
                            {
                                StageId = 31802,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31803,
                            new StageRecord()
                            {
                                StageId = 31803,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31804,
                            new StageRecord()
                            {
                                StageId = 31804,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31805,
                            new StageRecord()
                            {
                                StageId = 31805,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31806,
                            new StageRecord()
                            {
                                StageId = 31806,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31807,
                            new StageRecord()
                            {
                                StageId = 31807,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31808,
                            new StageRecord()
                            {
                                StageId = 31808,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31809,
                            new StageRecord()
                            {
                                StageId = 31809,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31810,
                            new StageRecord()
                            {
                                StageId = 31810,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31811,
                            new StageRecord()
                            {
                                StageId = 31811,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31841,
                            new StageRecord()
                            {
                                StageId = 31841,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31842,
                            new StageRecord()
                            {
                                StageId = 31842,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31843,
                            new StageRecord()
                            {
                                StageId = 31843,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31844,
                            new StageRecord()
                            {
                                StageId = 31844,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31845,
                            new StageRecord()
                            {
                                StageId = 31845,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31846,
                            new StageRecord()
                            {
                                StageId = 31846,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31861,
                            new StageRecord()
                            {
                                StageId = 31861,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31862,
                            new StageRecord()
                            {
                                StageId = 31862,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31863,
                            new StageRecord()
                            {
                                StageId = 31863,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31864,
                            new StageRecord()
                            {
                                StageId = 31864,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31865,
                            new StageRecord()
                            {
                                StageId = 31865,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31881,
                            new StageRecord()
                            {
                                StageId = 31881,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31882,
                            new StageRecord()
                            {
                                StageId = 31882,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31883,
                            new StageRecord()
                            {
                                StageId = 31883,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31884,
                            new StageRecord()
                            {
                                StageId = 31884,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31901,
                            new StageRecord()
                            {
                                StageId = 31901,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31902,
                            new StageRecord()
                            {
                                StageId = 31902,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31903,
                            new StageRecord()
                            {
                                StageId = 31903,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31904,
                            new StageRecord()
                            {
                                StageId = 31904,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31905,
                            new StageRecord()
                            {
                                StageId = 31905,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31906,
                            new StageRecord()
                            {
                                StageId = 31906,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31907,
                            new StageRecord()
                            {
                                StageId = 31907,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31908,
                            new StageRecord()
                            {
                                StageId = 31908,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31909,
                            new StageRecord()
                            {
                                StageId = 31909,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31910,
                            new StageRecord()
                            {
                                StageId = 31910,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31911,
                            new StageRecord()
                            {
                                StageId = 31911,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31941,
                            new StageRecord()
                            {
                                StageId = 31941,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31942,
                            new StageRecord()
                            {
                                StageId = 31942,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31943,
                            new StageRecord()
                            {
                                StageId = 31943,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31944,
                            new StageRecord()
                            {
                                StageId = 31944,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31945,
                            new StageRecord()
                            {
                                StageId = 31945,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31946,
                            new StageRecord()
                            {
                                StageId = 31946,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31961,
                            new StageRecord()
                            {
                                StageId = 31961,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31962,
                            new StageRecord()
                            {
                                StageId = 31962,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31963,
                            new StageRecord()
                            {
                                StageId = 31963,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31964,
                            new StageRecord()
                            {
                                StageId = 31964,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31965,
                            new StageRecord()
                            {
                                StageId = 31965,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31981,
                            new StageRecord()
                            {
                                StageId = 31981,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31982,
                            new StageRecord()
                            {
                                StageId = 31982,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31983,
                            new StageRecord()
                            {
                                StageId = 31983,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31984,
                            new StageRecord()
                            {
                                StageId = 31984,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31985,
                            new StageRecord()
                            {
                                StageId = 31985,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31986,
                            new StageRecord()
                            {
                                StageId = 31986,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31988,
                            new StageRecord()
                            {
                                StageId = 31988,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31989,
                            new StageRecord()
                            {
                                StageId = 31989,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32001,
                            new StageRecord()
                            {
                                StageId = 32001,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32002,
                            new StageRecord()
                            {
                                StageId = 32002,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32003,
                            new StageRecord()
                            {
                                StageId = 32003,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32004,
                            new StageRecord()
                            {
                                StageId = 32004,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32005,
                            new StageRecord()
                            {
                                StageId = 32005,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32006,
                            new StageRecord()
                            {
                                StageId = 32006,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32007,
                            new StageRecord()
                            {
                                StageId = 32007,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32008,
                            new StageRecord()
                            {
                                StageId = 32008,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32009,
                            new StageRecord()
                            {
                                StageId = 32009,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32041,
                            new StageRecord()
                            {
                                StageId = 32041,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32042,
                            new StageRecord()
                            {
                                StageId = 32042,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32043,
                            new StageRecord()
                            {
                                StageId = 32043,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32044,
                            new StageRecord()
                            {
                                StageId = 32044,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32045,
                            new StageRecord()
                            {
                                StageId = 32045,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32046,
                            new StageRecord()
                            {
                                StageId = 32046,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32061,
                            new StageRecord()
                            {
                                StageId = 32061,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32062,
                            new StageRecord()
                            {
                                StageId = 32062,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32063,
                            new StageRecord()
                            {
                                StageId = 32063,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32064,
                            new StageRecord()
                            {
                                StageId = 32064,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32065,
                            new StageRecord()
                            {
                                StageId = 32065,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32081,
                            new StageRecord()
                            {
                                StageId = 32081,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32082,
                            new StageRecord()
                            {
                                StageId = 32082,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32083,
                            new StageRecord()
                            {
                                StageId = 32083,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32084,
                            new StageRecord()
                            {
                                StageId = 32084,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32085,
                            new StageRecord()
                            {
                                StageId = 32085,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32086,
                            new StageRecord()
                            {
                                StageId = 32086,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32101,
                            new StageRecord()
                            {
                                StageId = 32101,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32102,
                            new StageRecord()
                            {
                                StageId = 32102,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32103,
                            new StageRecord()
                            {
                                StageId = 32103,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32104,
                            new StageRecord()
                            {
                                StageId = 32104,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32105,
                            new StageRecord()
                            {
                                StageId = 32105,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32106,
                            new StageRecord()
                            {
                                StageId = 32106,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32107,
                            new StageRecord()
                            {
                                StageId = 32107,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32108,
                            new StageRecord()
                            {
                                StageId = 32108,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32109,
                            new StageRecord()
                            {
                                StageId = 32109,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32141,
                            new StageRecord()
                            {
                                StageId = 32141,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32142,
                            new StageRecord()
                            {
                                StageId = 32142,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32143,
                            new StageRecord()
                            {
                                StageId = 32143,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32144,
                            new StageRecord()
                            {
                                StageId = 32144,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32145,
                            new StageRecord()
                            {
                                StageId = 32145,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32146,
                            new StageRecord()
                            {
                                StageId = 32146,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32161,
                            new StageRecord()
                            {
                                StageId = 32161,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32162,
                            new StageRecord()
                            {
                                StageId = 32162,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32163,
                            new StageRecord()
                            {
                                StageId = 32163,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32164,
                            new StageRecord()
                            {
                                StageId = 32164,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32165,
                            new StageRecord()
                            {
                                StageId = 32165,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32181,
                            new StageRecord()
                            {
                                StageId = 32181,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32182,
                            new StageRecord()
                            {
                                StageId = 32182,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32183,
                            new StageRecord()
                            {
                                StageId = 32183,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32184,
                            new StageRecord()
                            {
                                StageId = 32184,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32185,
                            new StageRecord()
                            {
                                StageId = 32185,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32186,
                            new StageRecord()
                            {
                                StageId = 32186,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32187,
                            new StageRecord()
                            {
                                StageId = 32187,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32188,
                            new StageRecord()
                            {
                                StageId = 32188,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32201,
                            new StageRecord()
                            {
                                StageId = 32201,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32202,
                            new StageRecord()
                            {
                                StageId = 32202,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32203,
                            new StageRecord()
                            {
                                StageId = 32203,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32204,
                            new StageRecord()
                            {
                                StageId = 32204,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32205,
                            new StageRecord()
                            {
                                StageId = 32205,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32206,
                            new StageRecord()
                            {
                                StageId = 32206,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32207,
                            new StageRecord()
                            {
                                StageId = 32207,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32208,
                            new StageRecord()
                            {
                                StageId = 32208,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32209,
                            new StageRecord()
                            {
                                StageId = 32209,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32241,
                            new StageRecord()
                            {
                                StageId = 32241,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32242,
                            new StageRecord()
                            {
                                StageId = 32242,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32243,
                            new StageRecord()
                            {
                                StageId = 32243,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32244,
                            new StageRecord()
                            {
                                StageId = 32244,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32245,
                            new StageRecord()
                            {
                                StageId = 32245,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32246,
                            new StageRecord()
                            {
                                StageId = 32246,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32261,
                            new StageRecord()
                            {
                                StageId = 32261,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32262,
                            new StageRecord()
                            {
                                StageId = 32262,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32263,
                            new StageRecord()
                            {
                                StageId = 32263,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32264,
                            new StageRecord()
                            {
                                StageId = 32264,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32265,
                            new StageRecord()
                            {
                                StageId = 32265,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32281,
                            new StageRecord()
                            {
                                StageId = 32281,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32282,
                            new StageRecord()
                            {
                                StageId = 32282,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32283,
                            new StageRecord()
                            {
                                StageId = 32283,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32284,
                            new StageRecord()
                            {
                                StageId = 32284,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32301,
                            new StageRecord()
                            {
                                StageId = 32301,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32302,
                            new StageRecord()
                            {
                                StageId = 32302,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32303,
                            new StageRecord()
                            {
                                StageId = 32303,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32304,
                            new StageRecord()
                            {
                                StageId = 32304,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32305,
                            new StageRecord()
                            {
                                StageId = 32305,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32306,
                            new StageRecord()
                            {
                                StageId = 32306,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32307,
                            new StageRecord()
                            {
                                StageId = 32307,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32308,
                            new StageRecord()
                            {
                                StageId = 32308,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32309,
                            new StageRecord()
                            {
                                StageId = 32309,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32310,
                            new StageRecord()
                            {
                                StageId = 32310,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32311,
                            new StageRecord()
                            {
                                StageId = 32311,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32312,
                            new StageRecord()
                            {
                                StageId = 32312,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32313,
                            new StageRecord()
                            {
                                StageId = 32313,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32314,
                            new StageRecord()
                            {
                                StageId = 32314,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32315,
                            new StageRecord()
                            {
                                StageId = 32315,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32316,
                            new StageRecord()
                            {
                                StageId = 32316,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32317,
                            new StageRecord()
                            {
                                StageId = 32317,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32341,
                            new StageRecord()
                            {
                                StageId = 32341,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32342,
                            new StageRecord()
                            {
                                StageId = 32342,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32343,
                            new StageRecord()
                            {
                                StageId = 32343,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32344,
                            new StageRecord()
                            {
                                StageId = 32344,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32345,
                            new StageRecord()
                            {
                                StageId = 32345,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32346,
                            new StageRecord()
                            {
                                StageId = 32346,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32361,
                            new StageRecord()
                            {
                                StageId = 32361,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32362,
                            new StageRecord()
                            {
                                StageId = 32362,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32363,
                            new StageRecord()
                            {
                                StageId = 32363,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32364,
                            new StageRecord()
                            {
                                StageId = 32364,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32365,
                            new StageRecord()
                            {
                                StageId = 32365,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32381,
                            new StageRecord()
                            {
                                StageId = 32381,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32382,
                            new StageRecord()
                            {
                                StageId = 32382,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32383,
                            new StageRecord()
                            {
                                StageId = 32383,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32384,
                            new StageRecord()
                            {
                                StageId = 32384,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32385,
                            new StageRecord()
                            {
                                StageId = 32385,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32386,
                            new StageRecord()
                            {
                                StageId = 32386,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32387,
                            new StageRecord()
                            {
                                StageId = 32387,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32401,
                            new StageRecord()
                            {
                                StageId = 32401,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32402,
                            new StageRecord()
                            {
                                StageId = 32402,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32403,
                            new StageRecord()
                            {
                                StageId = 32403,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32404,
                            new StageRecord()
                            {
                                StageId = 32404,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32405,
                            new StageRecord()
                            {
                                StageId = 32405,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32406,
                            new StageRecord()
                            {
                                StageId = 32406,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32407,
                            new StageRecord()
                            {
                                StageId = 32407,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32408,
                            new StageRecord()
                            {
                                StageId = 32408,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32409,
                            new StageRecord()
                            {
                                StageId = 32409,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32410,
                            new StageRecord()
                            {
                                StageId = 32410,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32411,
                            new StageRecord()
                            {
                                StageId = 32411,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32412,
                            new StageRecord()
                            {
                                StageId = 32412,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32413,
                            new StageRecord()
                            {
                                StageId = 32413,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32414,
                            new StageRecord()
                            {
                                StageId = 32414,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32415,
                            new StageRecord()
                            {
                                StageId = 32415,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32416,
                            new StageRecord()
                            {
                                StageId = 32416,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32441,
                            new StageRecord()
                            {
                                StageId = 32441,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32442,
                            new StageRecord()
                            {
                                StageId = 32442,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32443,
                            new StageRecord()
                            {
                                StageId = 32443,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32444,
                            new StageRecord()
                            {
                                StageId = 32444,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32445,
                            new StageRecord()
                            {
                                StageId = 32445,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32446,
                            new StageRecord()
                            {
                                StageId = 32446,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32461,
                            new StageRecord()
                            {
                                StageId = 32461,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32462,
                            new StageRecord()
                            {
                                StageId = 32462,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32463,
                            new StageRecord()
                            {
                                StageId = 32463,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32464,
                            new StageRecord()
                            {
                                StageId = 32464,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32465,
                            new StageRecord()
                            {
                                StageId = 32465,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32481,
                            new StageRecord()
                            {
                                StageId = 32481,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32482,
                            new StageRecord()
                            {
                                StageId = 32482,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32483,
                            new StageRecord()
                            {
                                StageId = 32483,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32484,
                            new StageRecord()
                            {
                                StageId = 32484,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32485,
                            new StageRecord()
                            {
                                StageId = 32485,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32486,
                            new StageRecord()
                            {
                                StageId = 32486,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32487,
                            new StageRecord()
                            {
                                StageId = 32487,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32488,
                            new StageRecord()
                            {
                                StageId = 32488,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32501,
                            new StageRecord()
                            {
                                StageId = 32501,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32502,
                            new StageRecord()
                            {
                                StageId = 32502,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32503,
                            new StageRecord()
                            {
                                StageId = 32503,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32504,
                            new StageRecord()
                            {
                                StageId = 32504,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32505,
                            new StageRecord()
                            {
                                StageId = 32505,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32506,
                            new StageRecord()
                            {
                                StageId = 32506,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32507,
                            new StageRecord()
                            {
                                StageId = 32507,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32508,
                            new StageRecord()
                            {
                                StageId = 32508,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32509,
                            new StageRecord()
                            {
                                StageId = 32509,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32541,
                            new StageRecord()
                            {
                                StageId = 32541,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32542,
                            new StageRecord()
                            {
                                StageId = 32542,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32543,
                            new StageRecord()
                            {
                                StageId = 32543,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32544,
                            new StageRecord()
                            {
                                StageId = 32544,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32545,
                            new StageRecord()
                            {
                                StageId = 32545,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32546,
                            new StageRecord()
                            {
                                StageId = 32546,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32561,
                            new StageRecord()
                            {
                                StageId = 32561,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32562,
                            new StageRecord()
                            {
                                StageId = 32562,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32563,
                            new StageRecord()
                            {
                                StageId = 32563,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32564,
                            new StageRecord()
                            {
                                StageId = 32564,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32565,
                            new StageRecord()
                            {
                                StageId = 32565,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32581,
                            new StageRecord()
                            {
                                StageId = 32581,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32582,
                            new StageRecord()
                            {
                                StageId = 32582,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32583,
                            new StageRecord()
                            {
                                StageId = 32583,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32584,
                            new StageRecord()
                            {
                                StageId = 32584,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32585,
                            new StageRecord()
                            {
                                StageId = 32585,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32586,
                            new StageRecord()
                            {
                                StageId = 32586,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33201,
                            new StageRecord()
                            {
                                StageId = 33201,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33202,
                            new StageRecord()
                            {
                                StageId = 33202,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33203,
                            new StageRecord()
                            {
                                StageId = 33203,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33204,
                            new StageRecord()
                            {
                                StageId = 33204,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33205,
                            new StageRecord()
                            {
                                StageId = 33205,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33206,
                            new StageRecord()
                            {
                                StageId = 33206,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33207,
                            new StageRecord()
                            {
                                StageId = 33207,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33208,
                            new StageRecord()
                            {
                                StageId = 33208,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33209,
                            new StageRecord()
                            {
                                StageId = 33209,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33210,
                            new StageRecord()
                            {
                                StageId = 33210,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33211,
                            new StageRecord()
                            {
                                StageId = 33211,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33212,
                            new StageRecord()
                            {
                                StageId = 33212,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33241,
                            new StageRecord()
                            {
                                StageId = 33241,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33242,
                            new StageRecord()
                            {
                                StageId = 33242,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33243,
                            new StageRecord()
                            {
                                StageId = 33243,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33244,
                            new StageRecord()
                            {
                                StageId = 33244,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33245,
                            new StageRecord()
                            {
                                StageId = 33245,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33246,
                            new StageRecord()
                            {
                                StageId = 33246,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33281,
                            new StageRecord()
                            {
                                StageId = 33281,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33282,
                            new StageRecord()
                            {
                                StageId = 33282,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33283,
                            new StageRecord()
                            {
                                StageId = 33283,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33284,
                            new StageRecord()
                            {
                                StageId = 33284,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33301,
                            new StageRecord()
                            {
                                StageId = 33301,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33302,
                            new StageRecord()
                            {
                                StageId = 33302,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33303,
                            new StageRecord()
                            {
                                StageId = 33303,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33304,
                            new StageRecord()
                            {
                                StageId = 33304,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33305,
                            new StageRecord()
                            {
                                StageId = 33305,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33306,
                            new StageRecord()
                            {
                                StageId = 33306,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33307,
                            new StageRecord()
                            {
                                StageId = 33307,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33308,
                            new StageRecord()
                            {
                                StageId = 33308,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33309,
                            new StageRecord()
                            {
                                StageId = 33309,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33341,
                            new StageRecord()
                            {
                                StageId = 33341,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33342,
                            new StageRecord()
                            {
                                StageId = 33342,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33343,
                            new StageRecord()
                            {
                                StageId = 33343,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33344,
                            new StageRecord()
                            {
                                StageId = 33344,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33345,
                            new StageRecord()
                            {
                                StageId = 33345,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33346,
                            new StageRecord()
                            {
                                StageId = 33346,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33381,
                            new StageRecord()
                            {
                                StageId = 33381,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33382,
                            new StageRecord()
                            {
                                StageId = 33382,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33383,
                            new StageRecord()
                            {
                                StageId = 33383,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33384,
                            new StageRecord()
                            {
                                StageId = 33384,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34001,
                            new StageRecord()
                            {
                                StageId = 34001,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34002,
                            new StageRecord()
                            {
                                StageId = 34002,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34003,
                            new StageRecord()
                            {
                                StageId = 34003,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34004,
                            new StageRecord()
                            {
                                StageId = 34004,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34005,
                            new StageRecord()
                            {
                                StageId = 34005,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34006,
                            new StageRecord()
                            {
                                StageId = 34006,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34007,
                            new StageRecord()
                            {
                                StageId = 34007,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34008,
                            new StageRecord()
                            {
                                StageId = 34008,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34009,
                            new StageRecord()
                            {
                                StageId = 34009,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34010,
                            new StageRecord()
                            {
                                StageId = 34010,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34041,
                            new StageRecord()
                            {
                                StageId = 34041,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34042,
                            new StageRecord()
                            {
                                StageId = 34042,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34043,
                            new StageRecord()
                            {
                                StageId = 34043,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34044,
                            new StageRecord()
                            {
                                StageId = 34044,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34045,
                            new StageRecord()
                            {
                                StageId = 34045,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34046,
                            new StageRecord()
                            {
                                StageId = 34046,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34081,
                            new StageRecord()
                            {
                                StageId = 34081,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34082,
                            new StageRecord()
                            {
                                StageId = 34082,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34083,
                            new StageRecord()
                            {
                                StageId = 34083,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34084,
                            new StageRecord()
                            {
                                StageId = 34084,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34085,
                            new StageRecord()
                            {
                                StageId = 34085,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34086,
                            new StageRecord()
                            {
                                StageId = 34086,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34087,
                            new StageRecord()
                            {
                                StageId = 34087,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34088,
                            new StageRecord()
                            {
                                StageId = 34088,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34089,
                            new StageRecord()
                            {
                                StageId = 34089,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34090,
                            new StageRecord()
                            {
                                StageId = 34090,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34101,
                            new StageRecord()
                            {
                                StageId = 34101,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34102,
                            new StageRecord()
                            {
                                StageId = 34102,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34103,
                            new StageRecord()
                            {
                                StageId = 34103,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34104,
                            new StageRecord()
                            {
                                StageId = 34104,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34105,
                            new StageRecord()
                            {
                                StageId = 34105,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34106,
                            new StageRecord()
                            {
                                StageId = 34106,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34107,
                            new StageRecord()
                            {
                                StageId = 34107,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34108,
                            new StageRecord()
                            {
                                StageId = 34108,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34109,
                            new StageRecord()
                            {
                                StageId = 34109,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34110,
                            new StageRecord()
                            {
                                StageId = 34110,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34111,
                            new StageRecord()
                            {
                                StageId = 34111,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34112,
                            new StageRecord()
                            {
                                StageId = 34112,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34113,
                            new StageRecord()
                            {
                                StageId = 34113,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34114,
                            new StageRecord()
                            {
                                StageId = 34114,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34141,
                            new StageRecord()
                            {
                                StageId = 34141,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34142,
                            new StageRecord()
                            {
                                StageId = 34142,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34143,
                            new StageRecord()
                            {
                                StageId = 34143,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34144,
                            new StageRecord()
                            {
                                StageId = 34144,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34145,
                            new StageRecord()
                            {
                                StageId = 34145,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34146,
                            new StageRecord()
                            {
                                StageId = 34146,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34181,
                            new StageRecord()
                            {
                                StageId = 34181,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34182,
                            new StageRecord()
                            {
                                StageId = 34182,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34183,
                            new StageRecord()
                            {
                                StageId = 34183,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34184,
                            new StageRecord()
                            {
                                StageId = 34184,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34185,
                            new StageRecord()
                            {
                                StageId = 34185,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            34186,
                            new StageRecord()
                            {
                                StageId = 34186,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            340901,
                            new StageRecord()
                            {
                                StageId = 340901,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            340902,
                            new StageRecord()
                            {
                                StageId = 340902,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        },
                        });
                        break;
                    }
                case 20:
                    {
                        connection.Send(0, new SC_StageRecord()
                        {
                            Record = null,
                            Records = { },
                        });
                        break;
                    }
                case 21:
                    {
                        connection.Send(0, new SC_StageRecord
                        {
                            Record = null,
                            Records =
                        {
                        {
                            26201,
                            new StageRecord()
                            {
                                StageId = 26201,
                                FirstPassTime = 1729507115,
                                CompleteChallenges = 7,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 268,
                                MCDNPPCAFOK = true,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        },
                        });
                        break;
                    }
                case 22:
                    {
                        connection.Send(0, new SC_StageRecord()
                        {
                            Record = null,
                            Records = { },
                        });
                        break;
                    }
                case 26:
                    {
                        connection.Send(0, new SC_StageRecord()
                        {
                            Record = null,
                            Records = { },
                        });
                        break;
                    }
                case 31:
                    {
                        connection.Send(0, new SC_StageRecord()
                        {
                            Record = null,
                            Records = { },
                        });
                        break;
                    }
                case 32:
                    {
                        connection.Send(0, new SC_StageRecord()
                        {
                            Record = null,
                            Records = { },
                        });
                        break;
                    }
                case 33:
                    {
                        connection.Send(0, new SC_StageRecord()
                        {
                            Record = null,
                            Records = { },
                        });
                        break;
                    }
                case 36:
                    {
                        connection.Send(1, new SC_StageRecord
                        {
                            Record = null,
                            Records =
                        {
                        {
                            31691,
                            new StageRecord()
                            {
                                StageId = 31691,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31692,
                            new StageRecord()
                            {
                                StageId = 31692,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31693,
                            new StageRecord()
                            {
                                StageId = 31693,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31694,
                            new StageRecord()
                            {
                                StageId = 31694,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31695,
                            new StageRecord()
                            {
                                StageId = 31695,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31891,
                            new StageRecord()
                            {
                                StageId = 31891,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31892,
                            new StageRecord()
                            {
                                StageId = 31892,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31893,
                            new StageRecord()
                            {
                                StageId = 31893,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31894,
                            new StageRecord()
                            {
                                StageId = 31894,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            31895,
                            new StageRecord()
                            {
                                StageId = 31895,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32091,
                            new StageRecord()
                            {
                                StageId = 32091,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32092,
                            new StageRecord()
                            {
                                StageId = 32092,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32093,
                            new StageRecord()
                            {
                                StageId = 32093,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32094,
                            new StageRecord()
                            {
                                StageId = 32094,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32095,
                            new StageRecord()
                            {
                                StageId = 32095,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32491,
                            new StageRecord()
                            {
                                StageId = 32491,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32492,
                            new StageRecord()
                            {
                                StageId = 32492,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32493,
                            new StageRecord()
                            {
                                StageId = 32493,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32494,
                            new StageRecord()
                            {
                                StageId = 32494,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32495,
                            new StageRecord()
                            {
                                StageId = 32495,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32691,
                            new StageRecord()
                            {
                                StageId = 32691,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32692,
                            new StageRecord()
                            {
                                StageId = 32692,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32693,
                            new StageRecord()
                            {
                                StageId = 32693,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32694,
                            new StageRecord()
                            {
                                StageId = 32694,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32695,
                            new StageRecord()
                            {
                                StageId = 32695,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32891,
                            new StageRecord()
                            {
                                StageId = 32891,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32892,
                            new StageRecord()
                            {
                                StageId = 32892,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32893,
                            new StageRecord()
                            {
                                StageId = 32893,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32894,
                            new StageRecord()
                            {
                                StageId = 32894,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            32895,
                            new StageRecord()
                            {
                                StageId = 32895,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33091,
                            new StageRecord()
                            {
                                StageId = 33091,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33092,
                            new StageRecord()
                            {
                                StageId = 33092,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33093,
                            new StageRecord()
                            {
                                StageId = 33093,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33094,
                            new StageRecord()
                            {
                                StageId = 33094,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33095,
                            new StageRecord()
                            {
                                StageId = 33095,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33291,
                            new StageRecord()
                            {
                                StageId = 33291,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33292,
                            new StageRecord()
                            {
                                StageId = 33292,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33293,
                            new StageRecord()
                            {
                                StageId = 33293,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33294,
                            new StageRecord()
                            {
                                StageId = 33294,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        {
                            33295,
                            new StageRecord()
                            {
                                StageId = 33295,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        },
                        });
                        break;
                    }
                case 41:
                    {
                        connection.Send(0, new SC_StageRecord()
                        {
                            Record = null,
                            Records = { },
                        });
                        break;
                    }
                case 50:
                    {
                        connection.Send(0, new SC_StageRecord()
                        {
                            Record = null,
                            Records = { },
                        });
                        break;
                    }
                case 52:
                    {
                        connection.Send(0, new SC_StageRecord()
                        {
                            Record = null,
                            Records = { },
                        });
                        break;
                    }
                case 54:
                    {
                        connection.Send(0, new SC_StageRecord()
                        {
                            Record = null,
                            Records = { },
                        });
                        break;
                    }
                case 59:
                    {
                        connection.Send(0, new SC_StageRecord
                        {
                            Record = null,
                            Records =
                        {
                        {
                            31987,
                            new StageRecord()
                            {
                                StageId = 31987,
                                FirstPassTime = 0,
                                CompleteChallenges = 0,
                                NOAHEPNBHPG = false,
                                HKEGGELDDEP = 0,
                                MCDNPPCAFOK = false,
                                BEGDAIAHIBG = 0,
                                CKEMELBKBNE = false,
                            }
                        },
                        },
                        });
                        break;
                    }
                case 63:
                    {
                        connection.Send(0, new SC_StageRecord()
                        {
                            Record = null,
                            Records = { },
                        });
                        break;
                    }
                case 64:
                    {
                        connection.Send(0, new SC_StageRecord()
                        {
                            Record = null,
                            Records = { },
                        });
                        break;
                    }
            }
        }
    }
}
