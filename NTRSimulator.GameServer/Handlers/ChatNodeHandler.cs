using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class ChatNodeHandler : ChatNodeHandlerBase
    {
        public override void HandleChatNodeFetchAddr(CS_ChatNodeFetchAddr request, Connection connection)
        {
            connection.Send(new SC_ChatNodeFetchAddr
            {
                Field1 = true,
            });
        }
    }
}
