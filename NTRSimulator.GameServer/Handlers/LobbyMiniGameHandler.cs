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
                        PDGDDBPGDKD =
                        {
                            {
                                2u,
                                new HMDODOBKKND
                                {
                                    MPNGHAKGLDM = false,
                                    KOPDKBOLABF = { },
                                    
                                }
                            },
                            {
                                1u,
                                new HMDODOBKKND
                                {
                                    MPNGHAKGLDM = false,
                                    KOPDKBOLABF = { },
                                    
                                }
                            },
                        },
                    });
        }
    }
}
