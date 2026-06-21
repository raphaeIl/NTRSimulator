using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class CheckInHandler : CheckInHandlerBase
    {
        public override void HandleGetActivityCheckIn(CS_GetActivityCheckIn request, Connection connection)
        {
            connection.Send(new SC_GetActivityCheckIn
            {
                Field16 =
                {
                    [60813] = new SC_GetActivityCheckIn_F16ValueType { Field1 = false, Field2 = 1 },
                    [60901] = new SC_GetActivityCheckIn_F16ValueType { Field1 = false, Field2 = 7 },
                    [60607] = new SC_GetActivityCheckIn_F16ValueType { Field1 = false, Field2 = 3 },
                    [60704] = new SC_GetActivityCheckIn_F16ValueType { Field1 = false, Field2 = 7 },
                    [61507] = new SC_GetActivityCheckIn_F16ValueType { Field1 = false, Field2 = 2 },
                    [61002] = new SC_GetActivityCheckIn_F16ValueType { Field1 = false, Field2 = 3 },
                    [63003] = new SC_GetActivityCheckIn_F16ValueType { Field1 = false, Field2 = 3 },
                    [69996] = new SC_GetActivityCheckIn_F16ValueType
                    {
                        Field1 = false,
                        Field2 = 6,
                        Field3 = new SC_ActivityGachaSettle_F3Type_F3Type { Field1 = 1729890000 },
                    },
                    [60504] = new SC_GetActivityCheckIn_F16ValueType { Field1 = false, Field2 = 6 },
                    [62103] = new SC_GetActivityCheckIn_F16ValueType { Field1 = false, Field2 = 1 },
                    [61604] = new SC_GetActivityCheckIn_F16ValueType { Field1 = false, Field2 = 2 },
                    [61910] = new SC_GetActivityCheckIn_F16ValueType { Field1 = false, Field2 = 2 },
                    [61705] = new SC_GetActivityCheckIn_F16ValueType { Field1 = false, Field2 = 3 },
                    [61108] = new SC_GetActivityCheckIn_F16ValueType { Field1 = false, Field2 = 7 },
                },
            });
        }

        public override void HandleGetActivityCheckInAnniversary(CS_GetActivityCheckInAnniversary request, Connection connection)
        {
            connection.Send(new SC_GetActivityCheckInAnniversary
            {
                Field1 = { },
            });
        }

        public override void HandleGetDailyCheckIn(CS_GetDailyCheckIn request, Connection connection)
        {
                    connection.Send(new SC_GetDailyCheckIn
                    {
                        Field1 = new SC_GetDailyCheckIn_F1Type
                        {
                            Field1 = true,
                            Field2 = false,
                            Field3 = 1,
                            Field4 = 12,
                        },
                        Field2 = false,
                    });
        }
    }
}
