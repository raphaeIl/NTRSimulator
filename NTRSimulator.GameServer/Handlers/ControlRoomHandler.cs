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
                    Field1 =
                    {
                        1647247360, 1645478144, 1638859520, 1640563712, 1645678848, 1645744386, 1649742336, 1646723584, 1646724352, 1645413888, 1645545216, 1645611008, 1645807872, 1645873664, 1646136064, 1646201856, 1647447296, 1647513088, 1647578880, 1647710208, 1647841282, 1647907330, 1648300800, 1648366592
                    },
                    Field2 = { 1704003614 },
                    Field3 = 1335002,
                    Field4 = 1335101,
                    Field5 =
                    {
                        61, 501, 980, 594, 699, 1210, 152, 0, 0
                    },
                    Field6 = { },
                    Field7 = { },
                },
                Field2 = 0,
                Field3 = { },
            });
        }

    }
}
