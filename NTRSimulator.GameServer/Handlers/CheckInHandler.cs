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
                ActivityCheckin =
                {
                    [60813] = new AIJGCACNFHL { CheckinDone = false, CheckinDay = 1 },
                    [60901] = new AIJGCACNFHL { CheckinDone = false, CheckinDay = 7 },
                    [60607] = new AIJGCACNFHL { CheckinDone = false, CheckinDay = 3 },
                    [60704] = new AIJGCACNFHL { CheckinDone = false, CheckinDay = 7 },
                    [61507] = new AIJGCACNFHL { CheckinDone = false, CheckinDay = 2 },
                    [61002] = new AIJGCACNFHL { CheckinDone = false, CheckinDay = 3 },
                    [63003] = new AIJGCACNFHL { CheckinDone = false, CheckinDay = 3 },
                    [69996] = new AIJGCACNFHL
                    {
                        CheckinDone = false,
                        CheckinDay = 6,
                        BPMBLLOMLNB = new MLODPBBCLEB { CBPFCFLIMKJ = 1729890000 },
                    },
                    [60504] = new AIJGCACNFHL { CheckinDone = false, CheckinDay = 6 },
                    [62103] = new AIJGCACNFHL { CheckinDone = false, CheckinDay = 1 },
                    [61604] = new AIJGCACNFHL { CheckinDone = false, CheckinDay = 2 },
                    [61910] = new AIJGCACNFHL { CheckinDone = false, CheckinDay = 2 },
                    [61705] = new AIJGCACNFHL { CheckinDone = false, CheckinDay = 3 },
                    [61108] = new AIJGCACNFHL { CheckinDone = false, CheckinDay = 7 },
                },
            });
        }

        public override void HandleGetActivityCheckInAnniversary(CS_GetActivityCheckInAnniversary request, Connection connection)
        {
            connection.Send(new SC_GetActivityCheckInAnniversary
            {
                ActivityCheckin = { },
            });
        }

        public override void HandleGetDailyCheckIn(CS_GetDailyCheckIn request, Connection connection)
        {
                    connection.Send(new SC_GetDailyCheckIn
                    {
                        DailyCheckin = new QuestCheckin
                        {
                            CheckinDone = true,
                            LastDayCheckin = false,
                            CheckinId = 1,
                            CheckinDay = 12,
                        },
                        Passive = false,
                    });
        }
    }
}
