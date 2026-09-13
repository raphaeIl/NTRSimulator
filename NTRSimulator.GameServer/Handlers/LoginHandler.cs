using Google.Protobuf;
using Newtonsoft.Json;
using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;
using NTRSimulator.Common.Protocol;
using NTRSimulator.Database.Entities;
using NTRSimulator.Database.Services;
using NTRSimulator.GameServer.Services;
using NTRSimulator.Common.Table;
using Serilog;
using NTRSimulator.Common.Manager;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class LoginHandler(
        IInventoryService inventoryService,
        IAccountService accountService,
        ITableService tableService,
        IRecruitmentService recruitment
        ) : LoginHandlerBase
    {
        public override void HandleLogin(CS_Login req, Connection connection)
        {
            var session = PlayerSessionManager.Instance.GetSession(req.Token);
            if (session == null)
            {
                Log.Warning("Invalid or expired token during login.");
                return;
            }

            connection.Session = session;

            var account = accountService.GetByUid(session.Uid);
            if (account == null)
            {
                Log.Warning("Account not found for uid {Uid}.", session.Uid);
                return;
            }

            connection.Account = account;

            // if this is the first login, give player default guns
            // (this is not the correct place to do this, better to be done at tutorial login instead of normal, not implemented yet)
            if (account.Guns.Count == 0)
            {
                //inventoryService.AddAll<GunEntity>(account.Uid);
                List<GunData> gunData = tableService.GetTable<GunData>();
                List<InitItemCsData> initItemData = tableService.GetTable<InitItemCsData>();

                GunData[] defaultGuns = gunData.Where(gun => initItemData.Select(item => item.Id).Contains(gun.Id)).ToArray();

                foreach (var defaultGunData in defaultGuns)
                {
                    inventoryService.Add<GunEntity>(account.Uid, GunService.CreateDefault(defaultGunData, level: 1));
                }
            }


            Log.Information("CS_Login: " + JsonConvert.SerializeObject(req, Formatting.Indented));

            SC_RecordStatisticUpdate scRecordStatisticUpdate = new SC_RecordStatisticUpdate()
            {
                CHEOLEADCCB = 1,
                MDAIIFCGJMO = 1,
                BCGNJMDFLDG = 0
            };

            SC_Login endgame_acc_scLogin = new()
            {
                User = new User
                {
                    Uid = 1,
                    Name = "ntrsimulator",
                    Level = 60,
                    Sex = Sex.Female,
                    Birthday = 101,
                    Portrait = 21089, // avatar PlayerAvatarData
                    PortraitFrame = 24164, // frame HeadFrameData
                    Motto = "aaa",
                    JKOCEOKNAOL = 0,
                    Title = 25000,
                    Medal = 22010,
                    MaxStage = 31065,
                    AchievementLevel = 16843009,
                    CreatTime = 123213123,
                    GunNum = 55,
                    MonthCard = { },
                    NewMedal = { 22081, 22082, 22083, 22084 },
                    AchievementNum = { 73, 95, 120, 108, 78 },
                    Status = new User.Types.LoginStatus
                    {
                        Online = false,
                        LoginTime = 1780801750,
                        LogoutTime = 1780801908,
                        SyncTime = 1780802125,
                        Client = 0
                    },
                    Assistant = null,
                    GuildId = 123123,
                    GuildName = "ntrsimulator",
                    GuildNextJoinTime = 0,
                    BKIPIIMKNCF = 3,
                    JNLHINHBEIE = 4,
                    COGLOCMDFOH = false,
                    IDMOCOHNLDO = new User.Types.JMMLGEDCIGB() { JBMNHBBGAHP = true, OHPHNKCEGCM = 1162, GPJEDMDBIIJ = 40 },
                    NBGNEBFEPON = "",
                    DELPACHDBFG =
                    {
                
                    },
                    AGMEOHPHANG =
                    {
                       new User.Types.DBECHFOOJOO
                       {
                           WeaponId = 11044,
                           GunId = 4134104,
                           Mods =
                           {
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 20116453, GunId = 7332824 },
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 10112353, GunId = 7331055 },
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 120115353, GunId = 7335814 },
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 30111353, GunId = 0 }
                           },
                           BreakTimes = 1
                       },
                       new User.Types.DBECHFOOJOO
                       {
                           WeaponId = 10523,
                           GunId = 4134085,
                           Mods =
                           {
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 20113453, GunId = 7332345 },
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 10112353, GunId = 7231355 },
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 120116353, GunId = 6315664 },
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 30116353, GunId = 6313484 }
                           },
                           BreakTimes = 1
                       },
                       new User.Types.DBECHFOOJOO
                       {
                           WeaponId = 10002,
                           GunId = 4132084,
                           Mods =
                           {
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 20127453, GunId = 6312264 },
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 10126353, GunId = 7331055 },
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 120127353, GunId = 7335814 },
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 30125353, GunId = 6313514 }
                           },
                           BreakTimes = 1
                       },
                       new User.Types.DBECHFOOJOO
                       {
                           WeaponId = 11038,
                           GunId = 4134104,
                           Mods =
                           {
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 20117453, GunId = 7332824 },
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 10115353, GunId = 7331055 },
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 120117353, GunId = 7335814 },
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 30115353, GunId = 0 }
                           },
                           BreakTimes = 1
                       },
                       new User.Types.DBECHFOOJOO
                       {
                           WeaponId = 11044,
                           GunId = 0,
                           Mods =
                           {
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 0, GunId = 0 },
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 0, GunId = 0 },
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 0, GunId = 0 },
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 0, GunId = 0 }
                           },
                           BreakTimes = 1
                       },
                       new User.Types.DBECHFOOJOO
                       {
                           WeaponId = 10333,
                           GunId = 0,
                           Mods =
                           {
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 0, GunId = 0 },
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 0, GunId = 0 },
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 0, GunId = 0 },
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 0, GunId = 0 }
                           },
                           BreakTimes = 1
                       },
                       new User.Types.DBECHFOOJOO
                       {
                           WeaponId = 10333,
                           GunId = 0,
                           Mods =
                           {
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 0, GunId = 0 },
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 0, GunId = 0 },
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 0, GunId = 0 },
                               new User.Types.BJDIMMICNPG { FNKBBPNGFBC = 0, GunId = 0 }
                           },
                           BreakTimes = 1
                       },
                       new User.Types.DBECHFOOJOO
                       {
                           WeaponId = 0,
                           GunId = 0,
                           Mods = {}
                       },
                       new User.Types.DBECHFOOJOO
                       {
                           WeaponId = 0,
                           GunId = 0,
                           Mods = {}
                       }
                    },
                    MPDCKNHELFH = (POAMOPPDEJC)16,
                    KPGENCJDIFM =
                    {
                          false,
                          false,
                          true,
                          true,
                          true,
                          true,
                          true,
                          true,
                          true,
                          true,
                          true,
                          true,
                          true,
                          true,
                          true,
                          true,
                          true
                    },
                    OAIMENKAOEO = 25001,
                    OBMLMKKHBIA = new LAHOFDCJGEM()
                    {
                        NBONFIHFCBE =
                        {
                            1647247360,
                            1645478144,
                            1638859520,
                            1640563712,
                            1645678848,
                            1645744386,
                            1649742336,
                            1646723584,
                            1646724352,
                            1645413888,
                            1645545216,
                            1645611008,
                            1645807872,
                            1645873664,
                            1646136064,
                            1646201856,
                            1647447296,
                            1647513088,
                            1647578880,
                            1647710208,
                            1647841282,
                            1647907330,
                            1648300800,
                            1648366592
                        },
                        FJFCNNNPACN = 1335002,
                        ELANFNLJCFM = 1335101
                    },
                    DKCAABLJBND = new IHNPFJGBPJB()
                    {
                        FEPOFIOMNDB = 1780963200,
                        KKLABAKPAPI = 0.9f
                    },
                    HEEDJKIDCLI = new User.Types.KEKFMLHLAMN()
                    {
                        EPCCANNLACO = 26,
                        GPJEDMDBIIJ = 120
                    },
                    LPLPBLGJMEG = 0,
                    BPCOAAEMFIB = 2294,
                    HOLPILIHFIK = 0,
                    PMJNEPPFAKF = null
                },
                NormalGacha = 0,
                SimCombat = { },
                BroadcastSign = "",
                PrivateSign = "0",
                CliResCropty = "abcdefghabcdefgh",
                Status = UserStatus.StatusNormal,
                DzStatus = LIJEDJGNKBD.Types.Status.Normal,
                OFLLLHEJEDO = 8,
                JNJEOPFIHJP = true,
                DHMOAKCALLG = ""
            };

            SC_ActivityBackDailyRefresh scActivityBackDailyRefresh = new SC_ActivityBackDailyRefresh()
            {
                Info = new IGHEKKLGNLA()
                {
                    IAPDLJKLLNM = 1,
                    OpenTime = 1779500060,
                    HNAKPBEGGFK = 3,
                    HPABIPEOBKN = 1779518860,
                    IEHFGOMCBCN = false,
                    CJOINHJCPII = 0,
                    CheckinDone = false,
                    Version = 2,
                            ANGHCINLCJO = new OCLANMMGEGA()
                    {
                        Type = IFIMADGKJOO.Normal,
                        Level = 0,
                        LMNBPEBDCKG = { },
                        IMMBMDAPFEN = { },
                    },
                },
            };
            SC_Login scLogin = new SC_Login()
            {
                User = new User()
                {
                    Uid = 2225766,
                    Name = "kebjgw",
                    Level = 60,
                    Sex = Sex.Female,
                    Birthday = 101,
                    Portrait = 21999,
                    PortraitFrame = 0,
                    Motto = "",
                    JKOCEOKNAOL = 0,
                    Title = 23001,
                    Medal = 22001,
                    MaxStage = 10110,
                    AchievementLevel = 16843009,
                    CreatTime = 1703592104,
                    GunNum = 4,
                    MonthCard = { },
                    Status = new User.Types.LoginStatus()
                    {
                        Online = false,
                        LoginTime = 1779501594,
                        LogoutTime = 1779501613,
                        SyncTime = 1779501613,
                        Client = 0,
                    },
                    Assistant = null,
                    GuildId = 0,
                    GuildName = "",
                    GuildNextJoinTime = 0,
                    BKIPIIMKNCF = 0,
                    JNLHINHBEIE = 0,
                    COGLOCMDFOH = false,
                    IDMOCOHNLDO = new User.Types.JMMLGEDCIGB()
                    {
                        JBMNHBBGAHP = false,
                        OHPHNKCEGCM = 0,
                        GPJEDMDBIIJ = 0,
                    },
                    NBGNEBFEPON = "",
                    NewMedal = { 22023, 22020, 22019, 22022 },
                    AchievementNum = { 0, 7, 28, 79, 1 },
                    DELPACHDBFG = { },
                    Assistants = { },
                    AGMEOHPHANG =
                    {
                        new User.Types.DBECHFOOJOO(),
                        new User.Types.DBECHFOOJOO(),
                        new User.Types.DBECHFOOJOO(),
                        new User.Types.DBECHFOOJOO(),
                        new User.Types.DBECHFOOJOO(),
                        new User.Types.DBECHFOOJOO(),
                        new User.Types.DBECHFOOJOO(),
                        new User.Types.DBECHFOOJOO(),
                        new User.Types.DBECHFOOJOO(),
                    },
                    MPDCKNHELFH = (POAMOPPDEJC)16,
                    KPGENCJDIFM =
                    {
                        false,
                        false,
                        true,
                        true,
                        true,
                        true,
                        true,
                        true,
                        true,
                        true,
                        true,
                        true,
                        true,
                        true,
                        true,
                        true,
                        true,
                    },
                    OAIMENKAOEO = 0,
                    OBMLMKKHBIA = new LAHOFDCJGEM()
                    {
                        NBONFIHFCBE = { },
                        FJFCNNNPACN = 1335001,
                        ELANFNLJCFM = 1335101,
                    },
                    DKCAABLJBND = null,
                    HEEDJKIDCLI = new User.Types.KEKFMLHLAMN()
                    {
                        EPCCANNLACO = 0,
                        GPJEDMDBIIJ = 0,
                    },
                    LPLPBLGJMEG = 0,
                    BPCOAAEMFIB = 60,
                    HOLPILIHFIK = 0,
                    PMJNEPPFAKF = null,
                },
                NormalGacha = 0,
                SimCombat = { },
                BroadcastSign = "",
                PrivateSign = "0",
                CliResCropty = "abcdefghabcdefgh",
                Status = UserStatus.StatusNormal,
                DzStatus = LIJEDJGNKBD.Types.Status.Normal,
                OFLLLHEJEDO = 8,
                JNJEOPFIHJP = true,
                DHMOAKCALLG = "",
            };

            //scLogin = PcapUtils.GetPacketFromPcap<SC_Login>(MsgId.MsgScLogin, PacketType.RESPONSE);

            SC_Resource scResource = new()
            {
                Res = new Resource()
                {
                    ResourceEx =
                    {
                        0,
                        10555,
                        30919838,
                        0,
                        500,
                        1500,
                        240,
                        3,
                        167,
                        3,
                        260,
                        0,
                        253,
                        35520,
                        0,
                        0,
                        4725,
                        0,
                        0,
                        0,
                        0,
                        0,
                        1800,
                        0,
                        0,
                        12208280,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        1500,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        126,
                        0,
                        4758,
                        0,
                        161605,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        5,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0
                    },
                    StaminaTypeResource =
                    {
                        [101] = new()
                        {
                            RefreshTime = 1779163704,
                            Value = 183
                        },
                        [102] = new()
                        {
                            RefreshTime = 1779163939,
                            Value = 3
                        },
                        [106] = new()
                        {
                            RefreshTime = 1779163939,
                            Value = 5
                        }
                    },

                    MonthCard =
                    {
                    },

                    OFHIHPPKKJP =
                    {
                        [261] = new JIDLNNFNGGF()
                        {
                            TsLimit = new POOPHBNGGBK()
                            {
                                ExpireTime = { 1730214970 }
                            }
                        }
                    }
                }
            };

            scResource.Res.ResourceEx[1] = 123456789;
            scResource.Res.ResourceEx[10] = 123456789;
            scResource.Res.ResourceEx[12] = 123456789;
            scResource.Res.ResourceEx[45] = 123456789;

            SC_Sync scSync = new SC_Sync()
            {
                Timestamp = connection.ServerTimeSeconds,
                ActiveTime = 0,
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync = new SC_PlayerStatusCounterSync()
            {
                Num = 8,
                Watchers =
                {
                    new PELLFAAPKOL() { SystemId = 63, UniqueId = 40011 },
                },
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync2 = new SC_PlayerStatusCounterSync()
            {
                Num = 8,
                Watchers =
                {
                    new PELLFAAPKOL() { SystemId = 63, UniqueId = 1581 },
                },
            };
            SC_Record scRecord = new SC_Record()
            {
                Gacha = { },
                Exp = { true, true, true, true, true },
                Limit = { },
                OBJIBOMKEKD = 1,
                NJHKLBALAJA =
                {
                    { 4101, new RecordRoomDetail() { DetailIdx = 1027, State = false } },
                },
            };
            // Include guarantees for banners added after the original login fixture.
            foreach (GachaData banner in tableService.GetTable<GachaData>())
                scRecord.Guarantee[banner.Id] = banner.SsrTimes;

            SC_DarkZoneStep1RoomBasicInfo scDarkZoneStep1RoomBasicInfo = new SC_DarkZoneStep1RoomBasicInfo()
            {
                Room = new DarkZoneRoom()
                {
                    RoomStcId = 0,
                    RoomId = 0,
                    MapId = 0,
                    QuestId = 0,
                    DzType = 0,
                    GroupId = 0,
                },
                RecnnFuncType = SC_DarkZoneStep1RoomBasicInfo.Types.RecnnFuncType.Enable,
                OEPFKCENLIK = null,
            };
            SC_HotfixNoticeSync scHotfixNoticeSync = new SC_HotfixNoticeSync()
            {
                MGDPMAGKADP =
                {
                    {
                        1,
                        new NNAJHDNAMOB()
                        {
                            Id = 1,
                            BeginTime = 1774266600,
                            FGBHHHIHBPO = 10,
                            KNENOHBINPG = 0,
                        }
                    },
                    {
                        2,
                        new NNAJHDNAMOB()
                        {
                            Id = 2,
                            BeginTime = 1774266900,
                            FGBHHHIHBPO = 5,
                            KNENOHBINPG = 0,
                        }
                    },
                    {
                        3,
                        new NNAJHDNAMOB()
                        {
                            Id = 3,
                            BeginTime = 1774267140,
                            FGBHHHIHBPO = 1,
                            KNENOHBINPG = 0,
                        }
                    },
                },
            };


            connection.Send(scRecordStatisticUpdate);

            //01 00 00 6A 09 
            connection.SendAutoEncrypted<IMessage>(
                scActivityBackDailyRefresh,
                endgame_acc_scLogin,
                scResource,
                scSync,
                playerStatusCounterSync,
                playerStatusCounterSync2,
                scRecord,
                recruitment.GetBannerList(connection),
                scDarkZoneStep1RoomBasicInfo,
                scHotfixNoticeSync);

            SC_GetGamePlayStatus sCGetGamePlayStatus3 = new SC_GetGamePlayStatus()
            {
                CMOBODHPHOC = new LFBPPCEEHFH()
                {
                    NrtPvpBrief = new OILOODNPDEK()
                    {
                        MMHJJHLFCPA = new NrtPvpSeason()
                        {
                            LevelType = 1,
                            PlanId = 0,
                            LastPlanId = 0,
                            SeasonId = 30034,
                            LastSeasonId = 20137
                        }
                    }
                }
            };
            connection.Send(sCGetGamePlayStatus3);

            SC_PlayerStatusCounterSync playerStatusCounterSync3 = new SC_PlayerStatusCounterSync()
            {
                Num = 0,
                Watchers =
                {
                    new PELLFAAPKOL() { SystemId = 63, UniqueId = 1321 },
                },
            };
            SC_GetGamePlayStatus scGetGamePlayStatus2 = new SC_GetGamePlayStatus()
            {
                CMOBODHPHOC = new LFBPPCEEHFH()
                {
                    SocialBrief = new HIFMACANJNL()
                    {
                        FEBHDBIJMDP = false,
                        AKOFNJNGHLA = 0,
                        CNKBOBHDPIB = 0,
                    }
                }
            };

            connection.SendEncrypted(0, playerStatusCounterSync3, scGetGamePlayStatus2);

            SC_MomentFetch scMomentFetch = new SC_MomentFetch()
            {
                KCMDKLFKKGM = { },
                IEKMOJNONDP = 0
            };
            connection.Send(scMomentFetch);
        }
    }
}
