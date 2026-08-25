using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class TreasureHandler : TreasureHandlerBase
    {
        public override void HandleTreasureData(CS_TreasureData request, Connection connection)
        {
            connection.Send(new SC_TreasureData
            {
                LLLDFCFANII =
                {
                    [60015] = new IAHOOMEFPND
                    {
                        Level = 1,
                        Exp = 0,
                        IOINKEDEKND = false,
                    },
                },
            });
        }
    }
}
