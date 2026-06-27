using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class BackgroundHandler : BackgroundHandlerBase
    {
        public override void HandleBackgroundInfo(CS_BackgroundInfo request, Connection connection)
        {
            connection.Send(new SC_BackgroundInfo { Background = 1001 });
        }
    }
}
