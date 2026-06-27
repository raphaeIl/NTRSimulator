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
                                IOINKEDEKND = false,
                                Rewards =
                                {
                                    [1001] = new ECDNJHCNDJB
                                    {
                                        EDCJPOMIGHG = (ECDNJHCNDJB.Types.BBCLAKIOMLF)1,
                                        IFGAOKKPHAF = 0,
                                    },
                                },
                                DPOCKPGIDJN = new CJPDLINBJCO
                                {
                                    EENJDLHFCPI = { },
                                    FLEJPMNDEMN = { },
                                    PPACOCKHNPE = { },
                                    EBJGBABBELD = false,
                                },
                            },
                        },
                    });
        }

    }
}
