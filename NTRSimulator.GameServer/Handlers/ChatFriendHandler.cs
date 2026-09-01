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
            return new Chat
            {
                CounterType = JCODPDKNMBI.CounterDefault,
                LastId = DPKCGBBDMAM.ResetNone,
                PJBOAGJCMKK = KCCBHFPHCPD.Default,
                AJNAPNNKIFC = false,
            };
        }
    }
}
