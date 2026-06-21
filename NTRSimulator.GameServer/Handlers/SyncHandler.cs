using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class SyncHandler : SyncHandlerBase
    {
        public override void HandleSync(CS_Sync request, Connection connection)
        {
            connection.Send(new SC_Sync
            {
                Field1 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(),
                Field2 = 0

            });
        }
    }
}
