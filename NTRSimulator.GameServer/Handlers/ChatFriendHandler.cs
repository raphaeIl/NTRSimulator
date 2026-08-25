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
                Friend =
                {
                    CreateChat(1),
                    CreateChat(2),
                    CreateChat(3),
                },
            });
        }

        private static Chat CreateChat(ulong uid)
        {
            const long lastId = 1;
            return new Chat
            {
                Uid = uid,
                LastId = lastId,
                UnreadNum = 0,
                Show = false,
                AEEDCNBBHGK = lastId,
            };
        }
    }
}
