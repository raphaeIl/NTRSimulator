using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class TitleHandler : TitleHandlerBase
    {
        public override void HandleModTitle(CS_ModTitle request, Connection connection)
        {
            connection.Send(new SC_ModTitle
            {
                Field1 = request.Field1,
            });
        }
    }
}
