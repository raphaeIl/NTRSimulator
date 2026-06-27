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
        ITableService tableService
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

                GunData[] defaultGuns = gunData.Where(gun => initItemData.Select(item => item.ItemId).Contains(gun.GunId)).ToArray();

                foreach (var defaultGun in defaultGuns)
                {
                    inventoryService.Add<GunEntity>(account.Uid, new GunEntity()
                    {
                        GunId = defaultGun.GunId,
                        Level = 1,
                        CostumeId = defaultGun.CostumeId,
                        TimeCreated = DateTime.UtcNow
                    });
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
                    Exp = 0,
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
                    Status = new LoginStatus
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
                    IDMOCOHNLDO = new JMMLGEDCIGB()
                    {
                        Uid = true,
                        Name = 1162,
                        Level = 40
                    },
                    NBGNEBFEPON = "",
                    DELPACHDBFG =
                    {
                
                    },
                    AGMEOHPHANG =
                    {
                       new DBECHFOOJOO
                       {
                           Uid = 11044,
                           Name = 4134104,
                           Level =
                           {
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 20116453, Name = 7332824 },
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 10112353, Name = 7331055 },
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 120115353, Name = 7335814 },
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 30111353, Name = 0 }
                           },
                           Exp = 1
                       },
                       new DBECHFOOJOO
                       {
                           Uid = 10523,
                           Name = 4134085,
                           Level =
                           {
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 20113453, Name = 7332345 },
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 10112353, Name = 7231355 },
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 120116353, Name = 6315664 },
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 30116353, Name = 6313484 }
                           },
                           Exp = 1
                       },
                       new DBECHFOOJOO
                       {
                           Uid = 10002,
                           Name = 4132084,
                           Level =
                           {
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 20127453, Name = 6312264 },
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 10126353, Name = 7331055 },
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 120127353, Name = 7335814 },
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 30125353, Name = 6313514 }
                           },
                           Exp = 1
                       },
                       new DBECHFOOJOO
                       {
                           Uid = 11038,
                           Name = 4134104,
                           Level =
                           {
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 20117453, Name = 7332824 },
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 10115353, Name = 7331055 },
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 120117353, Name = 7335814 },
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 30115353, Name = 0 }
                           },
                           Exp = 1
                       },
                       new DBECHFOOJOO
                       {
                           Uid = 11044,
                           Name = 0,
                           Level =
                           {
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 0, Name = 0 },
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 0, Name = 0 },
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 0, Name = 0 },
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 0, Name = 0 }
                           },
                           Exp = 1
                       },
                       new DBECHFOOJOO
                       {
                           Uid = 10333,
                           Name = 0,
                           Level =
                           {
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 0, Name = 0 },
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 0, Name = 0 },
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 0, Name = 0 },
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 0, Name = 0 }
                           },
                           Exp = 1
                       },
                       new DBECHFOOJOO
                       {
                           Uid = 10333,
                           Name = 0,
                           Level =
                           {
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 0, Name = 0 },
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 0, Name = 0 },
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 0, Name = 0 },
                               new SC_Login_F1Type_F30Type_F3Type { Uid = 0, Name = 0 }
                           },
                           Exp = 1
                       },
                       new DBECHFOOJOO
                       {
                           Uid = 0,
                           Name = 0,
                           Level = {},
                           Exp = 0
                       },
                       new DBECHFOOJOO
                       {
                           Uid = 0,
                           Name = 0,
                           Level = {},
                           Exp = 0
                       }
                    },
                    MPDCKNHELFH = Enum_None_CashTicket_MonthCardReward_StoreDailyRefresh_JiangyuLoad.WeaponMigrate,
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
                    HEEDJKIDCLI = new KEKFMLHLAMN()
                    {
                        Uid = 26,
                        Name = 120
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
                DzStatus = AGFLPCMOGGI.Types.Status.Normal,
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
                        Type = Enum_Normal_Advance.Normal,
                        Exp = 0,
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
                    Exp = 0,
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
                    Status = new LoginStatus()
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
                    IDMOCOHNLDO = new JMMLGEDCIGB()
                    {
                        Uid = false,
                        Name = 0,
                        Level = 0,
                    },
                    NBGNEBFEPON = "",
                    NewMedal = { 22023, 22020, 22019, 22022 },
                    AchievementNum = { 0, 7, 28, 79, 1 },
                    DELPACHDBFG = { },
                    Assistants = { },
                    AGMEOHPHANG =
                    {
                        new DBECHFOOJOO(),
                        new DBECHFOOJOO(),
                        new DBECHFOOJOO(),
                        new DBECHFOOJOO(),
                        new DBECHFOOJOO(),
                        new DBECHFOOJOO(),
                        new DBECHFOOJOO(),
                        new DBECHFOOJOO(),
                        new DBECHFOOJOO(),
                    },
                    MPDCKNHELFH = Enum_None_CashTicket_MonthCardReward_StoreDailyRefresh_JiangyuLoad.WeaponMigrate,
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
                    HEEDJKIDCLI = new KEKFMLHLAMN()
                    {
                        Uid = 0,
                        Name = 0,
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
                DzStatus = AGFLPCMOGGI.Types.Status.Normal,
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
                            ResourceEx = 1779163704,
                            MonthCard = 183
                        },
                        [102] = new()
                        {
                            ResourceEx = 1779163939,
                            MonthCard = 3
                        },
                        [106] = new()
                        {
                            ResourceEx = 1779163939,
                            MonthCard = 5
                        }
                    },

                    MonthCard =
                    {
                    },

                    OFHIHPPKKJP =
                    {
                        [261] = new JIDLNNFNGGF()
                        {
                            ResourceEx = new()
                            {
                                ResourceEx =
                                {
                                    1730214970
                                }
                            },
                            StaminaTypeResource = 0
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
                Timestamp = 1779518860,
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
                GachaDetails = null,
                Exp = { true, true, true, true, true },
                Limit = { },
                Guarantee =
                {
                    { 1001, 79 },
                    { 1101, 79 },
                    { 2001, 70 },
                    { 3001, 80 },
                    { 4001, 50 },
                    { 4101, 50 },
                    { 5001, 70 },
                    { 6001, 80 },
                    { 7001, 80 },
                    { 8001, 70 },
                    { 9001, 80 },
                    { 10001, 70 },
                    { 11001, 80 },
                    { 12001, 70 },
                    { 13001, 80 },
                    { 14001, 70 },
                    { 15001, 80 },
                    { 16001, 70 },
                    { 17001, 80 },
                    { 18001, 70 },
                    { 19001, 80 },
                    { 20001, 70 },
                    { 21001, 80 },
                    { 22001, 70 },
                    { 23001, 80 },
                    { 24001, 70 },
                    { 25001, 80 },
                    { 26001, 70 },
                    { 27001, 80 },
                    { 28001, 70 },
                    { 29001, 80 },
                    { 30001, 70 },
                    { 31001, 80 },
                    { 32001, 70 },
                    { 33001, 80 },
                    { 34001, 70 },
                    { 35001, 80 },
                    { 36001, 70 },
                    { 37001, 80 },
                    { 38001, 70 },
                    { 39001, 80 },
                    { 40001, 70 },
                    { 41001, 80 },
                    { 42001, 70 },
                    { 43001, 80 },
                    { 44001, 70 },
                    { 45001, 80 },
                    { 46001, 70 },
                    { 47001, 80 },
                    { 48001, 70 },
                    { 49001, 80 },
                    { 50001, 70 },
                    { 51001, 80 },
                    { 52001, 70 },
                    { 53001, 80 },
                    { 54001, 70 },
                    { 55001, 80 },
                    { 56001, 70 },
                    { 57001, 80 },
                    { 58001, 70 },
                    { 59001, 80 },
                    { 60001, 70 },
                    { 61001, 80 },
                    { 62001, 70 },
                    { 63001, 80 },
                    { 64001, 70 },
                    { 65001, 80 },
                    { 66001, 70 },
                    { 67001, 80 },
                    { 68001, 70 },
                    { 69001, 80 },
                    { 70001, 70 },
                    { 71001, 80 },
                    { 72001, 70 },
                    { 73001, 80 },
                    { 74001, 70 },
                    { 75001, 80 },
                    { 76001, 70 },
                    { 77001, 80 },
                    { 78001, 70 },
                    { 79001, 80 },
                    { 80001, 70 },
                    { 81001, 80 },
                    { 82001, 70 },
                    { 83001, 80 },
                    { 84001, 70 },
                    { 85001, 80 },
                    { 86001, 70 },
                    { 87001, 80 },
                    { 88001, 70 },
                    { 90001, 80 },
                    { 90011, 80 },
                    { 90021, 80 },
                    { 90031, 80 },
                    { 91001, 70 },
                    { 91011, 70 },
                    { 91021, 70 },
                    { 91031, 70 },
                    { 98001, 100 },
                    { 100001, 80 },
                    { 101001, 70 },
                    { 102001, 80 },
                    { 103001, 70 },
                    { 104001, 80 },
                    { 105001, 70 },
                    { 106001, 80 },
                    { 107001, 70 },
                    { 108001, 80 },
                    { 109001, 70 },
                    { 110001, 80 },
                    { 111001, 70 },
                    { 112001, 80 },
                    { 113001, 70 },
                    { 114001, 80 },
                    { 115001, 70 },
                    { 116001, 80 },
                    { 117001, 70 },
                    { 118001, 80 },
                    { 119001, 70 },
                    { 120001, 80 },
                    { 121001, 70 },
                    { 122001, 80 },
                    { 123001, 70 },
                    { 124001, 80 },
                    { 125001, 70 },
                    { 126001, 80 },
                    { 127001, 70 },
                    { 128001, 80 },
                    { 129001, 70 },
                    { 130001, 80 },
                    { 131001, 70 },
                    { 132001, 80 },
                    { 133001, 70 },
                    { 134001, 80 },
                    { 135001, 70 },
                    { 136001, 80 },
                    { 137001, 70 },
                    { 138001, 80 },
                    { 139001, 70 },
                    { 140001, 80 },
                    { 141001, 70 },
                    { 142001, 80 },
                    { 143001, 70 },
                    { 144001, 80 },
                    { 145001, 70 },
                    { 146001, 80 },
                    { 147001, 70 },
                    { 148001, 80 },
                    { 149001, 70 },
                    { 150001, 80 },
                    { 151001, 70 },
                    { 152001, 80 },
                    { 153001, 70 },
                    { 154001, 80 },
                    { 155001, 70 },
                    { 156001, 80 },
                    { 157001, 70 },
                    { 158001, 80 },
                    { 159001, 70 },
                    { 160001, 80 },
                    { 161001, 70 },
                    { 162001, 80 },
                    { 163001, 70 },
                    { 164001, 80 },
                    { 165001, 70 },
                    { 166001, 80 },
                    { 167001, 70 },
                    { 168001, 80 },
                    { 169001, 70 },
                    { 170001, 80 },
                    { 171001, 70 },
                    { 172001, 80 },
                    { 173001, 70 },
                    { 174001, 80 },
                    { 175001, 70 },
                    { 176001, 80 },
                    { 177001, 70 },
                    { 178001, 80 },
                    { 179001, 70 },
                    { 180001, 80 },
                    { 181001, 70 },
                    { 182001, 80 },
                    { 183001, 70 },
                    { 184001, 80 },
                    { 185001, 70 },
                    { 186001, 80 },
                    { 187001, 70 },
                    { 188001, 100 },
                    { 189001, 80 },
                    { 190001, 70 },
                    { 191001, 80 },
                    { 192001, 70 },
                    { 193001, 80 },
                    { 194001, 70 },
                    { 195001, 80 },
                    { 196001, 70 },
                    { 197001, 80 },
                    { 198001, 70 },
                    { 199001, 80 },
                    { 200001, 70 },
                    { 201001, 80 },
                    { 202001, 70 },
                    { 203001, 80 },
                    { 204001, 70 },
                    { 205001, 80 },
                    { 206001, 70 },
                    { 207001, 80 },
                    { 208001, 70 },
                    { 209001, 80 },
                    { 210001, 70 },
                    { 211001, 80 },
                    { 212001, 70 },
                    { 213001, 80 },
                    { 214001, 70 },
                    { 215001, 80 },
                    { 216001, 70 },
                    { 217001, 80 },
                    { 218001, 70 },
                    { 219001, 80 },
                    { 220001, 70 },
                    { 221001, 100 },
                    { 222001, 80 },
                    { 223001, 70 },
                    { 224001, 80 },
                    { 225001, 70 },
                    { 226001, 80 },
                    { 227001, 70 },
                    { 228001, 80 },
                    { 229001, 70 },
                    { 230001, 80 },
                    { 231001, 70 },
                    { 232001, 80 },
                    { 233001, 70 },
                    { 234001, 80 },
                    { 235001, 70 },
                    { 236001, 80 },
                    { 237001, 70 },
                    { 238001, 80 },
                    { 239001, 70 },
                },
                OBJIBOMKEKD = 1,
                NJHKLBALAJA =
                {
                    { 4101, new RecordRoomDetail() { MMHMOJABOPP = 1027, LNMCMKNNILF = false } },
                },
            };
            SC_DarkZoneStep1RoomBasicInfo scDarkZoneStep1RoomBasicInfo = new SC_DarkZoneStep1RoomBasicInfo()
            {
                Room = new RoomBriefInfo()
                {
                    RoomStcId = 0,
                    RoomId = 0,
                    MapId = 0,
                    QuestId = 0,
                    DzType = 0,
                    GroupId = 0,
                    ELBNMDGMJEF = 0,
                    PKHIIDMOAAJ = null,
                    GJJLHKODHIO = null,
                    BCKGIFENEAL = 0,
                },
                RecnnFuncType = RecnnFuncType.Enable,
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
                scDarkZoneStep1RoomBasicInfo,
                scHotfixNoticeSync);

            SC_GetGamePlayStatus sCGetGamePlayStatus3 = new SC_GetGamePlayStatus()
            {
                CMOBODHPHOC = new LFBPPCEEHFH()
                {
                    CMOBODHPHOC = new SC_GetGamePlayStatus_F1Type_F1Type()
                    {
                        CMOBODHPHOC = new NrtPvpSeason()
                        {
                            LevelType = 1,
                            PlanId = 0,
                            LastPlanId = 0,
                            SeasonId = 30034,
                            LastSeasonId = 20137
                        }
                    },
                    LastPlanId = null,
                    SeasonId = null,
                    LastSeasonId = null,
                    Field5 = null,
                    Field6 = null,
                    Field7 = null,
                    Field8 = null,
                    Field9 = null,
                    Field10 = 0,
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
                    CMOBODHPHOC = null,
                    LastPlanId = null,
                    SeasonId = new SC_GetGamePlayStatus_F1Type_F3Type()
                    {
                        CMOBODHPHOC = false,
                        LastPlanId = 0,
                        SeasonId = 0,
                    },
                    LastSeasonId = null,
                    Field5 = null,
                    Field6 = null,
                    Field7 = null,
                    Field8 = null,
                    Field9 = null,
                    Field10 = 0,
                },
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