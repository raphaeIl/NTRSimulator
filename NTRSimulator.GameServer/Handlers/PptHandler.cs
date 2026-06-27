using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class PptHandler : PptHandlerBase
    {
        public override void HandlePptInfo(CS_PptInfo request, Connection connection)
        {
            connection.Send(
            new SC_PptInfo
            {
                BPKHDANAJGF = new KIANAFJAHJC
                {
                    IGIIGDJOPFH =
                    {
                        { 1032u, false },
                        { 2601u, false },
                        { 41109u, false },
                    },
                },
            }
            );
        }
    }
}
