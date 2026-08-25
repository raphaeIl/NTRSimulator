using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class HandmadeHandler : HandmadeHandlerBase
    {
        public override void HandleHandmadeData(CS_HandmadeData request, Connection connection)
        {
                    connection.Send(new SC_HandmadeData
                    {
                        HGMDLHCFPDE = new BJINECMIFNJ
                        {
                            NBONFIHFCBE = { },
                            FJFCNNNPACN = 1335001,
                            ELANFNLJCFM = 1335101,
                            Score = 0,
                            CFOCLIHKKJL = { },
                        },
                        OAADPGBJAFC = { },
                        HOLDEOHEKJO = { },
                    });
        }
    }
}
