using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class RedDotHandler : RedDotHandlerBase
    {
        public override void HandleRedDotInfo(CS_RedDotInfo request, Connection connection)
        {
            connection.Send(new SC_RedDotInfo());
        }
    }
}
