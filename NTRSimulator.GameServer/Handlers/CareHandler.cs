using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class CareHandler : CareHandlerBase
    {

        public override void HandleCareInfo(CS_CareInfo request, Connection connection)
        {
                    connection.Send(new SC_CareInfo
                    {
                        Field1 = { },
                        Field2 = { },
                        Field3 = false,
                    });
        }
    }
}
