using Google.Protobuf;
using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class GuildHandler : GuildHandlerBase
    {
        public override void HandleGuildInfo(CS_GuildInfo request, Connection connection)
        {
                     connection.Send(new SC_GuildInfo
            {
                Field1 = new SC_GuildInfo_F1Type
                {
                    Field1 = 123123,
                    Field2 = "NTRSimulator",
                    Field3 = 23,
                    Field4 = 123123,
                    Field6 = "ntrsimulator",
                    Field7 = 32,
                    Field8 = 0,
                    Field9 = 3,
                    Field10 = 4,
                    Field11 = 123123,
                    Field12 = "ntrsimulator",
                    Field13 = false,
                    Field14 = 0,
                    Field15 = { 3, 4, 10 },
                    Field16 = { 14, 11, 17, 18, 15 },
                    Field17 = 1,
                    Field18 = 0,
                },
                Field2 = 10004,
                Field3 = false,
                Field4 = 10032,
                Field5 = 60,
            });
        }

        public override void HandleGetGuildBattleMissionInfo(CS_GetGuildBattleMissionInfo request, Connection connection)
        {
         
        }
        public override void HandleGuildMemberList(CS_GuildMemberList request, Connection connection)
        {
            connection.Send(29, new SC_GuildMemberList
            {
                Field1 =
                {
                    new SC_GuildMemberList_F1Type
                    {
                        Field1 = new SC_AsyncPvpHistory_F1Type_F1Type
                        {
                            Field1 = new SC_Login_F1Type
                            {
                                Field1 = 1,
                                Field2 = "ntrsimulator",
                                Field3 = 60,
                                Field5 = Enum_Male_Female.Female,
                                Field6 = 1221,
                                Field7 = 21208,
                                Field10 = new SC_Login_F1Type_F10Type
                                {
                                    Field2 = 123123,
                                    Field3 = 123123,
                                    Field4 = 12313,
                                },
                                Field12 = 12312313,
                                Field13 = "ntrsimulator",
                                Field15 = 23093,
                                Field16 = 22057,
                                Field17 = 10865,
                                Field18 = 123123,
                                Field19 = 123123,
                                Field20 = 59,
                                Field21 = 24153,
                                Field29 =
                                {
                                
                                },
                                Field31 = 3,
                                Field32 = 4,
                                Field34 = new SC_Login_F1Type_F34Type
                                {
                                    Field1 = true,
                                    Field2 = 1162,
                                    Field3 = 40,
                                },
                                Field35 = Enum_None_CashTicket_MonthCardReward_StoreDailyRefresh_JiangyuLoad.WeaponMigrate,
                                Field39 = new SC_HeroModeMark_F1Type
                                {
                                    Field1 = 1312313,
                                    Field2 = 0.899999976f,
                                },
                                Field40 = new SC_Login_F1Type_F40Type
                                {
                                    Field1 = 26,
                                    Field2 = 120,
                                },
                                Field41 = Enum_None_Jiangyu_Max.Jiangyu,
                                Field42 = 1846,
                            }.ToByteString(),
                        },
                        Field2 = (Enum_JobNone_JobLeader_JobManager_JobNormal)1,
                        Field3 = 310,
                        Field4 = 123123,
                        Field5 = 800,
                        Field6 = 8000,
                        Field7 = 13123123,
                        Field8 = 123123123,
                        Field9 = 10001,
                        Field10 = 0,
                        Field11 = 0,
                    },
                },
                Field2 = 123,
            });
        }
        public override void HandleGetGuildSupplyList(CS_GetGuildSupplyList request, Connection connection)
        {
         
        }

        public override void HandleGuildApplyList(CS_GuildApplyList request, Connection connection)
        {

        }

        public override void HandleGetGuildScoreRank(CS_GetGuildScoreRank request, Connection connection)
        {
          
        }
    }
}
