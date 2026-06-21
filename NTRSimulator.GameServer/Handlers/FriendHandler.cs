using Google.Protobuf;
using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class FriendHandler : FriendHandlerBase
    {
        public override void HandleFriends(CS_Friends request, Connection connection)
        {
            connection.Send(new SC_Friends
            {
                Field2 = { },
                Field3 = { },
                Field4 = { },
                Field5 = { },
            });
        }

        public override void HandleFriendApplyList(CS_FriendApplyList request, Connection connection)
        {
            connection.Send(new SC_FriendApplyList
            {
                Field1 = { },
            });
        }

        public override void HandleRefreshFriends(CS_RefreshFriends request, Connection connection)
        {
            var response = new SC_RefreshFriends
            {
                Field2 = { },
                Field3 = { },
            };
            // response.Field4[11651UL] = CreateFriendBrief(11651, "雷蒙先生", 21247, 24057);
            response.Field4[1UL] = CreateFriendBrief(1, "Raymond (雷蒙先生)", 21257, 24023);
            response.Field4[2] = CreateFriendBrief(2, "95（好女孩）", 21050, 24060);
            response.Field4[3] = CreateFriendBrief(3, "雨中每亩", 1021035, 24160);

            connection.SendAutoEncrypted(response);
        }

        private static SC_FriendAdd_F2Type CreateFriendBrief(ulong id, string name, uint avatarId, uint avatarFrameId)
        {
            return new SC_FriendAdd_F2Type
            {
                Field1 = id,
                Field2 = new SC_AsyncPvpHistory_F1Type_F1Type
                {
                    Field1 = new SC_Login_F1Type
                    {
                        Field1 = id,
                        Field2 = name,
                        Field3 = 60,
                        Field5 = Enum_Male_Female.Female,
                        Field6 = 709,
                        Field7 = avatarId,
                        Field10 = new SC_Login_F1Type_F10Type
                        {
                            Field1 = true,
                            Field2 = 12312312,
                            Field3 = 123123123,
                            Field4 = 123123,
                            Field5 = 1231232323,
                        },
                        Field12 = 123123,
                        Field13 = "ntrsimulator",
                        Field15 = 23087,
                        Field16 = 22004,
                        Field17 = 30465,
                        Field18 = 123123123,
                        Field19 = 12321313,
                        Field20 = 56,
                        Field21 = avatarFrameId,
                        Field29 =
                        {
                 
                        },
                        Field31 = 3,
                        Field32 = 4,
                        Field34 = new SC_Login_F1Type_F34Type
                        {
                            Field2 = 1163,
                            Field3 = 40,
                        },
                        Field35 = Enum_None_CashTicket_MonthCardReward_StoreDailyRefresh_JiangyuLoad.WeaponMigrate,
                        Field39 = new SC_HeroModeMark_F1Type
                        {
                            Field1 = 1780963200UL,
                            Field2 = 1f,
                        },
                        Field40 = new SC_Login_F1Type_F40Type
                        {
                            Field1 = 27,
                            Field2 = 120,
                        },
                        Field42 = 1863,
                    }.ToByteString(),
                },
            };
        }
    }
}
