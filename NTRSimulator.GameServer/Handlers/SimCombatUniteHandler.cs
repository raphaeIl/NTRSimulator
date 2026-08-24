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
                Info = new DarkZoneQuestGroups
                {
                    GOFCFHDHIIO =
                    {
                        {
                            1162u,
                            new FILNFOFMAJN
                            {
                                OHPHNKCEGCM = 1162,
                                PlanId = 90066,
                            }
                        },
                    },
                },
            });
        }
    }
}
