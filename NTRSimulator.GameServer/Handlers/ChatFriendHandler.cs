using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class ChatFriendHandler : ChatFriendHandlerBase
    {
        public override void HandleChatFriendList(CS_ChatFriendList request, Connection connection)
        {
                    connection.Send(new SC_ChatFriendList
                    {
                        Field1 = { },
                    });
        }

    }
}
