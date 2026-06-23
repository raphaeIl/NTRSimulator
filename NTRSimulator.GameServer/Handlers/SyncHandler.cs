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
                // unforunately gacha banners are controlled by client side tables
                // 1775000000 is a time where all 3 skin gacha banners are active, hardcode to this to fix skin gacha banners breaking
                Field1 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(),
                Field2 = 0

            });
        }
    }
}
