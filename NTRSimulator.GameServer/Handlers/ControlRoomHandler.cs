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
                        Field1 = new SC_ControlRoomInfo_F1Type
                        {
                            Field1 = 1,
                            Field2 = new SC_ControlRoomInfo_F1Type_F2Type
                            {
                                Field1 = 0,
                                Field2 = 1762675047,
                            },
                            Field3 = { },
                            Field4 = { },
                            Field5 = { },
                            Field6 = 0,
                            Field7 = { },
                            Field8 = 0,
                            Field9 = 0,
                        },
                        Field2 = { },
                    });
        }

        public override void HandleControlRoomScheme(CS_ControlRoomScheme request, Connection connection)
        {
            connection.Send(new SC_ControlRoomScheme
            {
                Field1 = new SC_ControlRoomScheme_F1Type
                {
                    Field1 = { 1647247360, 1645478144 },
                    Field2 = { 1704003614 },
                    Field3 = 1335001,
                    Field4 = 1335101,
                    Field5 = { 61, 501, 980, 594, 1035, 1210, 152, 699, 0 },
                    Field6 = { },
                    Field7 = { },
                },
                Field2 = 0,
                Field3 = { },
            });
        }

    }
}
