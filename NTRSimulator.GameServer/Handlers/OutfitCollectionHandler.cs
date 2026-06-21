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
                        Field1 = new SC_OutfitCollectionInfo_F1Type
                        {
                            Field1 = 60,
                            Field2 = 0,
                            Field3 = 0,
                        },
                    });
        }

        public override void HandleOutfitCollectionConfirmScore(CS_OutfitCollectionConfirmScore request, Connection connection)
        {
            connection.Send(new SC_OutfitCollectionConfirmScore()
            {
                Field1 = 999999
            });
        }

        public override void HandleOutfitCollectionLevelReward(CS_OutfitCollectionLevelReward request, Connection connection)
        {
            connection.Send(new SC_OutfitCollectionLevelReward()
            {
                Field1 = 999999
            });
        }
    }
}
