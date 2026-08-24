using Google.Protobuf;
using Google.Protobuf.Collections;
using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class FriendHandler : FriendHandlerBase
    {
        public override void HandleFriends(CS_Friends request, Connection connection)
        {
            SC_Friends response = new SC_Friends
            {
                Marks = { },
                MIBABEHJCIK = { },
                BHJLKLNBAFO = { },
            };
            FillFriends(response.Friends);
            connection.SendAutoEncrypted(response);
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
            SC_RefreshFriends response = new SC_RefreshFriends
            {
                Marks = { },
                MIBABEHJCIK = { },
            };
            FillFriends(response.Friends);
            connection.SendAutoEncrypted(response);
        }

        private static void FillFriends(MapField<ulong, Friend> friends)
        {
            friends[1UL] = CreateFriendBrief(1, "Raymond (雷蒙先生)", 21257, 24023);
            friends[2UL] = CreateFriendBrief(2, "95（好女孩）", 21050, 24060);
            friends[3UL] = CreateFriendBrief(3, "雨中每亩", 21015, 24160);
        }

        private static Friend CreateFriendBrief(ulong id, string name, uint avatarId, uint avatarFrameId)
        {
            User user = new User
            {
                Uid = id,
                Name = name,
                Level = 60,
                Sex = Sex.Female,
                Birthday = 709,
                Portrait = avatarId,
                PortraitFrame = avatarFrameId,
                Status = new User.Types.LoginStatus
                {
                    Online = true,
                    ECFLDOJNKDB = 1,
                    LBNHBMFFFJI = 2,
                    SyncTime = 3,
                },
                Title = 23087,
                Medal = 22004,
                MaxStage = 30465,
                AchievementLevel = 1,
                CreatTime = 1,
                GunNum = 56,
                Assistants =
                {
                    CreateAssistant(0, 1047, 60, 1104700, 1),
                    CreateAssistant(1, 1032, 60, 1103200, 2),
                    CreateAssistant(2, 1025, 60, 1102500, 3, grade: 2),
                },
                IDMOCOHNLDO = new User.Types.JMMLGEDCIGB
                {
                    JBMNHBBGAHP = false,
                    OHPHNKCEGCM = 1,
                    GPJEDMDBIIJ = 1,
                },
                MPDCKNHELFH = (POAMOPPDEJC)19,
                HEEDJKIDCLI = new User.Types.KEKFMLHLAMN(),
                PMJNEPPFAKF = new User.Types.IBGENNDHELL
                {
                    IKDMNOBMIFE = 1,
                },
            };

            return new Friend
            {
                Id = id,
                User = new BinaryUser
                {
                    Data = user.ToByteString(),
                    IHNCKKDOJLL = new MNCIHOEMEMP
                    {
                        IKDMNOBMIFE = 1,
                    },
                    KAEDHCMMJKP = new POEGGEKHMCO(),
                },
            };
        }

        private static BJMBKFICIAC CreateAssistant(int idx, uint gunId, uint level, uint costumeId, uint gpjl, uint grade = 0)
        {
            return new BJMBKFICIAC
            {
                Idx = idx,
                BKGHHPKAKBL = new KJNEMIMEEIA
                {
                    Id = gunId,
                    Level = level,
                    Grade = grade,
                    CostumeId = costumeId,
                    GPJLLBGIALN = gpjl,
                },
            };
        }
    }
}
