using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class ControlFightHandler : ControlFightHandlerBase
    {
        public override void HandleGetControlFightInfo(CS_GetControlFightInfo request, Connection connection)
        {
                    connection.Send(new SC_GetControlFightInfo
                    {
                        AGOKHELMAPP = new GBELKJBMGBP
                        {
                            CurrId = 0,
                            CGALBDIKHKH = { },
                            IONMLJBJODF = 0,
                        },
                    });
        }

    }
}
