using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class OutfitCollectionHandler : OutfitCollectionHandlerBase
    {
        public override void HandleOutfitCollectionInfo(CS_OutfitCollectionInfo request, Connection connection)
        {
                    connection.Send(new SC_OutfitCollectionInfo
                    {
                        MPBPMJOCFFM = new IDDNGKGGPCB
                        {
                            DEGNALHNOMI = 2294,
                            JBDNIBGJKNO = 2294,
                            BDJAJPIEIHJ = 21,
                        },
                    });
        }

        public override void HandleOutfitCollectionConfirmScore(CS_OutfitCollectionConfirmScore request, Connection connection)
        {
            connection.Send(new SC_OutfitCollectionConfirmScore()
            {
                HGJIGJJOMNG = 999999
            });
        }

        public override void HandleOutfitCollectionLevelReward(CS_OutfitCollectionLevelReward request, Connection connection)
        {
            connection.Send(new SC_OutfitCollectionLevelReward()
            {
                Level = 999999
            });
        }
    }
}
