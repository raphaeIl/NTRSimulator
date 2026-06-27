using Google.Protobuf;
using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class ClientHandler : ClientHandlerBase
    {
        public override void HandleClientReachCount(CS_ClientReachCount request, Connection connection)
        {
            connection.Send(new SC_ClientReachCount
            {
                IsInvisiableInGrass = request.BDDOIKKHJFH,
                JILCADDFLNO = request.JILCADDFLNO,
            });
        }
    }
}
