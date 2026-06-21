using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class SupportHandler : SupportHandlerBase
    {
        public override void HandleSupportRoomInfo(CS_SupportRoomInfo request, Connection connection)
        {
                    connection.Send(1, new SC_SupportRoomInfo
                    {
                        Field1 = new SC_SupportRoomInfo_F1Type
                        {
                            Field1 =
                    {
                        new CS_StageInto_F11Type
                        {
                            Field1 = "",
                            Field2 =
                            {
                                new CS_StageInto_F11Type_F2Type
                                {
                                    Field1 = 0,
                                    Field2 = 0,
                                    Field3 =
                                    {
                                    },
                                },
                                new CS_StageInto_F11Type_F2Type
                                {
                                    Field1 = 0,
                                    Field2 = 0,
                                    Field3 =
                                    {
                                    },
                                },
                                new CS_StageInto_F11Type_F2Type
                                {
                                    Field1 = 0,
                                    Field2 = 0,
                                    Field3 =
                                    {
                                    },
                                },
                            },
                            Field3 =
                            {
                                [3] = 20,
                                [4] = 20,
                                [5] = 20,
                                [6] = 20,
                                [1] = 20,
                                [2] = 20,
                            },
                            Field4 = 0,
                            Field5 =
                            {
                            },
                            Field6 =
                            {
                            },
                        },
                        new CS_StageInto_F11Type
                        {
                            Field1 = "",
                            Field2 =
                            {
                                new CS_StageInto_F11Type_F2Type
                                {
                                    Field1 = 0,
                                    Field2 = 0,
                                    Field3 =
                                    {
                                    },
                                },
                                new CS_StageInto_F11Type_F2Type
                                {
                                    Field1 = 0,
                                    Field2 = 0,
                                    Field3 =
                                    {
                                    },
                                },
                                new CS_StageInto_F11Type_F2Type
                                {
                                    Field1 = 0,
                                    Field2 = 0,
                                    Field3 =
                                    {
                                    },
                                },
                            },
                            Field3 =
                            {
                                [6] = 20,
                                [1] = 20,
                                [2] = 20,
                                [3] = 20,
                                [4] = 20,
                                [5] = 20,
                            },
                            Field4 = 0,
                            Field5 =
                            {
                            },
                            Field6 =
                            {
                            },
                        },
                        new CS_StageInto_F11Type
                        {
                            Field1 = "",
                            Field2 =
                            {
                                new CS_StageInto_F11Type_F2Type
                                {
                                    Field1 = 0,
                                    Field2 = 0,
                                    Field3 =
                                    {
                                    },
                                },
                                new CS_StageInto_F11Type_F2Type
                                {
                                    Field1 = 0,
                                    Field2 = 0,
                                    Field3 =
                                    {
                                    },
                                },
                                new CS_StageInto_F11Type_F2Type
                                {
                                    Field1 = 0,
                                    Field2 = 0,
                                    Field3 =
                                    {
                                    },
                                },
                            },
                            Field3 =
                            {
                                [1] = 20,
                                [2] = 20,
                                [3] = 20,
                                [4] = 20,
                                [5] = 20,
                                [6] = 20,
                            },
                            Field4 = 0,
                            Field5 =
                            {
                            },
                            Field6 =
                            {
                            },
                        },
                        new CS_StageInto_F11Type
                        {
                            Field1 = "",
                            Field2 =
                            {
                                new CS_StageInto_F11Type_F2Type
                                {
                                    Field1 = 0,
                                    Field2 = 0,
                                    Field3 =
                                    {
                                    },
                                },
                                new CS_StageInto_F11Type_F2Type
                                {
                                    Field1 = 0,
                                    Field2 = 0,
                                    Field3 =
                                    {
                                    },
                                },
                                new CS_StageInto_F11Type_F2Type
                                {
                                    Field1 = 0,
                                    Field2 = 0,
                                    Field3 =
                                    {
                                    },
                                },
                            },
                            Field3 =
                            {
                                [2] = 20,
                                [3] = 20,
                                [4] = 20,
                                [5] = 20,
                                [6] = 20,
                                [1] = 20,
                            },
                            Field4 = 0,
                            Field5 =
                            {
                            },
                            Field6 =
                            {
                            },
                        },
                        new CS_StageInto_F11Type
                        {
                            Field1 = "",
                            Field2 =
                            {
                                new CS_StageInto_F11Type_F2Type
                                {
                                    Field1 = 0,
                                    Field2 = 0,
                                    Field3 =
                                    {
                                    },
                                },
                                new CS_StageInto_F11Type_F2Type
                                {
                                    Field1 = 0,
                                    Field2 = 0,
                                    Field3 =
                                    {
                                    },
                                },
                                new CS_StageInto_F11Type_F2Type
                                {
                                    Field1 = 0,
                                    Field2 = 0,
                                    Field3 =
                                    {
                                    },
                                },
                            },
                            Field3 =
                            {
                                [4] = 20,
                                [5] = 20,
                                [6] = 20,
                                [1] = 20,
                                [2] = 20,
                                [3] = 20,
                            },
                            Field4 = 0,
                            Field5 =
                            {
                            },
                            Field6 =
                            {
                            },
                        },
                        new CS_StageInto_F11Type
                        {
                            Field1 = "",
                            Field2 =
                            {
                                new CS_StageInto_F11Type_F2Type
                                {
                                    Field1 = 0,
                                    Field2 = 0,
                                    Field3 =
                                    {
                                    },
                                },
                                new CS_StageInto_F11Type_F2Type
                                {
                                    Field1 = 0,
                                    Field2 = 0,
                                    Field3 =
                                    {
                                    },
                                },
                                new CS_StageInto_F11Type_F2Type
                                {
                                    Field1 = 0,
                                    Field2 = 0,
                                    Field3 =
                                    {
                                    },
                                },
                            },
                            Field3 =
                            {
                                [4] = 20,
                                [5] = 20,
                                [6] = 20,
                                [1] = 20,
                                [2] = 20,
                                [3] = 20,
                            },
                            Field4 = 0,
                            Field5 =
                            {
                            },
                            Field6 =
                            {
                            },
                        },
                        new CS_StageInto_F11Type
                        {
                            Field1 = "",
                            Field2 =
                            {
                                new CS_StageInto_F11Type_F2Type
                                {
                                    Field1 = 0,
                                    Field2 = 0,
                                    Field3 =
                                    {
                                    },
                                },
                                new CS_StageInto_F11Type_F2Type
                                {
                                    Field1 = 0,
                                    Field2 = 0,
                                    Field3 =
                                    {
                                    },
                                },
                                new CS_StageInto_F11Type_F2Type
                                {
                                    Field1 = 0,
                                    Field2 = 0,
                                    Field3 =
                                    {
                                    },
                                },
                            },
                            Field3 =
                            {
                                [2] = 20,
                                [3] = 20,
                                [4] = 20,
                                [5] = 20,
                                [6] = 20,
                                [1] = 20,
                            },
                            Field4 = 0,
                            Field5 =
                            {
                            },
                            Field6 =
                            {
                            },
                        },
                    },
                            Field2 = 1,
                            Field8 =
                    {
                    },
                            Field9 = 1,
                        },
                    });
        }

        public override void HandleSupportTeams(CS_SupportTeams request, Connection connection)
        {
                    connection.Send(new SC_SupportTeams
                    {
                        Field1 = { },
                    });
        }
    }
}
