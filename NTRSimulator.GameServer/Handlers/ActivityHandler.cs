using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class ActivityHandler : ActivityHandlerBase
    {
        public override void HandlePlanActivity(CS_PlanActivity request, Connection connection)
        {
            switch (request.Field1)
                    {
                        case 4:
                            connection.Send(new SC_PlanActivity
                            {
                                Field1 = 4,
                                Field2 = { },
                                Field3 = { },
                                Field4 = { },
                                Field5 = { },
                            });
                            break;
                        case 5:
                            connection.Send(new SC_PlanActivity
                            {
                                Field1 = 5,
                                Field2 = { 50063, 500261, 50064 },
                                Field3 = { },
                                Field4 = { },
                                Field5 = { },
                            });
                            break;
                        case 6:
                            connection.Send(1,
                                new SC_PlanActivity
                                {
                                    Field1 = 6,
                                    Field2 =
                                    {
                                        63409,
                                        69992,
                                        60015,
                                        63301,
                                        63410,
                                        63402,
                                        60003,
                                        63401,
                                        69999,
                                        69997,
                                        63408,
                                        69993,
                                        69995,
                                    },
                                    Field3 =
                                    {
                                    },
                                    Field4 =
                                    {
                                        new SC_PlanActivity_F4Type
                                        {
                                            Field1 = 63409,
                                            Field2 = 1779148800L,
                                            Field3 = 1780963199L,
                                            Field4 =
                                            {
                                            },
                                            Field5 =
                                            {
                                            },
                                        },
                                        new SC_PlanActivity_F4Type
                                        {
                                            Field1 = 69992,
                                            Field2 = 1697162400L,
                                            Field3 = 2553800399L,
                                            Field4 =
                                            {
                                            },
                                            Field5 =
                                            {
                                            },
                                        },
                                        new SC_PlanActivity_F4Type
                                        {
                                            Field1 = 60015,
                                            Field2 = 1702630800L,
                                            Field3 = 2553800399L,
                                            Field4 =
                                            {
                                            },
                                            Field5 =
                                            {
                                            },
                                        },
                                        new SC_PlanActivity_F4Type
                                        {
                                            Field1 = 63301,
                                            Field2 = 1777334400L,
                                            Field3 = 1779656399L,
                                            Field4 =
                                            {
                                            },
                                            Field5 =
                                            {
                                            },
                                        },
                                        new SC_PlanActivity_F4Type
                                        {
                                            Field1 = 63410,
                                            Field2 = 1779148800L,
                                            Field3 = 1780963199L,
                                            Field4 =
                                            {
                                            },
                                            Field5 =
                                            {
                                            },
                                        },
                                        new SC_PlanActivity_F4Type
                                        {
                                            Field1 = 63402,
                                            Field2 = 1779148800L,
                                            Field3 = 1780963199L,
                                            Field4 =
                                            {
                                            },
                                            Field5 =
                                            {
                                            },
                                        },
                                        new SC_PlanActivity_F4Type
                                        {
                                            Field1 = 60003,
                                            Field2 = 1697162400L,
                                            Field3 = 2553800399L,
                                            Field4 =
                                            {
                                            },
                                            Field5 =
                                            {
                                            },
                                        },
                                        new SC_PlanActivity_F4Type
                                        {
                                            Field1 = 63401,
                                            Field2 = 1779148800L,
                                            Field3 = 1781470799L,
                                            Field4 =
                                            {
                                            },
                                            Field5 =
                                            {
                                            },
                                        },
                                        new SC_PlanActivity_F4Type
                                        {
                                            Field1 = 69999,
                                            Field2 = 1779500060L,
                                            Field3 = 1780709660L,
                                            Field4 =
                                            {
                                            },
                                            Field5 =
                                            {
                                            },
                                        },
                                        new SC_PlanActivity_F4Type
                                        {
                                            Field1 = 69997,
                                            Field2 = 1702621200L,
                                            Field3 = 2553800399L,
                                            Field4 =
                                            {
                                            },
                                            Field5 =
                                            {
                                            },
                                        },
                                        new SC_PlanActivity_F4Type
                                        {
                                            Field1 = 63408,
                                            Field2 = 1779148800L,
                                            Field3 = 1780963199L,
                                            Field4 =
                                            {
                                            },
                                            Field5 =
                                            {
                                            },
                                        },
                                        new SC_PlanActivity_F4Type
                                        {
                                            Field1 = 69993,
                                            Field2 = 1779500060L,
                                            Field3 = 0L,
                                            Field4 =
                                            {
                                                0,
                                            },
                                            Field5 =
                                            {
                                            },
                                        },
                                        new SC_PlanActivity_F4Type
                                        {
                                            Field1 = 69995,
                                            Field2 = 1743213915L,
                                            Field3 = 0L,
                                            Field4 =
                                            {
                                                0,
                                            },
                                            Field5 =
                                            {
                                            },
                                        },
                                    },
                                    Field5 =
                                    {
                                    },
                                });
                            break;
                        case 13:
                            connection.Send(new SC_PlanActivity
                            {
                                Field1 = 13,
                                Field2 = { 51079 },
                                Field3 = { 51080 },
                                Field4 = { },
                                Field5 = { },
                            });
                            break;
            }
        }

        public override void HandleActivityGetMedium(CS_ActivityGetMedium request, Connection connection)
        {
                    connection.Send(new SC_ActivityGetMedium
                    {
                        Field1 =
                        {
                            [1] = new SC_ActivityGetMedium_F1ValueType
                            {
                                Field1 = 0,
                                Field2 = "3F13V8TC32",
                            },
                        },
                    });
        }

        public override void HandleGetActivityAmo(CS_GetActivityAmo request, Connection connection)
        {
                    connection.Send(new SC_GetActivityAmo
                    {
                        Field1 = { },
                    });
        }

        public override void HandleActivityBackInfo(CS_ActivityBackInfo request, Connection connection)
        {
                    connection.Send(new SC_ActivityBackInfo
                    {
                        Field1 = new SC_ActivityBackDailyRefresh_F1Type
                        {
                            Field1 = 1,
                            Field2 = 1779500060,
                            Field3 = 3,
                            Field4 = 1779518860,
                            Field5 = false,
                            Field6 = 0,
                            Field7 = false,
                            Field8 = 2,
                            Field9 = new SC_ActivityBackDailyRefresh_F1Type_F9Type
                            {
                                Field1 = 0,
                                Field2 = 0,
                                Field3 = 0,
                                Field4 = { },
                                Field5 = { },
                            },
                        },
                    });
        }

        public override void HandleGetActivityDailyFood(CS_GetActivityDailyFood request, Connection connection)
        {
                    connection.Send(new SC_GetActivityDailyFood
                    {
                        Field1 =
                        {
                            [1] = new SC_GetActivityDailyFood_F1ValueType
                            {
                                Field1 = 1779508800,
                                Field2 = false,
                            },
                            [2] = new SC_GetActivityDailyFood_F1ValueType
                            {
                                Field1 = 1779530400,
                                Field2 = false,
                            },
                        },
                    });
        }

        public override void HandleGetActivityConversion(CS_GetActivityConversion request, Connection connection)
        {
                    connection.Send(new SC_GetActivityConversion
                    {
                        Field1 = new SC_GetActivityConversion_F1Type
                        {
                            Field1 = 0,
                            Field2 = false,
                        },
                    });
        }

        public override void HandleActivitySkinBargainInfo(CS_ActivitySkinBargainInfo request, Connection connection)
        {
                    connection.Send(new SC_ActivitySkinBargainInfo
                    {
                        Field1 = { },
                    });
        }

        public override void HandleActivityLotteryInfo(CS_ActivityLotteryInfo request, Connection connection)
        {
                    connection.Send(new SC_ActivityLotteryInfo()
                    {
                        Field1 = { }
                    });
        }

        public override void HandleActivityBackOneTimeReward(CS_ActivityBackOneTimeReward request, Connection connection)
        {
        }
    }
}
