using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class GmConfigHandler : GmConfigHandlerBase
    {
        public override void HandleGetGmConfig(CS_GetGmConfig request, Connection connection)
        {
            connection.Send(
            new SC_GetGmConfig
            {
                FHMAIHPMLJD =
                {
                    new FFHEDKJNNCE
                    {
                        GBBABCAJHBL = FPCALFLJIHM.GmConfigIdCustomText,
                        CustomText = new NBNHIJCGJDF
                        {
                            PAIACGBBODH =
                            { },
                        },
                    },
                    new FFHEDKJNNCE
                    {
                        GBBABCAJHBL = FPCALFLJIHM.GmConfigIdCloseFunctions,
                        CloseFunctions = new OHBPICADMHD
                        {
                            PIGJLNIEJAP = { },
                        },
                    },
                },
            }
            );
        }
    }
}
