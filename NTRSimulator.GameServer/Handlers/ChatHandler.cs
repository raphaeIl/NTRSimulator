using Microsoft.Extensions.Logging;
using NTRSimulator.Command;
using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class ChatHandler(ILogger<ChatHandler> logger, CommandDispatcher commandDispatcher) : ChatHandlerBase
    {
        public override void HandleChat(CS_Chat request, Connection connection)
        {
            logger.LogInformation("Chat: {Request}", request);

            // Intercept commands prefixed with '/'
            if (request.Message is { Length: > 1 } text && text.StartsWith('/'))
            {
                connection.Send(new SC_Chat
                {
                    Uid = request.Uid,
                    Message = new ChatMessage
                    {
                        Id = (long)(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() << 22),
                        Active = true,
                        Message = request.Message ?? "",
                        Emoji = request.Emoji,
                        Ts = (uint)DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                    },
                });

                commandDispatcher.Dispatch(
                    text[1..],
                    CommandSource.Client,
                    connection,
                    clientReplyCallback: reply => connection.Send(new SC_Chat
                    {
                        Uid = request.Uid,
                        Message = new ChatMessage
                        {
                            Id = (long)(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() << 22),
                            Active = false,
                            Message = reply,
                            Emoji = 0,
                            Ts = (uint)DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                        },
                    }));
                return;
            }

            connection.Send(new SC_Chat
            {
                Uid = request.Uid,
                Message = new ChatMessage
                {
                    Id = (long)(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() << 22),
                    Active = true,
                    Message = request.Message ?? "",
                    Emoji = request.Emoji,
                    Ts = (uint)DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                },
            });
        }


        public override void HandleChatRead(CS_ChatRead request, Connection connection)
        {
            connection.Send(new SC_ChatRead
            {
                Uid = request.Uid,
            });
        }

        public override void HandleChatDetail(CS_ChatDetail request, Connection connection)
        {
            const long lastId = 1;
            connection.Send(new SC_ChatDetail
            {
                Uid = request.Uid,
                Chat = new Chat
                {
                    Uid = request.Uid,
                    LastId = lastId,
                    UnreadNum = 0,
                    Show = false,
                    AEEDCNBBHGK = lastId,
                },
                History = new FNMCGHAOALB
                {
                    KCBKEINNPGK =
                    {
                        new ChatMessage
                        {
                            Id = lastId,
                            Active = false,
                            Message = "Welcome to NTRSimulator!",
                            Emoji = 0,
                            Ts = 1,
                        },
                    },
                },
            });
        }
    }
}
