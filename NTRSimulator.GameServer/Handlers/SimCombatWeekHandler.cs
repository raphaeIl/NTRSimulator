using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class SimCombatWeekHandler : SimCombatWeekHandlerBase
    {
        public override void HandleSimCombatWeekInfo(CS_SimCombatWeekInfo request, Connection connection)
        {
                    SC_SimCombatWeekInfo response = new SC_SimCombatWeekInfo
                    {
                        CycleId = 4,
                        HLJOFEGMBEA = false,
                        Info = new SimCombatWeekly
                        {
                            PlanId = 10004,
                            Storey = 1,
                            LastPlanId = 0,
                            GunPrivilege = { },
                            WeeklyQuest = { },
                            StepStatus = 0,
                            StepB = new SimCombatWeekStepB
                            {
                                FinishBid = 0,
                                MaxScore = 0,
                                Score = 0,
                                Lineups = { },
                                Finished = false,
                            },
                            StepBtimes = 0,
                            FinishedAstory = { },
                            InheritBuff = { },
                            HistoryScore = { },
                            OJBJFHAOEFC = false,
                            DKJDPJGKMNL = false,
                            BJKKBJDMKAC = 0,
                            NJGPJNKPFCM = false,
                            HLJOFEGMBEA = false,
                        },
                    };
                    foreach (uint weekId in new uint[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 })
                    {
                        response.Info.ODKPMJFEMIL[weekId] = new DLNCFFHEHIJ
                        {
                            Storey = weekId,
                            OIFIKKAAKJB = 0,
                            Score = 0,
                            MaxScore = 0,
                            Lineups = { },
                            InheritBuff = { },
                            KNPHEBDLFFP = weekId,
                            CEAKINDONJD = 0,
                            OFNIFIAHBGG = { },
                        };
                    }
                    connection.Send(response);
        }

    }
}
