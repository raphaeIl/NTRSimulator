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
                        Plans =
                        {
                            [600004] = true,
                            [600003] = true,
                            [600002] = true,
                        },
                    });
        }

        public override void HandleGetRougeInfo(CS_GetRougeInfo request, Connection connection)
        {
            

                    switch (request.PlanId)
                    {
                        case 600002:
                            connection.Send(new SC_GetRougeInfo
                            {
                                Info = new HNAJJFJEJGO
                                {
                                    PlanId = 600002,
                                    SeasonId = 2,
                                    Level = 0,
                                    Exp = 0,
                                    CdTime = 0,
                                    LLCCGNFALPF = { },
                                    EJCFAFMIDBH = { },
                                    MMIKNJIBMBA = { },
                                    IDGOOPMEEKD = { },
                                    LDMBJMCDANK = { 55, 67, 68, 74, 82, 83, 90, 51, 61, 76, 52, 58, 72, 78, 84, 85, 87, 53, 57, 59, 65, 50, 60, 63, 75, 77, 79, 81, 49, 69, 70, 71, 73, 80, 89, 54, 62, 64, 66, 86, 88, 56 },
                                    Difficulty = 0,
                                    NDKGOAHEAMJ = { },
                                    PKOFBGMKLLC = { },
                                    ODMEICDCEDP = 0,
                                    PPEKLNDLEED = false,
                                    AOBMDKOGHPL = 0,
                                    LPPMBCMCEKP = 0,
                                    FEALMJMPBHK = { },
                                    HIGHJLJPCPB = 0,
                                },
                            });
                            break;
                        case 600003:
                            connection.Send(new SC_GetRougeInfo
                            {
                                Info = new HNAJJFJEJGO
                                {
                                    PlanId = 600003,
                                    SeasonId = 3,
                                    Level = 0,
                                    Exp = 0,
                                    CdTime = 0,
                                    LLCCGNFALPF = { },
                                    EJCFAFMIDBH = { },
                                    MMIKNJIBMBA = { },
                                    IDGOOPMEEKD = { },
                                    LDMBJMCDANK = { 93, 101, 102, 116, 120, 132, 91, 95, 111, 113, 112, 125, 96, 97, 108, 109, 121, 123, 128, 104, 107, 115, 117, 129, 98, 99, 118, 122, 126, 131, 92, 106, 114, 119, 94, 127, 130, 124, 100, 103, 105, 110 },
                                    Difficulty = 0,
                                    NDKGOAHEAMJ = { },
                                    PKOFBGMKLLC = { },
                                    ODMEICDCEDP = 0,
                                    PPEKLNDLEED = false,
                                    AOBMDKOGHPL = 0,
                                    LPPMBCMCEKP = 0,
                                    FEALMJMPBHK = { },
                                    HIGHJLJPCPB = 0,
                                },
                            });
                            break;
                    }
        }

        public override void HandleGetRougeMapInfo(CS_GetRougeMapInfo request, Connection connection)
        {
            

                    switch (request.PlanId)
                    {
                        case 600002:
                            connection.Send(new SC_GetRougeMapInfo
                            {
                                Map = null,
                                PlanId = 600002,
                            });
                            break;
                        case 600003:
                            connection.Send(new SC_GetRougeMapInfo
                            {
                                Map = null,
                                PlanId = 600003,
                            });
                            break;
                    }
        }

        public override void HandleRougeSeasonInfo(CS_RougeSeasonInfo request, Connection connection)
        {
                    connection.Send(new SC_RougeSeasonInfo
                    {
                        PlanId = 600004,
                        KCCBNBAGLII = new BKJNOBAKFDO
                        {
                            SeasonId = 4,
                            LLCCGNFALPF = { },
                            HFKBNKKKCAP = { },
                            PJENNLFCFOI = { },
                            CMALCHFEBMH = { },
                            BNBIKIDMMMC = 0,
                            MOIOMJBKIAJ = 0,
                            Level = 0,
                            BJAGNIJOBIL = 0,
                            Exp = 0,
                            IANJJGOOLBD = 0,
                            OFKLPJINEGI = false,
                        },
                    });
        }
    }
}
