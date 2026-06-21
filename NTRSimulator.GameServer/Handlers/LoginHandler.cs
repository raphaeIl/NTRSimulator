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
            var session = PlayerSessionManager.Instance.GetSession(req.Field2);
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
                //inventoryService.AddAll<Gun>(account.Uid);
                List<GunData> gunData = tableService.GetTable<GunData>();
                List<InitItemCsData> initItemData = tableService.GetTable<InitItemCsData>();

                GunData[] defaultGuns = gunData.Where(gun => initItemData.Select(item => item.ItemId).Contains(gun.GunId)).ToArray();

                foreach (var defaultGun in defaultGuns)
                {
                    inventoryService.Add<Gun>(account.Uid, new Gun()
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
                Field1 = 1,
                Field2 = 1,
                Field3 = 0
            };

            SC_Login endgame_acc_scLogin = new()
            {
                Field1 = new SC_Login_F1Type
                {
                    Field1 = 1,
                    Field2 = "ntrsimulator",
                    Field3 = 60,
                    Field4 = 0,
                    Field5 = Enum_Male_Female.Female,
                    Field6 = 101,
                    Field7 = 21089, // avatar PlayerAvatarData
                    Field21 = 24164, // frame HeadFrameData
                    Field8 = "aaa",
                    Field27 = 0,
                    Field15 = 25000,
                    Field16 = 22010,
                    Field17 = 31065,
                    Field18 = 16843009,
                    Field19 = 123213123,
                    Field20 = 55,
                    Field26 = { },
                    Field22 = { 22081, 22082, 22083, 22084 },
                    Field23 = { 73, 95, 120, 108, 78 },
                    Field10 = new SC_Login_F1Type_F10Type
                    {
                        Field1 = false,
                        Field2 = 1780801750,
                        Field3 = 1780801908,
                        Field4 = 1780802125,
                        Field5 = 0
                    },
                    Field11 = null,
                    Field12 = 123123,
                    Field13 = "ntrsimulator",
                    Field14 = 0,
                    Field31 = 3,
                    Field32 = 4,
                    Field33 = false,
                    Field34 = new SC_Login_F1Type_F34Type()
                    {
                        Field1 = true,
                        Field2 = 1162,
                        Field3 = 40
                    },
                    Field45 = "",
                    Field28 =
                    {
                
                    },
                    Field30 =
                    {
                       new SC_Login_F1Type_F30Type
                       {
                           Field1 = 11044,
                           Field2 = 4134104,
                           Field3 =
                           {
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 20116453, Field2 = 7332824 },
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 10112353, Field2 = 7331055 },
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 120115353, Field2 = 7335814 },
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 30111353, Field2 = 0 }
                           },
                           Field4 = 1
                       },
                       new SC_Login_F1Type_F30Type
                       {
                           Field1 = 10523,
                           Field2 = 4134085,
                           Field3 =
                           {
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 20113453, Field2 = 7332345 },
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 10112353, Field2 = 7231355 },
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 120116353, Field2 = 6315664 },
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 30116353, Field2 = 6313484 }
                           },
                           Field4 = 1
                       },
                       new SC_Login_F1Type_F30Type
                       {
                           Field1 = 10002,
                           Field2 = 4132084,
                           Field3 =
                           {
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 20127453, Field2 = 6312264 },
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 10126353, Field2 = 7331055 },
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 120127353, Field2 = 7335814 },
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 30125353, Field2 = 6313514 }
                           },
                           Field4 = 1
                       },
                       new SC_Login_F1Type_F30Type
                       {
                           Field1 = 11038,
                           Field2 = 4134104,
                           Field3 =
                           {
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 20117453, Field2 = 7332824 },
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 10115353, Field2 = 7331055 },
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 120117353, Field2 = 7335814 },
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 30115353, Field2 = 0 }
                           },
                           Field4 = 1
                       },
                       new SC_Login_F1Type_F30Type
                       {
                           Field1 = 11044,
                           Field2 = 0,
                           Field3 =
                           {
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 0, Field2 = 0 },
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 0, Field2 = 0 },
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 0, Field2 = 0 },
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 0, Field2 = 0 }
                           },
                           Field4 = 1
                       },
                       new SC_Login_F1Type_F30Type
                       {
                           Field1 = 10333,
                           Field2 = 0,
                           Field3 =
                           {
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 0, Field2 = 0 },
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 0, Field2 = 0 },
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 0, Field2 = 0 },
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 0, Field2 = 0 }
                           },
                           Field4 = 1
                       },
                       new SC_Login_F1Type_F30Type
                       {
                           Field1 = 10333,
                           Field2 = 0,
                           Field3 =
                           {
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 0, Field2 = 0 },
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 0, Field2 = 0 },
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 0, Field2 = 0 },
                               new SC_Login_F1Type_F30Type_F3Type { Field1 = 0, Field2 = 0 }
                           },
                           Field4 = 1
                       },
                       new SC_Login_F1Type_F30Type
                       {
                           Field1 = 0,
                           Field2 = 0,
                           Field3 = {},
                           Field4 = 0
                       },
                       new SC_Login_F1Type_F30Type
                       {
                           Field1 = 0,
                           Field2 = 0,
                           Field3 = {},
                           Field4 = 0
                       }
                    },
                    Field35 = Enum_None_CashTicket_MonthCardReward_StoreDailyRefresh_JiangyuLoad.WeaponMigrate,
                    Field37 =
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
                    Field38 = 25001,
                    Field36 = new SC_Login_F1Type_F36Type()
                    {
                        Field1 =
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
                        Field2 = 1335002,
                        Field3 = 1335101
                    },
                    Field39 = new SC_HeroModeMark_F1Type()
                    {
                        Field1 = 1780963200,
                        Field2 = 0.9f
                    },
                    Field40 = new SC_Login_F1Type_F40Type()
                    {
                        Field1 = 26,
                        Field2 = 120
                    },
                    Field41 = 0,
                    Field42 = 2294,
                    Field43 = 0,
                    Field44 = null
                },
                Field2 = 0,
                Field3 = { },
                Field4 = "",
                Field5 = "0",
                Field6 = "abcdefghabcdefgh",
                Field10 = Enum_StatusNormal_StatusServerMaintain_StatusServerReadTimeOut_StatusMessageMaxFrequency_StatusUserNotLogin.StatusNormal,
                Field11 = Enum_Normal_Marching_Playing.Normal,
                Field13 = 8,
                Field14 = true,
                Field15 = ""
            };

            SC_ActivityBackDailyRefresh scActivityBackDailyRefresh = new SC_ActivityBackDailyRefresh()
            {
                Field1 = new SC_ActivityBackDailyRefresh_F1Type()
                {
                    Field1 = 1,
                    Field2 = 1779500060,
                    Field3 = 3,
                    Field4 = 1779518860,
                    Field5 = false,
                    Field6 = 0,
                    Field7 = false,
                    Field8 = 2,
                    Field9 = new SC_ActivityBackDailyRefresh_F1Type_F9Type()
                    {
                        Field1 = Enum_Normal_Advance.Normal,
                        Field2 = 0,
                        Field3 = 0,
                        Field4 = { },
                        Field5 = { },
                    },
                },
            };
            SC_Login scLogin = new SC_Login()
            {
                Field1 = new SC_Login_F1Type()
                {
                    Field1 = 2225766,
                    Field2 = "kebjgw",
                    Field3 = 60,
                    Field4 = 0,
                    Field5 = Enum_Male_Female.Female,
                    Field6 = 101,
                    Field7 = 21999,
                    Field21 = 0,
                    Field8 = "",
                    Field27 = 0,
                    Field15 = 23001,
                    Field16 = 22001,
                    Field17 = 10110,
                    Field18 = 16843009,
                    Field19 = 1703592104,
                    Field20 = 4,
                    Field26 = { },
                    Field10 = new SC_Login_F1Type_F10Type()
                    {
                        Field1 = false,
                        Field2 = 1779501594,
                        Field3 = 1779501613,
                        Field4 = 1779501613,
                        Field5 = 0,
                    },
                    Field11 = null,
                    Field12 = 0,
                    Field13 = "",
                    Field14 = 0,
                    Field31 = 0,
                    Field32 = 0,
                    Field33 = false,
                    Field34 = new SC_Login_F1Type_F34Type()
                    {
                        Field1 = false,
                        Field2 = 0,
                        Field3 = 0,
                    },
                    Field45 = "",
                    Field22 = { 22023, 22020, 22019, 22022 },
                    Field23 = { 0, 7, 28, 79, 1 },
                    Field28 = { },
                    Field29 = { },
                    Field30 =
                    {
                        new SC_Login_F1Type_F30Type(),
                        new SC_Login_F1Type_F30Type(),
                        new SC_Login_F1Type_F30Type(),
                        new SC_Login_F1Type_F30Type(),
                        new SC_Login_F1Type_F30Type(),
                        new SC_Login_F1Type_F30Type(),
                        new SC_Login_F1Type_F30Type(),
                        new SC_Login_F1Type_F30Type(),
                        new SC_Login_F1Type_F30Type(),
                    },
                    Field35 = Enum_None_CashTicket_MonthCardReward_StoreDailyRefresh_JiangyuLoad.WeaponMigrate,
                    Field37 =
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
                    Field38 = 0,
                    Field36 = new SC_Login_F1Type_F36Type()
                    {
                        Field1 = { },
                        Field2 = 1335001,
                        Field3 = 1335101,
                    },
                    Field39 = null,
                    Field40 = new SC_Login_F1Type_F40Type()
                    {
                        Field1 = 0,
                        Field2 = 0,
                    },
                    Field41 = 0,
                    Field42 = 60,
                    Field43 = 0,
                    Field44 = null,
                },
                Field2 = 0,
                Field3 = { },
                Field4 = "",
                Field5 = "0",
                Field6 = "abcdefghabcdefgh",
                Field10 = Enum_StatusNormal_StatusServerMaintain_StatusServerReadTimeOut_StatusMessageMaxFrequency_StatusUserNotLogin.StatusNormal,
                Field11 = Enum_Normal_Marching_Playing.Normal,
                Field13 = 8,
                Field14 = true,
                Field15 = "",
            };

            //scLogin = PcapUtils.GetPacketFromPcap<SC_Login>(MsgId.MsgScLogin, PacketType.RESPONSE);

            SC_Resource scResource = new()
            {
                Field1 = new SC_Resource_F1Type()
                {
                    Field1 =
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
                    Field2 =
                    {
                        [101] = new()
                        {
                            Field1 = 1779163704,
                            Field3 = 183
                        },
                        [102] = new()
                        {
                            Field1 = 1779163939,
                            Field3 = 3
                        },
                        [106] = new()
                        {
                            Field1 = 1779163939,
                            Field3 = 5
                        }
                    },

                    Field3 =
                    {
                    },

                    Field4 =
                    {
                        [261] = new SC_LimitItemUpdate_F1ValueType()
                        {
                            Field1 = new()
                            {
                                Field1 =
                                {
                                    1730214970
                                }
                            },
                            Field2 = 0
                        }
                    }
                }
            };

            scResource.Field1.Field1[1] = 123456789;
            scResource.Field1.Field1[10] = 123456789;
            scResource.Field1.Field1[12] = 123456789;
            scResource.Field1.Field1[45] = 123456789;

            SC_Sync scSync = new SC_Sync()
            {
                Field1 = 1779518860,
                Field2 = 0,
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync = new SC_PlayerStatusCounterSync()
            {
                Field2 = 8,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 63, Field2 = 40011 },
                },
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync2 = new SC_PlayerStatusCounterSync()
            {
                Field2 = 8,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 63, Field2 = 1581 },
                },
            };
            SC_Record scRecord = new SC_Record()
            {
                Field1 = { },
                Field3 = null,
                Field2 = { true, true, true, true, true },
                Field4 = { },
                Field6 =
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
                Field7 = 1,
                Field8 =
                {
                    { 4101, new SC_Record_F8ValueType() { Field1 = 1027, Field2 = false } },
                },
            };
            SC_DarkZoneStep1RoomBasicInfo scDarkZoneStep1RoomBasicInfo = new SC_DarkZoneStep1RoomBasicInfo()
            {
                Field1 = new SC_DarkZoneMarch_F8Type()
                {
                    Field1 = 0,
                    Field2 = 0,
                    Field3 = 0,
                    Field4 = 0,
                    Field5 = 0,
                    Field6 = 0,
                    Field7 = 0,
                    Field41 = null,
                    Field42 = null,
                    Field43 = 0,
                },
                Field2 = Enum_Null_Enable_Disable.Enable,
                Field3 = null,
            };
            SC_HotfixNoticeSync scHotfixNoticeSync = new SC_HotfixNoticeSync()
            {
                Field1 =
                {
                    {
                        1,
                        new SC_HotfixNoticeSync_F1ValueType()
                        {
                            Field1 = 1,
                            Field2 = 1774266600,
                            Field3 = 10,
                            Field4 = 0,
                        }
                    },
                    {
                        2,
                        new SC_HotfixNoticeSync_F1ValueType()
                        {
                            Field1 = 2,
                            Field2 = 1774266900,
                            Field3 = 5,
                            Field4 = 0,
                        }
                    },
                    {
                        3,
                        new SC_HotfixNoticeSync_F1ValueType()
                        {
                            Field1 = 3,
                            Field2 = 1774267140,
                            Field3 = 1,
                            Field4 = 0,
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
                Field1 = new SC_GetGamePlayStatus_F1Type()
                {
                    Field1 = new SC_GetGamePlayStatus_F1Type_F1Type()
                    {
                        Field1 = new SC_GetGamePlayStatus_F1Type_F1Type_F1Type()
                        {
                            Field1 = 1,
                            Field2 = 0,
                            Field3 = 0,
                            Field4 = 30034,
                            Field5 = 20137
                        }
                    },
                    Field2 = null,
                    Field3 = null,
                    Field4 = null,
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
                Field2 = 0,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 63, Field2 = 1321 },
                },
            };
            SC_GetGamePlayStatus scGetGamePlayStatus2 = new SC_GetGamePlayStatus()
            {
                Field1 = new SC_GetGamePlayStatus_F1Type()
                {
                    Field1 = null,
                    Field2 = null,
                    Field3 = new SC_GetGamePlayStatus_F1Type_F3Type()
                    {
                        Field1 = false,
                        Field2 = 0,
                        Field3 = 0,
                    },
                    Field4 = null,
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
                Field1 = { },
                Field2 = 0
            };
            connection.Send(scMomentFetch);
        }
    }
}