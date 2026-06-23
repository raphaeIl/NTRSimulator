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

        public override void HandleLobbyAsmrUnlockGun(CS_LobbyAsmrUnlockGun request, Connection connection)
        {
            connection.Send(new SC_LobbyAsmrUnlockGun
            {
                Field1 = request.Field1,
            });
        }

        public override void HandleLobbyAsmrEnd(CS_LobbyAsmrEnd request, Connection connection)
        {
            connection.Send(new SC_LobbyAsmrEnd());
        }
    }
}
