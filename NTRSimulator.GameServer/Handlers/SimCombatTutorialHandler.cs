using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class SimCombatTutorialHandler : SimCombatTutorialHandlerBase
    {
        public override void HandleSimCombatTutorialInfoV2(CS_SimCombatTutorialInfoV2 request, Connection connection)
        {
            connection.Send(new SC_SimCombatTutorialInfoV2
            {
                Field1 = new SC_SimCombatTutorialInfoV2_F1Type { Field1 = 0 },
            });
        }
    }
}
