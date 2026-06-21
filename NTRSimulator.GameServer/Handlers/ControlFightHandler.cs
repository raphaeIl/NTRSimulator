using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class ControlFightHandler : ControlFightHandlerBase
    {
        public override void HandleGetControlFightInfo(CS_GetControlFightInfo request, Connection connection)
        {
                    connection.Send(new SC_GetControlFightInfo
                    {
                        Field3 = new SC_ControlFightSettle_F3Type
                        {
                            Field2 = 0,
                            Field1 = { },
                            Field3 = 0,
                        },
                    });
        }

    }
}
