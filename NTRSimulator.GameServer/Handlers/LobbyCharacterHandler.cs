using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class LobbyCharacterHandler : LobbyCharacterHandlerBase
    {
        public override void HandleLobbyCharacterInfo(CS_LobbyCharacterInfo request, Connection connection)
        {
            connection.Send(new SC_LobbyCharacterInfo
            {
                Field1 =
                {
                    [10520301u] = true,
                    [10640301u] = true,
                    [10250301u] = true,
                    [10340301u] = true,
                    [10470301u] = true,
                    [10480301u] = true,
                    [10610301u] = true,
                    [10340302u] = true,
                    [10290301u] = true,
                    [10130301u] = true,
                },
                Field2 = { },
            });
        }
    }
}
