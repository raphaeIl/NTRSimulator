using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class SimCombatUniteHandler : SimCombatUniteHandlerBase
    {
        public override void HandleSimCombatUniteInfo(CS_SimCombatUniteInfo request, Connection connection)
        {
            connection.Send(new SC_SimCombatUniteInfo
            {
                Info = new CLEKMDAGJGD
                {
                    GOFCFHDHIIO =
                    {
                        {
                            1162u,
                            new FILNFOFMAJN
                            {
                                OHPHNKCEGCM = 1162,
                                MAFBBBKKJMB = 0,
                                BHIAGOGIIGG = 0,
                                IDMDHJOAAMP = false,
                                LDOMDNMPOKP = { },
                                IODHOGMMKKN = 0,
                                HKNKLFBMPND = { },
                                KJDMLPEHBKO = 0,
                                PlanId = 90066,
                                PNGEMPCLCNB = 0,
                            }
                        },
                    },
                },
            });
        }
    }
}
