using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class LobbyAsmrHandler : LobbyAsmrHandlerBase
    {
        public override void HandleLobbyAsmrInfo(CS_LobbyAsmrInfo request, Connection connection)
        {
            connection.Send(new SC_LobbyAsmrInfo
            {
                Field1 = { 1 },
                Field2 = { 1017 },
            });
        }
    }
}
