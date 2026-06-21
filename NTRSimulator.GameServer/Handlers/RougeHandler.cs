using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class RougeHandler : RougeHandlerBase
    {
        public override void HandleRougeAllPlans(CS_RougeAllPlans request, Connection connection)
        {
                    connection.Send(new SC_RougeAllPlans
                    {
                        Field1 =
                        {
                            [600004] = true,
                            [600003] = true,
                            [600002] = true,
                        },
                    });
        }

        public override void HandleGetRougeInfo(CS_GetRougeInfo request, Connection connection)
        {
            

                    switch (request.Field1)
                    {
                        case 600002:
                            connection.Send(new SC_GetRougeInfo
                            {
                                Field1 = new SC_GetRougeInfo_F1Type
                                {
                                    Field1 = 600002,
                                    Field2 = 2,
                                    Field3 = 0,
                                    Field4 = 0,
                                    Field5 = 0,
                                    Field9 = { },
                                    Field10 = { },
                                    Field11 = { },
                                    Field12 = { },
                                    Field13 = { 55, 67, 68, 74, 82, 83, 90, 51, 61, 76, 52, 58, 72, 78, 84, 85, 87, 53, 57, 59, 65, 50, 60, 63, 75, 77, 79, 81, 49, 69, 70, 71, 73, 80, 89, 54, 62, 64, 66, 86, 88, 56 },
                                    Field15 = 0,
                                    Field16 = { },
                                    Field17 = { },
                                    Field18 = 0,
                                    Field19 = false,
                                    Field20 = 0,
                                    Field21 = 0,
                                    Field22 = { },
                                    Field23 = 0,
                                },
                            });
                            break;
                        case 600003:
                            connection.Send(new SC_GetRougeInfo
                            {
                                Field1 = new SC_GetRougeInfo_F1Type
                                {
                                    Field1 = 600003,
                                    Field2 = 3,
                                    Field3 = 0,
                                    Field4 = 0,
                                    Field5 = 0,
                                    Field9 = { },
                                    Field10 = { },
                                    Field11 = { },
                                    Field12 = { },
                                    Field13 = { 93, 101, 102, 116, 120, 132, 91, 95, 111, 113, 112, 125, 96, 97, 108, 109, 121, 123, 128, 104, 107, 115, 117, 129, 98, 99, 118, 122, 126, 131, 92, 106, 114, 119, 94, 127, 130, 124, 100, 103, 105, 110 },
                                    Field15 = 0,
                                    Field16 = { },
                                    Field17 = { },
                                    Field18 = 0,
                                    Field19 = false,
                                    Field20 = 0,
                                    Field21 = 0,
                                    Field22 = { },
                                    Field23 = 0,
                                },
                            });
                            break;
                    }
        }

        public override void HandleGetRougeMapInfo(CS_GetRougeMapInfo request, Connection connection)
        {
            

                    switch (request.Field1)
                    {
                        case 600002:
                            connection.Send(new SC_GetRougeMapInfo
                            {
                                Field1 = null,
                                Field2 = 600002,
                            });
                            break;
                        case 600003:
                            connection.Send(new SC_GetRougeMapInfo
                            {
                                Field1 = null,
                                Field2 = 600003,
                            });
                            break;
                    }
        }

        public override void HandleRougeSeasonInfo(CS_RougeSeasonInfo request, Connection connection)
        {
                    connection.Send(new SC_RougeSeasonInfo
                    {
                        Field1 = 600004,
                        Field2 = new SC_RougeSeasonInfo_F2Type
                        {
                            Field1 = 4,
                            Field2 = { },
                            Field3 = { },
                            Field4 = { },
                            Field5 = { },
                            Field7 = 0,
                            Field8 = 0,
                            Field9 = 0,
                            Field10 = 0,
                            Field11 = 0,
                            Field12 = 0,
                            Field13 = false,
                        },
                    });
        }
    }
}
