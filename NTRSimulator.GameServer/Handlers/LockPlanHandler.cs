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
                Field1 = new SC_GetSupportChipLockPlan_F1Type
                {
                    Field3 = new SC_GetSupportChipLockPlan_F1Type_F3Type
                    {
                        Field2 = false,
                    },
                    Field4 = new SC_GetSupportChipLockPlan_F1Type_F3Type
                    {
                        Field2 = false,
                    },
                },
            };
            foreach ((uint Index, uint[] Slots, uint PlanField3) plan in type3Plans)
            {
                SC_GetSupportChipLockPlan_F1Type_F3Type_F3ValueType planValue = new SC_GetSupportChipLockPlan_F1Type_F3Type_F3ValueType();
                SC_GetSupportChipLockPlan_F1Type_F3Type_F3ValueType_F1Type entry = new SC_GetSupportChipLockPlan_F1Type_F3Type_F3ValueType_F1Type
                {
                    Field3 = plan.PlanField3,
                };
                entry.Field2.AddRange(plan.Slots);
                planValue.Field1.Add(entry);
                response.Field1.Field3.Field3[plan.Index] = planValue;
            }
            foreach ((uint Index, uint[] Slots, uint PlanField3) plan in type4Plans)
            {
                SC_GetSupportChipLockPlan_F1Type_F3Type_F3ValueType planValue = new SC_GetSupportChipLockPlan_F1Type_F3Type_F3ValueType();
                SC_GetSupportChipLockPlan_F1Type_F3Type_F3ValueType_F1Type entry = new SC_GetSupportChipLockPlan_F1Type_F3Type_F3ValueType_F1Type
                {
                    Field3 = plan.PlanField3,
                };
                entry.Field2.AddRange(plan.Slots);
                planValue.Field1.Add(entry);
                response.Field1.Field4.Field3[plan.Index] = planValue;
            }
            connection.Send(response);
        }
    }
}
