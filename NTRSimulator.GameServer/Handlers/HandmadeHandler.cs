using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class HandmadeHandler : HandmadeHandlerBase
    {
        public override void HandleHandmadeData(CS_HandmadeData request, Connection connection)
        {
                    connection.Send(new SC_HandmadeData
                    {
                        Field1 = new SC_ControlRoomInfo_F1Type_F10Type
                        {
                            Field1 = { },
                            Field2 = 1335001,
                            Field3 = 1335101,
                            Field4 = 0,
                            Field5 = { },
                        },
                        Field2 = { },
                        Field3 = { },
                    });
        }
    }
}
