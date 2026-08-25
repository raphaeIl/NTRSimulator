using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class AutoDismantleHandler : AutoDismantleHandlerBase
    {
        public override void HandleGetAutoDismantleRulesInfo(CS_GetAutoDismantleRulesInfo request, Connection connection)
        {
            connection.Send(
            new SC_GetAutoDismantleRulesInfo
            {
                CEOJCLOOAOA = new NGOKNFICEOD
                {
                    HOECFIANEAB = null,
                    JGPEJLJCGMB = null,
                },
            }
            );
        }
    }
}
