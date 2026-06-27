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
                        ThemeId = 3601,
                        FNEFKKLJMDN = 21005,
                        CandyCatchData = null,
                        CardFlipData = null,
                        AuditionData = null,
                        DoodleJumpData = new FOMAJCHMPFL
                        {
                            KNFOFFBOCML = false,
                            CGFMBCCDFPG = 0,
                            Duration = 0,
                            Times = 0,
                        },
                        MotorcycleData = null,
                        ButtGameData = null,
                    });
        }

    }
}
