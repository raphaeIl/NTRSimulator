using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class DispatchHandler : DispatchHandlerBase
    {
        public override void HandleGetDispatchInfo(CS_GetDispatchInfo request, Connection connection)
        {
                    connection.Send(new SC_GetDispatchInfo
                    {
                        Field1 = { },
                    });
        }

    }
}
