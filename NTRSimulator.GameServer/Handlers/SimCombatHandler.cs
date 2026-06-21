using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class SimCombatHandler : SimCombatHandlerBase
    {
        public override void HandleSimCombatInfo(CS_SimCombatInfo request, Connection connection)
        {
            connection.Send(new SC_SimCombatInfo
            {
                Field1 = new SC_SimCombatInfo_F1Type { Field1 = 0 },
            });
        }

        public override void HandleSimCombatMythicInfo(CS_SimCombatMythicInfo request, Connection connection)
        {
            connection.Send(
            new SC_SimCombatMythicInfo
            {
                Field1 = { },
                Field2 =
                { },
                Field3 = 0,
                Field4 = false,
                Field5 = new SC_SimCombatMythicInfo_F5Type
                {
                    Field3 = 0,
                    Field4 = { },
                    Field5 = { },
                },
            }
            );
        }

        public override void HandleSimCombatMythicHardInfo(CS_SimCombatMythicHardInfo request, Connection connection)
        {
            connection.Send(
            new SC_SimCombatMythicHardInfo
            {
                Field1 =
                {
                    new SC_SimCombatMythicHardHistory_F1Type
                    {
                        Field1 = 26,
                        Field2 =
                        { },
                        Field4 = 180026,
                    },
                },
            }
            );
        }

        public override void HandleSimCombatResourceInfo(CS_SimCombatResourceInfo request, Connection connection)
        {
            connection.Send(
            new SC_SimCombatResourceInfo
            {
                Field9 = { },
            }
            );
        }
    }
}
