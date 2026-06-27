using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class LockPlanHandler : LockPlanHandlerBase
    {
        public override void HandleGetSupportChipLockPlan(CS_GetSupportChipLockPlan request, Connection connection)
        {
            (uint Index, uint[] Slots, uint PlanField3)[] type3Plans =
            {
                (1, new uint[] { 2, 3, 4, 5, 6 }, 2),
                (2, new uint[] { 1, 3, 4, 5, 6 }, 2),
                (3, new uint[] { 1, 2, 4, 5, 6 }, 2),
                (4, new uint[] { 1, 2, 3, 5, 6 }, 2),
                (5, new uint[] { 1, 2, 3, 4, 6 }, 2),
                (6, new uint[] { 1, 2, 3, 4, 5 }, 2),
            };
            (uint Index, uint[] Slots, uint PlanField3)[] type4Plans =
            {
                (101, new uint[] { 301 }, 1),
                (102, new uint[] { 301 }, 1),
                (103, new uint[] { 301 }, 1),
                (104, new uint[] { 301 }, 1),
                (105, new uint[] { 301 }, 1),
                (106, new uint[] { 301 }, 1),
                (107, new uint[] { 10 }, 1),
            };
            SC_GetSupportChipLockPlan response = new SC_GetSupportChipLockPlan
            {
                DJNPEOFHKHD = new FDGHOKHFAPD
                {
                    APCOFGHAHGD = new FBELIIBLEJP
                    {
                        COFDFFJMNMA = false,
                    },
                    MAFNGCMKKAJ = new FBELIIBLEJP
                    {
                        COFDFFJMNMA = false,
                    },
                },
            };
            foreach ((uint Index, uint[] Slots, uint PlanField3) plan in type3Plans)
            {
                NICHOMDGIOM planValue = new NICHOMDGIOM();
                OMKPKMFIKLP entry = new OMKPKMFIKLP
                {
                    IJMINJLDENL = plan.PlanField3,
                };
                entry.AEBNOHIKJOI.AddRange(plan.Slots);
                planValue.ANGKLPKHILE.Add(entry);
                response.DJNPEOFHKHD.APCOFGHAHGD.IOEHJIPOEED[plan.Index] = planValue;
            }
            foreach ((uint Index, uint[] Slots, uint PlanField3) plan in type4Plans)
            {
                NICHOMDGIOM planValue = new NICHOMDGIOM();
                OMKPKMFIKLP entry = new OMKPKMFIKLP
                {
                    IJMINJLDENL = plan.PlanField3,
                };
                entry.AEBNOHIKJOI.AddRange(plan.Slots);
                planValue.ANGKLPKHILE.Add(entry);
                response.DJNPEOFHKHD.MAFNGCMKKAJ.IOEHJIPOEED[plan.Index] = planValue;
            }
            connection.Send(response);
        }
    }
}
