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
                        Field3 = 0,
                        Field10 = new CS_DarkZoneFire_F3Type_F1Type_F21Type_F6Type
                        {
                            Field1 = { },
                            Field2 = { },
                            Field10 = true,
                            Field11 = { },
                            Field12 = { },
                            Field13 = { },
                        },
                        Field11 = new CS_DarkZoneFire_F3Type_F1Type_F21Type_F6Type
                        {
                            Field1 = { },
                            Field2 = { },
                            Field10 = false,
                            Field11 = { },
                            Field12 = { },
                            Field13 = { },
                        },
                        Field12 = { },
                    });
        }

        public override void HandleDarkZoneQuestModeInfo(CS_DarkZoneQuestModeInfo request, Connection connection)
        {
                    connection.Send(new SC_DarkZoneQuestModeInfo
                    {
                        Field1 = { },
                    });
        }

        public override void HandleDarkZoneWishExp(CS_DarkZoneWishExp request, Connection connection)
        {
                    connection.Send(new SC_DarkZoneWishExp
                    {
                        Field1 = 0,
                    });
        }

        public override void HandleDarkZoneGetWeeklyInfo(CS_DarkZoneGetWeeklyInfo request, Connection connection)
        {
            switch (request.Field1)
            {
                case Enum_All_GunRefresh_MapRecord_QuestInfo_RewardRecord.All:
                    connection.Send(new SC_DarkZoneGetWeeklyInfo
                    {
                        Field1 = Enum_All_GunRefresh_MapRecord_QuestInfo_RewardRecord.All,
                        Field2 = new SC_DarkZoneGetWeeklyInfo_F2Type
                        {
                            Field1 = 1001,
                            Field2 = { },
                            Field4 = Enum_Default_Easy_Normal_Hard.Easy,
                            Field5 =
                            {
                                new SC_DarkZoneGetWeeklyInfo_F2Type_F5Type { Field1 = 3018, Field2 = false },
                                new SC_DarkZoneGetWeeklyInfo_F2Type_F5Type { Field1 = 3006, Field2 = false },
                                new SC_DarkZoneGetWeeklyInfo_F2Type_F5Type { Field1 = 3002, Field2 = false },
                                new SC_DarkZoneGetWeeklyInfo_F2Type_F5Type { Field1 = 3013, Field2 = false },
                            },
                            Field6 = 1779500060L,
                            Field7 = { },
                            Field8 = { },
                            Field10 = { },
                        },
                    });
                    break;
            }
        }

        public override void HandleDarkZoneGetEthnicInfo(CS_DarkZoneGetEthnicInfo request, Connection connection)
        {
            connection.Send(new SC_DarkZoneGetEthnicInfo
            {
                Field1 = 0,
                Field2 = 0,
                Field3 = 0,
                Field4 = 0,
                Field5 = 0,
                Field6 = { },
                Field7 = 170063,
                Field8 = { },
                Field9 = 0,
            });
        }

        public override void HandleDarkZoneGetUnlockEggStage(CS_DarkZoneGetUnlockEggStage request, Connection connection)
        {
            connection.Send(new SC_DarkZoneGetUnlockEggStage
            {
                Field1 = { },
            });
        }

    }
}
