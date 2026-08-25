using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class OldSchemeHandler : OldSchemeHandlerBase
    {
        public override void HandleGetAllOldScheme(CS_GetAllOldScheme request, Connection connection)
        {
                    connection.Send(new SC_GetAllOldScheme
                    {
                        HBEFGPHGDNN = { },
                        NIIJEGDNMLD = { },
                    });
        }

    }
}
