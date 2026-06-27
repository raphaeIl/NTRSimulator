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
                Info = new SimCombatInfo { AdvancedMaxLevel = 0 },
            });
        }

        public override void HandleSimCombatMythicInfo(CS_SimCombatMythicInfo request, Connection connection)
        {
            connection.Send(
            new SC_SimCombatMythicInfo
            {
                StageInfo = { },
                GroupIds =
                { },
                NextTime = 0,
                CanRecive = false,
                Info = new EKOHFHNPMFN
                {
                    JMMDJGMFEIG = 0,
                    StageInfo = { },
                    ELECCHPPDOD = { },
                },
            }
            );
        }

        public override void HandleSimCombatMythicHardInfo(CS_SimCombatMythicHardInfo request, Connection connection)
        {
            connection.Send(
            new SC_SimCombatMythicHardInfo
            {
                Current =
                {
                    new HDBBHGABLCP
                    {
                        Current = 26,
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
                SimCombatResource = { },
            }
            );
        }
    }
}
