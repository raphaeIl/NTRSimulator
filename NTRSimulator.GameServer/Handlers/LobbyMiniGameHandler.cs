using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class LobbyMiniGameHandler : LobbyMiniGameHandlerBase
    {
        public override void HandleLobbyMiniGameInfo(CS_LobbyMiniGameInfo request, Connection connection)
        {
                    connection.Send(new SC_LobbyMiniGameInfo
                    {
                        Field1 =
                        {
                            {
                                2u,
                                new SC_LobbyMiniGameInfo_F1ValueType
                                {
                                    Field1 = false,
                                    Field2 = { },
                                    Field3 = null,
                                    Field4 = null,
                                    Field5 = 0,
                                }
                            },
                            {
                                1u,
                                new SC_LobbyMiniGameInfo_F1ValueType
                                {
                                    Field1 = false,
                                    Field2 = { },
                                    Field3 = null,
                                    Field4 = null,
                                    Field5 = 0,
                                }
                            },
                        },
                    });
        }
    }
}
