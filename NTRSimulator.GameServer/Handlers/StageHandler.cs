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
            switch (request.Field2)
            {
                case 11:
                    {
                        connection.Send(1, new SC_StageRecord
                        {
                            Field1 = null,
                            Field2 =
                        {
                        {
                            10104,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 10104,
                                Field2 = 1703900906,
                                Field4 = 7,
                                Field5 = false,
                                Field6 = 1,
                                Field7 = true,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            10105,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 10105,
                                Field2 = 1703901048,
                                Field4 = 7,
                                Field5 = false,
                                Field6 = 1,
                                Field7 = true,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            10106,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 10106,
                                Field2 = 1703901190,
                                Field4 = 7,
                                Field5 = false,
                                Field6 = 1,
                                Field7 = true,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            10107,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 10107,
                                Field2 = 1728667765,
                                Field4 = 7,
                                Field5 = false,
                                Field6 = 1,
                                Field7 = true,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            10108,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 10108,
                                Field2 = 1728668071,
                                Field4 = 7,
                                Field5 = false,
                                Field6 = 1,
                                Field7 = true,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            10109,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 10109,
                                Field2 = 1728668217,
                                Field4 = 7,
                                Field5 = false,
                                Field6 = 1,
                                Field7 = true,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            10110,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 10110,
                                Field2 = 1728668611,
                                Field4 = 7,
                                Field5 = false,
                                Field6 = 1,
                                Field7 = true,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            10141,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 10141,
                                Field2 = 1728667617,
                                Field4 = 7,
                                Field5 = false,
                                Field6 = 1,
                                Field7 = true,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            10142,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 10142,
                                Field2 = 1728667936,
                                Field4 = 7,
                                Field5 = false,
                                Field6 = 1,
                                Field7 = true,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            10143,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 10143,
                                Field2 = 1728668327,
                                Field4 = 7,
                                Field5 = false,
                                Field6 = 1,
                                Field7 = true,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            10183,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 10183,
                                Field2 = 1703901077,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 1,
                                Field7 = true,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            10184,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 10184,
                                Field2 = 1703901217,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 1,
                                Field7 = true,
                                Field8 = 0,
                                Field9 = false,
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
                            Field1 = null,
                            Field2 =
                        {
                        {
                            10101,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 10101,
                                Field2 = 1703900194,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 1,
                                Field7 = true,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            10102,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 10102,
                                Field2 = 1703900349,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 1,
                                Field7 = true,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            10103,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 10103,
                                Field2 = 1703900704,
                                Field4 = 7,
                                Field5 = false,
                                Field6 = 1,
                                Field7 = true,
                                Field8 = 0,
                                Field9 = false,
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
                            Field1 = null,
                            Field2 =
                        {
                        {
                            10001,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 10001,
                                Field2 = 1703592371,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 1,
                                Field7 = true,
                                Field8 = 0,
                                Field9 = false,
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
                            Field1 = null,
                            Field2 =
                        {
                        {
                            30101,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30101,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30102,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30102,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30103,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30103,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30104,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30104,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30105,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30105,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30301,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30301,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30302,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30302,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30303,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30303,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30304,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30304,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30305,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30305,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30306,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30306,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30307,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30307,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30308,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30308,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30309,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30309,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30311,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30311,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30312,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30312,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30313,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30313,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30314,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30314,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30315,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30315,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30316,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30316,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30381,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30381,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30382,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30382,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30401,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30401,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30402,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30402,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30403,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30403,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30404,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30404,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30405,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30405,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30406,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30406,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30407,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30407,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30408,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30408,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30409,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30409,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30461,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30461,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30462,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30462,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30463,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30463,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30464,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30464,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30465,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30465,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30486,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30486,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30501,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30501,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30502,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30502,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30503,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30503,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30504,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30504,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30505,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30505,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30506,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30506,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30507,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30507,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30508,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30508,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30509,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30509,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30541,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30541,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30542,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30542,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30543,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30543,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30544,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30544,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30545,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30545,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30546,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30546,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30561,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30561,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30562,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30562,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30563,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30563,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30564,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30564,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30565,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30565,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30586,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30586,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30587,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30587,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30701,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30701,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30702,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30702,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30703,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30703,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30704,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30704,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30705,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30705,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30706,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30706,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30707,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30707,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30708,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30708,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30709,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30709,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30761,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30761,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30762,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30762,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30763,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30763,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30764,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30764,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30765,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30765,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30786,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30786,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30787,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30787,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30788,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30788,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30801,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30801,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30802,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30802,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30803,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30803,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30804,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30804,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30805,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30805,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30806,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30806,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30807,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30807,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30808,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30808,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30809,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30809,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30841,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30841,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30842,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30842,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30843,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30843,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30844,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30844,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30845,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30845,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30846,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30846,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30861,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30861,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30862,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30862,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30863,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30863,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30864,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30864,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30865,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30865,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30881,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30881,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30882,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30882,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30901,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30901,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30902,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30902,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30903,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30903,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30904,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30904,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30905,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30905,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30906,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30906,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30907,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30907,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30908,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30908,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30909,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30909,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30910,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30910,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30941,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30941,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30942,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30942,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30943,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30943,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30944,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30944,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30945,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30945,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30946,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30946,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30961,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30961,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30962,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30962,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30963,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30963,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30964,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30964,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30965,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30965,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30981,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30981,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30982,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30982,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            30983,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 30983,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31001,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31001,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31002,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31002,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31003,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31003,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31004,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31004,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31005,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31005,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31006,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31006,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31007,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31007,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31008,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31008,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31009,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31009,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31041,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31041,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31042,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31042,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31043,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31043,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31044,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31044,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31045,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31045,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31046,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31046,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31061,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31061,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31062,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31062,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31063,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31063,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31064,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31064,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31065,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31065,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31081,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31081,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31082,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31082,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31101,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31101,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31102,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31102,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31103,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31103,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31104,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31104,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31105,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31105,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31106,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31106,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31107,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31107,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31108,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31108,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31109,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31109,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31161,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31161,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31162,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31162,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31163,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31163,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31164,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31164,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31165,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31165,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31181,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31181,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31201,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31201,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31202,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31202,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31203,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31203,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31204,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31204,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31205,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31205,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31206,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31206,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31207,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31207,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31208,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31208,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31209,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31209,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31261,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31261,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31262,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31262,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31263,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31263,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31264,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31264,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31265,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31265,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31281,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31281,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31282,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31282,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31283,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31283,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31301,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31301,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31302,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31302,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31303,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31303,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31304,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31304,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31305,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31305,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31306,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31306,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31307,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31307,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31308,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31308,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31309,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31309,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31310,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31310,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31341,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31341,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31342,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31342,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31343,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31343,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31344,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31344,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31345,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31345,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31346,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31346,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31361,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31361,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31362,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31362,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31363,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31363,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31364,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31364,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31365,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31365,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31381,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31381,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31382,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31382,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31383,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31383,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31384,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31384,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31401,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31401,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31402,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31402,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31403,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31403,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31404,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31404,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31405,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31405,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31406,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31406,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31407,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31407,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31408,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31408,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31409,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31409,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31410,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31410,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31411,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31411,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31441,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31441,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31442,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31442,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31443,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31443,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31444,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31444,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31445,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31445,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31461,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31461,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31462,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31462,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31463,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31463,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31464,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31464,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31465,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31465,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31481,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31481,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31482,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31482,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31483,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31483,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31484,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31484,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31485,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31485,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31486,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31486,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31501,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31501,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31502,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31502,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31503,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31503,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31504,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31504,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31505,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31505,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31506,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31506,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31507,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31507,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31508,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31508,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31509,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31509,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31561,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31561,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31562,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31562,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31563,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31563,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31564,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31564,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31565,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31565,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31581,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31581,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31582,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31582,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31601,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31601,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31602,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31602,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31603,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31603,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31604,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31604,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31605,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31605,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31606,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31606,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31607,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31607,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31608,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31608,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31609,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31609,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31661,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31661,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31662,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31662,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31663,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31663,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31664,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31664,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31665,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31665,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31681,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31681,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31682,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31682,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31683,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31683,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31684,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31684,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31685,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31685,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31701,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31701,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31702,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31702,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31703,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31703,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31704,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31704,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31705,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31705,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31706,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31706,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31707,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31707,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31708,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31708,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31709,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31709,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31761,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31761,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31762,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31762,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31763,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31763,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31764,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31764,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31765,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31765,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31781,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31781,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31782,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31782,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31783,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31783,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31784,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31784,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31785,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31785,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31786,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31786,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31801,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31801,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31802,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31802,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31803,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31803,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31804,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31804,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31805,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31805,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31806,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31806,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31807,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31807,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31808,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31808,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31809,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31809,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31810,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31810,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31811,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31811,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31841,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31841,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31842,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31842,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31843,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31843,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31844,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31844,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31845,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31845,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31846,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31846,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31861,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31861,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31862,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31862,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31863,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31863,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31864,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31864,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31865,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31865,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31881,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31881,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31882,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31882,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31883,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31883,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31884,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31884,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31901,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31901,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31902,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31902,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31903,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31903,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31904,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31904,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31905,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31905,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31906,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31906,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31907,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31907,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31908,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31908,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31909,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31909,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31910,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31910,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31911,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31911,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31941,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31941,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31942,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31942,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31943,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31943,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31944,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31944,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31945,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31945,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31946,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31946,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31961,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31961,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31962,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31962,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31963,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31963,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31964,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31964,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31965,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31965,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31981,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31981,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31982,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31982,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31983,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31983,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31984,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31984,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31985,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31985,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31986,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31986,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31988,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31988,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31989,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31989,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32001,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32001,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32002,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32002,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32003,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32003,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32004,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32004,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32005,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32005,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32006,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32006,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32007,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32007,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32008,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32008,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32009,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32009,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32041,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32041,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32042,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32042,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32043,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32043,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32044,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32044,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32045,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32045,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32046,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32046,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32061,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32061,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32062,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32062,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32063,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32063,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32064,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32064,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32065,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32065,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32081,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32081,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32082,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32082,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32083,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32083,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32084,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32084,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32085,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32085,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32086,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32086,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32101,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32101,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32102,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32102,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32103,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32103,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32104,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32104,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32105,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32105,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32106,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32106,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32107,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32107,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32108,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32108,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32109,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32109,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32141,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32141,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32142,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32142,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32143,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32143,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32144,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32144,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32145,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32145,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32146,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32146,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32161,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32161,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32162,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32162,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32163,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32163,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32164,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32164,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32165,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32165,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32181,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32181,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32182,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32182,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32183,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32183,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32184,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32184,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32185,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32185,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32186,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32186,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32187,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32187,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32188,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32188,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32201,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32201,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32202,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32202,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32203,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32203,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32204,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32204,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32205,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32205,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32206,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32206,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32207,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32207,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32208,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32208,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32209,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32209,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32241,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32241,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32242,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32242,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32243,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32243,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32244,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32244,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32245,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32245,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32246,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32246,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32261,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32261,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32262,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32262,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32263,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32263,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32264,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32264,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32265,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32265,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32281,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32281,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32282,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32282,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32283,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32283,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32284,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32284,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32301,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32301,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32302,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32302,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32303,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32303,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32304,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32304,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32305,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32305,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32306,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32306,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32307,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32307,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32308,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32308,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32309,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32309,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32310,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32310,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32311,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32311,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32312,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32312,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32313,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32313,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32314,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32314,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32315,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32315,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32316,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32316,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32317,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32317,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32341,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32341,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32342,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32342,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32343,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32343,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32344,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32344,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32345,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32345,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32346,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32346,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32361,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32361,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32362,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32362,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32363,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32363,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32364,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32364,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32365,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32365,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32381,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32381,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32382,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32382,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32383,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32383,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32384,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32384,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32385,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32385,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32386,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32386,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32387,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32387,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32401,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32401,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32402,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32402,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32403,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32403,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32404,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32404,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32405,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32405,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32406,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32406,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32407,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32407,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32408,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32408,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32409,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32409,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32410,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32410,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32411,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32411,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32412,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32412,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32413,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32413,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32414,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32414,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32415,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32415,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32416,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32416,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32441,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32441,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32442,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32442,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32443,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32443,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32444,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32444,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32445,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32445,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32446,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32446,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32461,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32461,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32462,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32462,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32463,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32463,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32464,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32464,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32465,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32465,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32481,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32481,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32482,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32482,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32483,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32483,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32484,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32484,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32485,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32485,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32486,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32486,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32487,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32487,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32488,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32488,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32501,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32501,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32502,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32502,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32503,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32503,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32504,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32504,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32505,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32505,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32506,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32506,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32507,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32507,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32508,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32508,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32509,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32509,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32541,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32541,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32542,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32542,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32543,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32543,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32544,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32544,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32545,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32545,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32546,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32546,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32561,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32561,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32562,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32562,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32563,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32563,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32564,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32564,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32565,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32565,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32581,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32581,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32582,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32582,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32583,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32583,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32584,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32584,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32585,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32585,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32586,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32586,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33201,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33201,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33202,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33202,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33203,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33203,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33204,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33204,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33205,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33205,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33206,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33206,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33207,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33207,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33208,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33208,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33209,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33209,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33210,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33210,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33211,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33211,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33212,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33212,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33241,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33241,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33242,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33242,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33243,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33243,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33244,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33244,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33245,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33245,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33246,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33246,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33281,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33281,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33282,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33282,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33283,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33283,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33284,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33284,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33301,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33301,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33302,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33302,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33303,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33303,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33304,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33304,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33305,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33305,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33306,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33306,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33307,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33307,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33308,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33308,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33309,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33309,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33341,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33341,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33342,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33342,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33343,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33343,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33344,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33344,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33345,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33345,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33346,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33346,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33381,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33381,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33382,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33382,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33383,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33383,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33384,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33384,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34001,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34001,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34002,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34002,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34003,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34003,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34004,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34004,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34005,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34005,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34006,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34006,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34007,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34007,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34008,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34008,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34009,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34009,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34010,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34010,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34041,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34041,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34042,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34042,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34043,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34043,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34044,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34044,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34045,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34045,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34046,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34046,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34081,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34081,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34082,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34082,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34083,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34083,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34084,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34084,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34085,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34085,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34086,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34086,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34087,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34087,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34088,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34088,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34089,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34089,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34090,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34090,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34101,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34101,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34102,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34102,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34103,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34103,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34104,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34104,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34105,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34105,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34106,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34106,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34107,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34107,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34108,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34108,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34109,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34109,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34110,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34110,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34111,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34111,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34112,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34112,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34113,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34113,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34114,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34114,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34141,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34141,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34142,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34142,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34143,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34143,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34144,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34144,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34145,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34145,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34146,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34146,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34181,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34181,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34182,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34182,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34183,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34183,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34184,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34184,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34185,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34185,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            34186,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 34186,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            340901,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 340901,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            340902,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 340902,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
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
                            Field1 = null,
                            Field2 = { },
                        });
                        break;
                    }
                case 21:
                    {
                        connection.Send(0, new SC_StageRecord
                        {
                            Field1 = null,
                            Field2 =
                        {
                        {
                            26201,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 26201,
                                Field2 = 1729507115,
                                Field4 = 7,
                                Field5 = false,
                                Field6 = 268,
                                Field7 = true,
                                Field8 = 0,
                                Field9 = false,
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
                            Field1 = null,
                            Field2 = { },
                        });
                        break;
                    }
                case 26:
                    {
                        connection.Send(0, new SC_StageRecord()
                        {
                            Field1 = null,
                            Field2 = { },
                        });
                        break;
                    }
                case 31:
                    {
                        connection.Send(0, new SC_StageRecord()
                        {
                            Field1 = null,
                            Field2 = { },
                        });
                        break;
                    }
                case 32:
                    {
                        connection.Send(0, new SC_StageRecord()
                        {
                            Field1 = null,
                            Field2 = { },
                        });
                        break;
                    }
                case 33:
                    {
                        connection.Send(0, new SC_StageRecord()
                        {
                            Field1 = null,
                            Field2 = { },
                        });
                        break;
                    }
                case 36:
                    {
                        connection.Send(1, new SC_StageRecord
                        {
                            Field1 = null,
                            Field2 =
                        {
                        {
                            31691,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31691,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31692,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31692,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31693,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31693,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31694,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31694,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31695,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31695,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31891,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31891,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31892,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31892,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31893,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31893,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31894,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31894,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            31895,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31895,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32091,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32091,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32092,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32092,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32093,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32093,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32094,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32094,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32095,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32095,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32491,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32491,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32492,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32492,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32493,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32493,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32494,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32494,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32495,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32495,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32691,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32691,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32692,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32692,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32693,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32693,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32694,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32694,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32695,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32695,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32891,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32891,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32892,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32892,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32893,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32893,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32894,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32894,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            32895,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 32895,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33091,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33091,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33092,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33092,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33093,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33093,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33094,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33094,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33095,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33095,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33291,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33291,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33292,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33292,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33293,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33293,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33294,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33294,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
                            }
                        },
                        {
                            33295,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 33295,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
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
                            Field1 = null,
                            Field2 = { },
                        });
                        break;
                    }
                case 50:
                    {
                        connection.Send(0, new SC_StageRecord()
                        {
                            Field1 = null,
                            Field2 = { },
                        });
                        break;
                    }
                case 52:
                    {
                        connection.Send(0, new SC_StageRecord()
                        {
                            Field1 = null,
                            Field2 = { },
                        });
                        break;
                    }
                case 54:
                    {
                        connection.Send(0, new SC_StageRecord()
                        {
                            Field1 = null,
                            Field2 = { },
                        });
                        break;
                    }
                case 59:
                    {
                        connection.Send(0, new SC_StageRecord
                        {
                            Field1 = null,
                            Field2 =
                        {
                        {
                            31987,
                            new SC_StageRecord_F1Type()
                            {
                                Field1 = 31987,
                                Field2 = 0,
                                Field4 = 0,
                                Field5 = false,
                                Field6 = 0,
                                Field7 = false,
                                Field8 = 0,
                                Field9 = false,
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
                            Field1 = null,
                            Field2 = { },
                        });
                        break;
                    }
                case 64:
                    {
                        connection.Send(0, new SC_StageRecord()
                        {
                            Field1 = null,
                            Field2 = { },
                        });
                        break;
                    }
            }
        }
    }
}
