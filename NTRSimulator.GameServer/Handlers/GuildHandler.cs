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
                EGACCPJBFAD = new OJHDHMDKIEK
                {
                    Id = 123123,
                    Name = "NTRSimulator",
                    Level = 23,
                    NLDDNFLPMNI = "ntrsimulator",
                    ENPCEGHDOGP = 32,
                    NEDCICLLAGJ = 0,
                    CPAHOGDFLFH = 3,
                    NDIFIFKGALK = 4,
                    PBMLPPJBCHN = 123123,
                    GBJBCGBOMAC = "ntrsimulator",
                    FFFHMCINLBK = false,
                    FAIMMOELGOE = 0,
                    IDBBNMIDLAE = { 3, 4, 10 },
                    DMBCJBNCGPE = { 14, 11, 17, 18, 15 },
                    FKMGNLFONKO = 1,
                    LBCCLINKDMP = 0,
                },
                QuestId = 10004,
                MDDICHKNEPE = false,
                SeasonId = 10032,
                ONBCNAAHJMA = 60,
            });
        }

        public override void HandleGetGuildBattleMissionInfo(CS_GetGuildBattleMissionInfo request, Connection connection)
        {
         
        }
        public override void HandleGuildMemberList(CS_GuildMemberList request, Connection connection)
        {
            connection.Send(29, new SC_GuildMemberList
            {
                LLEPAHIHEBE =
                {
                    new IOFPLLMGFNF
                    {
                        PBJAABKNKAP = new BinaryUser
                        {
                            Data = new User
                            {
                                Uid = 1,
                                Name = "ntrsimulator",
                                Level = 60,
                                Sex = Sex.Female,
                                Birthday = 1221,
                                Portrait = 21208,
                                Status = new User.Types.LoginStatus
                                {
                                    LoginTime = 123123,
                                    LogoutTime = 123123,
                                    SyncTime = 12313,
                                },
                                GuildId = 12312313,
                                GuildName = "ntrsimulator",
                                Title = 23093,
                                Medal = 22057,
                                MaxStage = 10865,
                                AchievementLevel = 123123,
                                CreatTime = 123123,
                                GunNum = 59,
                                PortraitFrame = 24153,
                                Assistants =
                                {
                                
                                },
                                BKIPIIMKNCF = 3,
                                JNLHINHBEIE = 4,
                                IDMOCOHNLDO = new User.Types.JMMLGEDCIGB
                                {
                                    JBMNHBBGAHP = true,
                                    OHPHNKCEGCM = 1162,
                                    GPJEDMDBIIJ = 40,
                                },
                                MPDCKNHELFH = (POAMOPPDEJC)16,
                                DKCAABLJBND = new IHNPFJGBPJB
                                {
                                    FEPOFIOMNDB = 1312313,
                                    KKLABAKPAPI = 0.899999976f,
                                },
                                HEEDJKIDCLI = new User.Types.KEKFMLHLAMN
                                {
                                    EPCCANNLACO = 26,
                                    GPJEDMDBIIJ = 120,
                                },
                                LPLPBLGJMEG = CFOOAELCKKF.BriefVersionJiangyu,
                                BPCOAAEMFIB = 1846,
                            }.ToByteString(),
                        },
                        DAGBCMOABEA = (BLPACHOMKPJ)1,
                        INFMFKJFNBA = 310,
                        DPJNCPIHBFF = 123123,
                        KLHLMGPNKOP = 800,
                        GPFONDGMFDM = 8000,
                        Uid = 13123123,
                        BJDMOBCMDAB = 123123123,
                        GDBJIKKMKFD = 10001,
                        BLLPHFJICKN = 0,
                        JMLAJJFAGLH = 0,
                    },
                },
                PEFCJOKNJCN = 123,
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
