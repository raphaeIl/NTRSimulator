using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class ActivityBackHandler : ActivityBackHandlerBase
    {
        public override void HandleActivityBackInfo(CS_ActivityBackInfo request, Connection connection)
        {
            connection.Send(new SC_ActivityBackInfo
            {
                Info = new IGHEKKLGNLA
                {
                    IAPDLJKLLNM = 1,
                    OpenTime = 1779500060,
                    HNAKPBEGGFK = 3,
                    HPABIPEOBKN = 1779518860,
                    IEHFGOMCBCN = false,
                    CJOINHJCPII = 0,
                    CheckinDone = false,
                    Version = 2,
                    ANGHCINLCJO = new OCLANMMGEGA
                    {
                        Type = 0,
                        Level = 0,
                        LMNBPEBDCKG = { },
                        IMMBMDAPFEN = { },
                    },
                },
            });
        }
    }
}
