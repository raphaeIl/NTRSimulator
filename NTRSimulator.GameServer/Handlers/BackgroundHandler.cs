using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;
using NTRSimulator.GameServer.Services;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class BackgroundHandler(IBackgroundService backgroundService) : BackgroundHandlerBase
    {
        public override void HandleBackgroundInfo(CS_BackgroundInfo request, Connection connection)
        {
            connection.Send(new SC_BackgroundInfo { Background = 3056 });
        }

        public override void HandleBackgroundChange(CS_BackgroundChange request, Connection connection)
        {
            if (connection.Account == null) return;

            if (request.BackGround != 0)
                backgroundService.SetCurrentBackground(connection.Account.Uid, request.BackGround);

            connection.Send(new SC_BackgroundChange());
        }
    }
}
