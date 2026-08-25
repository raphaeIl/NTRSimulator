using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class BgmHandler : BgmHandlerBase
    {
        public override void HandleGetBgm(CS_GetBgm request, Connection connection)
        {
            connection.Send(new SC_GetBgm { JNHHAINDALC = 0 });
        }
    }
}
