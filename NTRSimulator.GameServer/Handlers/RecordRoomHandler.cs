using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class RecordRoomHandler : RecordRoomHandlerBase
    {
        public override void HandleRecordRoom(CS_RecordRoom request, Connection connection)
        {
            connection.Send(new SC_RecordRoom
            {
                Field1 = { },
            });
        }
    }
}
