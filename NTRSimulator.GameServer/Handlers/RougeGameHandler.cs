using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class RougeGameHandler : RougeGameHandlerBase
    {
        public override void HandleRougeGameInfo(CS_RougeGameInfo request, Connection connection)
        {
            

                    switch (request.Field1)
                    {
                        case 600004:
                            connection.Send(new SC_RougeGameInfo
                            {
                                Field1 = 600004,
                                Field3 = false,
                            });
                            break;
                    }
        }

    }
}
