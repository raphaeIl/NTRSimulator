using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class DarkZoneHandler : DarkZoneHandlerBase
    {
        public override void HandleDarkZoneStorage(CS_DarkZoneStorage request, Connection connection)
        {
                    connection.Send(new SC_DarkZoneStorage
                    {
                        StorageBuyTimes = 0,
                        Storage = new uint32
                        {
                            Id = { },
                            Others = { },
                            House = true,
                            Bag = { },
                            Equips = { },
                            Field13 = { },
                        },
                        Bag = new uint32
                        {
                            Id = { },
                            Others = { },
                            House = false,
                            Bag = { },
                            Equips = { },
                            Field13 = { },
                        },
                        Equips = { },
                    });
        }

        public override void HandleDarkZoneQuestModeInfo(CS_DarkZoneQuestModeInfo request, Connection connection)
        {
                    connection.Send(new SC_DarkZoneQuestModeInfo
                    {
                        JIAMDNEMBAK = { },
                    });
        }

        public override void HandleDarkZoneWishExp(CS_DarkZoneWishExp request, Connection connection)
        {
                    connection.Send(new SC_DarkZoneWishExp
                    {
                        Exp = 0,
                    });
        }

        public override void HandleDarkZoneGetWeeklyInfo(CS_DarkZoneGetWeeklyInfo request, Connection connection)
        {
            switch (request.IPGJJLJMEBO)
            {
                case CS_DarkZoneGetWeeklyInfo.Types.EPIBDODMBLN.All:
                    connection.Send(new SC_DarkZoneGetWeeklyInfo
                    {
                        IPGJJLJMEBO = CS_DarkZoneGetWeeklyInfo.Types.EPIBDODMBLN.All,
                        BCCILNBHDAO = new HBMBNIHMKLI
                        {
                            ActivityId = 1001,
                            TalentId = { },
                            Difficulty = HBMBNIHMKLI.Types.FHOMGAKNIAF.Easy,
                            Quests =
                            {
                                new DJIPBLHIDPA { QuestId = 3018, JONLCAGBGJE = false },
                                new DJIPBLHIDPA { QuestId = 3006, JONLCAGBGJE = false },
                                new DJIPBLHIDPA { QuestId = 3002, JONLCAGBGJE = false },
                                new DJIPBLHIDPA { QuestId = 3013, JONLCAGBGJE = false },
                            },
                            FEMJMHOADOI = 1779500060L,
                            LELDCCEAHIO = { },
                            GCACAKMMKKL = { },
                            FHIIMKLFEEH = { },
                        },
                    });
                    break;
            }
        }

        public override void HandleDarkZoneGetEthnicInfo(CS_DarkZoneGetEthnicInfo request, Connection connection)
        {
            connection.Send(new SC_DarkZoneGetEthnicInfo
            {
                CAAMMBOPHLI = 0,
                ADDDENOAOJO = 0,
                FNALHFDBDHB = 0,
                FIIIHMMPLNH = 0,
                Point = 0,
                MGFKLGLDBPE = { },
                PlanId = 170063,
                FELLJFBGNJG = { },
                JIAMIEJEDJJ = 0,
            });
        }

        public override void HandleDarkZoneGetUnlockEggStage(CS_DarkZoneGetUnlockEggStage request, Connection connection)
        {
            connection.Send(new SC_DarkZoneGetUnlockEggStage
            {
                NDINCEOKEOA = { },
            });
        }

    }
}
