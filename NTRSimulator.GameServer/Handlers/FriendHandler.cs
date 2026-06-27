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
                Marks = { },
                MIBABEHJCIK = { },
                Friends = { },
                BHJLKLNBAFO = { },
            });
        }

        public override void HandleFriendApplyList(CS_FriendApplyList request, Connection connection)
        {
            connection.Send(new SC_FriendApplyList
            {
                Apps = { },
            });
        }

        public override void HandleRefreshFriends(CS_RefreshFriends request, Connection connection)
        {
            var response = new SC_RefreshFriends
            {
                Marks = { },
                MIBABEHJCIK = { },
            };
            // response.Field4[11651UL] = CreateFriendBrief(11651, "雷蒙先生", 21247, 24057);
            response.Field4[1UL] = CreateFriendBrief(1, "Raymond (雷蒙先生)", 21257, 24023);
            response.Field4[2] = CreateFriendBrief(2, "95（好女孩）", 21050, 24060);
            response.Field4[3] = CreateFriendBrief(3, "雨中每亩", 1021035, 24160);

            connection.SendAutoEncrypted(response);
        }

        private static Friend CreateFriendBrief(ulong id, string name, uint avatarId, uint avatarFrameId)
        {
            return new Friend
            {
                Id = id,
                User = new BinaryUser
                {
                    Data = new User
                    {
                        Uid = id,
                        Name = name,
                        Level = 60,
                        Sex = Sex.Female,
                        Birthday = 709,
                        Portrait = avatarId,
                        Status = new LoginStatus
                        {
                            Online = true,
                            LoginTime = 12312312,
                            LogoutTime = 123123123,
                            SyncTime = 123123,
                            Client = 1231232323,
                        },
                        GuildId = 123123,
                        GuildName = "ntrsimulator",
                        Title = 23087,
                        Medal = 22004,
                        MaxStage = 30465,
                        AchievementLevel = 123123123,
                        CreatTime = 12321313,
                        GunNum = 56,
                        PortraitFrame = avatarFrameId,
                        Assistants =
                        {
                 
                        },
                        BKIPIIMKNCF = 3,
                        JNLHINHBEIE = 4,
                        IDMOCOHNLDO = new JMMLGEDCIGB
                        {
                            Name = 1163,
                            Level = 40,
                        },
                        MPDCKNHELFH = Enum_None_CashTicket_MonthCardReward_StoreDailyRefresh_JiangyuLoad.WeaponMigrate,
                        DKCAABLJBND = new IHNPFJGBPJB
                        {
                            FEPOFIOMNDB = 1780963200UL,
                            KKLABAKPAPI = 1f,
                        },
                        HEEDJKIDCLI = new KEKFMLHLAMN
                        {
                            Uid = 27,
                            Name = 120,
                        },
                        BPCOAAEMFIB = 1863,
                    }.ToByteString(),
                },
            };
        }
    }
}
