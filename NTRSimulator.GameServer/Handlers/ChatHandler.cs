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
            if (request.Field3 is { Length: > 1 } text && text.StartsWith('/'))
            {
                connection.Send(new SC_Chat
                {
                    Field1 = request.Field1,
                    Field2 = new SC_Chat_F2Type
                    {
                        Field1 = (long)(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() << 22),
                        Field2 = true,
                        Field5 = request.Field3 ?? "",
                        Field6 = request.Field2,
                        Field8 = (uint)DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                    },
                });

                commandDispatcher.Dispatch(
                    text[1..],
                    CommandSource.Client,
                    connection,
                    clientReplyCallback: reply => connection.Send(new SC_Chat
                    {
                        Field1 = request.Field1,
                        Field2 = new SC_Chat_F2Type
                        {
                            Field1 = (long)(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() << 22),
                            Field2 = false,
                            Field5 = reply,
                            Field6 = 0,
                            Field8 = (uint)DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                        },
                    }));
                return;
            }

            connection.Send(new SC_Chat
            {
                Field1 = request.Field1,
                Field2 = new SC_Chat_F2Type
                {
                    Field1 = (long)(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() << 22),
                    Field2 = true,
                    Field5 = request.Field3 ?? "",
                    Field6 = request.Field2,
                    Field8 = (uint)DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                },
            });
        }


        public override void HandleChatRead(CS_ChatRead request, Connection connection)
        {
            connection.Send(new SC_ChatRead
            {
                Field1 = request.Field1,
            });
        }

        public override void HandleChatDetail(CS_ChatDetail request, Connection connection)
        {
            switch (request.Field1)
            {
                case 1:
                    connection.Send(new SC_ChatDetail
                    {
                        Field1 = 1,
                        Field2 = new SC_ChatDetail_F2Type
                        {
                            Field1 = 1,
                            Field2 = 1865715258121785344,
                            Field5 = 0,
                            Field6 = false,
                            Field7 = 0,
                            Field8 = 1865715258121785344,
                        },
                        Field3 = new SC_ChatDetail_F3Type
                        {
                            Field1 =
                            {
                                // new SC_Chat_F2Type
                                // {
                                //     Field1 = 1865715237374722048,
                                //     Field2 = true, // is self
                                //     Field5 = "我喜欢你",
                                //     Field6 = 0,
                                //     Field8 = 1780894134,
                                // },
                            },
                            Field2 =
                            {
                                new SC_Chat_F2Type
                                {
                                    Field1 = 1865715258121785344,
                                    Field2 = false,
                                    Field5 = "Welcome to NTRSimulator!",
                                    Field6 = 0,
                                    Field8 = 1780894153,
                                },
                                new SC_Chat_F2Type
                                {
                                    Field1 = 1865715294762176512,
                                    Field2 = false,
                                    Field5 = "",
                                    Field6 = 100901,
                                    Field8 = 1780932799,
                                },
                            },

                        },
                    });
                    break;
            }
        }
    }
}
