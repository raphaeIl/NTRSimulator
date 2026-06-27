using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class ActivityHandler : ActivityHandlerBase
    {
        public override void HandlePlanActivity(CS_PlanActivity request, Connection connection)
        {
            switch (request.Type)
                    {
                        case 4:
                            connection.Send(new SC_PlanActivity
                            {
                                Type = 4,
                                ActiveIds = { },
                                NextIds = { },
                                ActivityPlan = { },
                                WillOpenPlans = { },
                            });
                            break;
                        case 5:
                            connection.Send(new SC_PlanActivity
                            {
                                Type = 5,
                                ActiveIds = { 50063, 500261, 50064 },
                                NextIds = { },
                                ActivityPlan = { },
                                WillOpenPlans = { },
                            });
                            break;
                        case 6:
                            connection.Send(1,
                                new SC_PlanActivity
                                {
                                    Type = 6,
                                    ActiveIds =
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
                                    NextIds =
                                    {
                                    },
                                    ActivityPlan =
                                    {
                                        new ActivityPlan
                                        {
                                            Id = 63409,
                                            OpenTime = 1779148800L,
                                            CloseTime = 1780963199L,
                                            Args =
                                            {
                                            },
                                            GOLPGJGBJIK =
                                            {
                                            },
                                        },
                                        new ActivityPlan
                                        {
                                            Id = 69992,
                                            OpenTime = 1697162400L,
                                            CloseTime = 2553800399L,
                                            Args =
                                            {
                                            },
                                            GOLPGJGBJIK =
                                            {
                                            },
                                        },
                                        new ActivityPlan
                                        {
                                            Id = 60015,
                                            OpenTime = 1702630800L,
                                            CloseTime = 2553800399L,
                                            Args =
                                            {
                                            },
                                            GOLPGJGBJIK =
                                            {
                                            },
                                        },
                                        new ActivityPlan
                                        {
                                            Id = 63301,
                                            OpenTime = 1777334400L,
                                            CloseTime = 1779656399L,
                                            Args =
                                            {
                                            },
                                            GOLPGJGBJIK =
                                            {
                                            },
                                        },
                                        new ActivityPlan
                                        {
                                            Id = 63410,
                                            OpenTime = 1779148800L,
                                            CloseTime = 1780963199L,
                                            Args =
                                            {
                                            },
                                            GOLPGJGBJIK =
                                            {
                                            },
                                        },
                                        new ActivityPlan
                                        {
                                            Id = 63402,
                                            OpenTime = 1779148800L,
                                            CloseTime = 1780963199L,
                                            Args =
                                            {
                                            },
                                            GOLPGJGBJIK =
                                            {
                                            },
                                        },
                                        new ActivityPlan
                                        {
                                            Id = 60003,
                                            OpenTime = 1697162400L,
                                            CloseTime = 2553800399L,
                                            Args =
                                            {
                                            },
                                            GOLPGJGBJIK =
                                            {
                                            },
                                        },
                                        new ActivityPlan
                                        {
                                            Id = 63401,
                                            OpenTime = 1779148800L,
                                            CloseTime = 1781470799L,
                                            Args =
                                            {
                                            },
                                            GOLPGJGBJIK =
                                            {
                                            },
                                        },
                                        new ActivityPlan
                                        {
                                            Id = 69999,
                                            OpenTime = 1779500060L,
                                            CloseTime = 1780709660L,
                                            Args =
                                            {
                                            },
                                            GOLPGJGBJIK =
                                            {
                                            },
                                        },
                                        new ActivityPlan
                                        {
                                            Id = 69997,
                                            OpenTime = 1702621200L,
                                            CloseTime = 2553800399L,
                                            Args =
                                            {
                                            },
                                            GOLPGJGBJIK =
                                            {
                                            },
                                        },
                                        new ActivityPlan
                                        {
                                            Id = 63408,
                                            OpenTime = 1779148800L,
                                            CloseTime = 1780963199L,
                                            Args =
                                            {
                                            },
                                            GOLPGJGBJIK =
                                            {
                                            },
                                        },
                                        new ActivityPlan
                                        {
                                            Id = 69993,
                                            OpenTime = 1779500060L,
                                            CloseTime = 0L,
                                            Args =
                                            {
                                                0,
                                            },
                                            GOLPGJGBJIK =
                                            {
                                            },
                                        },
                                        new ActivityPlan
                                        {
                                            Id = 69995,
                                            OpenTime = 1743213915L,
                                            CloseTime = 0L,
                                            Args =
                                            {
                                                0,
                                            },
                                            GOLPGJGBJIK =
                                            {
                                            },
                                        },
                                    },
                                    WillOpenPlans =
                                    {
                                    },
                                });
                            break;
                        case 13:
                            connection.Send(new SC_PlanActivity
                            {
                                Type = 13,
                                ActiveIds = { 51079 },
                                NextIds = { 51080 },
                                ActivityPlan = { },
                                WillOpenPlans = { },
                            });
                            break;
            }
        }

        public override void HandleActivityGetMedium(CS_ActivityGetMedium request, Connection connection)
        {
                    connection.Send(new SC_ActivityGetMedium
                    {
                        FGMEGJPEJLM =
                        {
                            [1] = new DCNNGHIOOJM
                            {
                                State = 0,
                                Token = "3F13V8TC32",
                            },
                        },
                    });
        }

        public override void HandleGetActivityAmo(CS_GetActivityAmo request, Connection connection)
        {
                    connection.Send(new SC_GetActivityAmo
                    {
                        OOEJEHGFCLL = { },
                    });
        }

        public override void HandleActivityBackInfo(CS_ActivityBackInfo request, Connection connection)
        {
                    connection.Send(new SC_ActivityBackInfo
                    {
                        Info = new IGHEKKLGNLA
                        {
                            IAPDLJKLLNM = 1,
                            OpenTime = 1779500060,
                            HNAKPBEGGFK = 3,
                            HPABIPEOBKN = 1779518860,
                            IEHFGOMCBCN = false,
                            CJOINHJCPII = 0,
                            CheckinDone = false,
                            Version = 2,
                            ANGHCINLCJO = new OCLANMMGEGA
                            {
                                Type = 0,
                                Level = 0,
                                LMNBPEBDCKG = { },
                                IMMBMDAPFEN = { },
                            },
                        },
                    });
        }

        public override void HandleGetActivityDailyFood(CS_GetActivityDailyFood request, Connection connection)
        {
                    connection.Send(new SC_GetActivityDailyFood
                    {
                        PLAKNGGJGPL =
                        {
                            [1] = new JMNBIFKFMLB
                            {
                                ENGFMGEEMBG = 1779508800,
                                State = false,
                            },
                            [2] = new JMNBIFKFMLB
                            {
                                ENGFMGEEMBG = 1779530400,
                                State = false,
                            },
                        },
                    });
        }

        public override void HandleGetActivityConversion(CS_GetActivityConversion request, Connection connection)
        {
                    connection.Send(new SC_GetActivityConversion
                    {
                        GIOIKFICGAE = new PKPJMDCFFKD
                        {
                            CurrId = 0,
                            FPAEHEGGAIH = false,
                        },
                    });
        }

        public override void HandleActivitySkinBargainInfo(CS_ActivitySkinBargainInfo request, Connection connection)
        {
                    connection.Send(new SC_ActivitySkinBargainInfo
                    {
                        Info = { },
                    });
        }

        public override void HandleActivityLotteryInfo(CS_ActivityLotteryInfo request, Connection connection)
        {
                    connection.Send(new SC_ActivityLotteryInfo()
                    {
                        BNKEKDKPCIE = { }
                    });
        }

        public override void HandleActivityBackOneTimeReward(CS_ActivityBackOneTimeReward request, Connection connection)
        {
        }
    }
}
