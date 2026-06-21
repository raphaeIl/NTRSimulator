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
                Field1 = new SC_GetAutoDismantleRulesInfo_F1Type
                {
                    Field1 = null,
                    Field2 = null,
                },
            }
            );
        }
    }
}
