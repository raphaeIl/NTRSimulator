using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class AvgHandler : AvgHandlerBase
    {
        public override void HandleGetAvgInfo(CS_GetAvgInfo request, Connection connection)
        {
            connection.Send(
            new SC_GetAvgInfo
            {
                CharacterAvgs = { },
            }
            );
        }
    }
}
