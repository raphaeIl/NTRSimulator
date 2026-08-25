using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class ControlRoomHandler : ControlRoomHandlerBase
    {
        public override void HandleControlRoomInfo(CS_ControlRoomInfo request, Connection connection)
        {
                    connection.Send(new SC_ControlRoomInfo
                    {
                        LIGIJKFNABP = new FOFHJPHAJBB
                        {
                            Level = 1,
                            DFABABLCGHH = new KOEDCHCBJNJ
                            {
                                JEELHBDIIHI = 0,
                                RefreshTime = 1762675047,
                            },
                            OIMEBMHAFPE = { },
                            BCFPLLOKLOJ = { },
                            OCKDMJGKKAP = { },
                            GANJJEKKNMJ = 0,
                            MFNMINHPEJF = { },
                            NOMKAFOLOIO = 0,
                            BBBLPEMJMJN = 0,
                        },
                        AHGJPJEKGJH = { },
                    });
        }

        public override void HandleControlRoomScheme(CS_ControlRoomScheme request, Connection connection)
        {
            connection.Send(new SC_ControlRoomScheme
            {
                FIBHCMPGDIK = new OneUnit
                {
                    OBMLMKKHBIA =
                    {
                        1647247360, 1645478144, 1638859520, 1640563712, 1645678848, 1645744386, 1649742336, 1646723584, 1646724352, 1645413888, 1645545216, 1645611008, 1645807872, 1645873664, 1646136064, 1646201856, 1647447296, 1647513088, 1647578880, 1647710208, 1647841282, 1647907330, 1648300800, 1648366592
                    },
                    OAADPGBJAFC = { 1704003614 },
                    FJFCNNNPACN = 1335002,
                    ELANFNLJCFM = 1335101,
                    GMHAPPNLCPG =
                    {
                        61, 501, 980, 594, 699, 1210, 152, 0, 0
                    },
                    AHGJPJEKGJH = { },
                    CDJLGOLKEBG = { },
                },
                HAOEIOLJDNP = 0,
                KKABLJJJBHM = { },
            });
        }

    }
}
