using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class DifficultHandler : DifficultHandlerBase
    {
        public override void HandleDifficultInfo(CS_DifficultInfo request, Connection connection)
        {
            connection.Send(new SC_DifficultInfo
            {
                Field1 = new SC_DifficultInfo_F1Type
                {
                    Field1 = { },
                    Field2 = { },
                    Field3 = 0,
                    Field4 = { },
                    Field5 = 0,
                },
            });
        }
    }
}
