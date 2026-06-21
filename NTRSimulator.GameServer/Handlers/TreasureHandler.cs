using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class TreasureHandler : TreasureHandlerBase
    {
        public override void HandleTreasureData(CS_TreasureData request, Connection connection)
        {
                    connection.Send(new SC_TreasureData
                    {
                        Field1 =
                        {
                            [60015] = new SC_TreasureData_F1ValueType
                            {
                                Field1 = 1,
                                Field2 = 0,
                                Field3 = false,
                                Field4 =
                                {
                                    [1001] = new SC_TreasureData_F1ValueType_F4ValueType
                                    {
                                        Field1 = (Enum_None_Unlock_Received)1,
                                        Field2 = 0,
                                    },
                                },
                                Field5 = new SC_TreasureData_F1ValueType_F5Type
                                {
                                    Field1 = { },
                                    Field2 = { },
                                    Field3 = { },
                                    Field4 = false,
                                },
                            },
                        },
                    });
        }

    }
}
