using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class AssistantHandler : AssistantHandlerBase
    {
        public override void HandleAssistant(CS_Assistant request, Connection connection)
        {
                    connection.Send(new SC_Assistant
                    {
                        GGOLBAILKIO = { },
                        FLLPGJLBPLF = 0,
                        IHNNHDGFJKB = { },
                    });
        }

    }
}
