using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class ThemeMiniGameHandler : ThemeMiniGameHandlerBase
    {
        public override void HandleThemeMiniGameInfo(CS_ThemeMiniGameInfo request, Connection connection)
        {
                    connection.Send(new SC_ThemeMiniGameInfo
                    {
                        Field1 = 3601,
                        Field2 = 21005,
                        Field3 = null,
                        Field4 = null,
                        Field5 = null,
                        Field6 = new SC_LobbyMiniGameInfo_F1ValueType_F4Type
                        {
                            Field1 = false,
                            Field2 = 0,
                            Field3 = 0,
                            Field4 = 0,
                        },
                        Field7 = null,
                        Field8 = null,
                        Field9 = 0,
                    });
        }

    }
}
