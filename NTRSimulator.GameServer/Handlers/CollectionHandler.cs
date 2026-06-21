using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class CollectionHandler : CollectionHandlerBase
    {
        public override void HandleGetCollectionInfo(CS_GetCollectionInfo request, Connection connection)
        {
                    connection.Send(new SC_GetCollectionInfo
                    {
                        Field1 = new SC_GetCollectionInfo_F1Type
                        {
                            Field1 = 0,
                            Field2 = { },
                        },
                    });
        }

    }
}
