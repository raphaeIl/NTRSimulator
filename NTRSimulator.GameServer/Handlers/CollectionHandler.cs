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
                        MPBPMJOCFFM = new LFIIJJHKECB
                        {
                            CurrId = 0,
                            History = { },
                        },
                    });
        }

    }
}
