using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class AvgDuoHandler : AvgDuoHandlerBase
    {
        public override void HandleGetLobbbyAvgDuoInfo(CS_GetLobbbyAvgDuoInfo request, Connection connection)
        {
            connection.Send(new SC_GetLobbbyAvgDuoInfo
            {
                Field1 = { },
                Field2 = { },
            });
        }
    }
}
