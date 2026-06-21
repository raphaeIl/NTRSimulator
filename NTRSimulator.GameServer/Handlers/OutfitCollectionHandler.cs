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
                            Field1 = 2294,
                            Field2 = 2294,
                            Field3 = 21,
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
