using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;
using NTRSimulator.Common.Protocol;
using NTRSimulator.Database.Entities;
using NTRSimulator.GameServer.Extensions;
using NTRSimulator.GameServer.Services;
using NTRSimulator.PcapParser;
using NTRSimulator.Common.Table;
using System;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class GunHandler(IInventoryService inventoryService, ITableService tableService) : GunHandlerBase
    {
        public override void HandleGuns(CS_Guns request, Connection connection)
        {
            if (connection.Account == null) return;

            SC_Guns scGuns = new SC_Guns();

            foreach (Gun gun in inventoryService.GetPlayerInventory<Gun>(connection.Account.Uid))
            {
                scGuns.Field1.Add(gun.ToProtoGunCharacter());

            }

            //uint[] chars = new uint[] { 1017, 1024, 1001, 1008 };
            //uint[] chars = new uint[] { 1032, 1063 };
            //scGuns.Field1.Add(CreateNewGunCharacter(1032, 20));
            //scGuns.Field1.Add(CreateNewGunCharacter(1063, 20));
            
            connection.SendAutoEncrypted(scGuns);
        }

        public override void HandleGunRemouldingPlugins(CS_GunRemouldingPlugins request, Connection connection)
        {
                connection.Send(4,
                    new SC_GunRemouldingPlugins
                    {
                        Field1 =
                        {
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1835910277177040896UL,
                                Field1 = 983201,
                                Field2 =
                                {
                                    1200201,
                                    2300501,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1846099719155113984UL,
                                Field1 = 984102,
                                Field2 =
                                {
                                    1100302,
                                    2100701,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1843288636979699712UL,
                                Field1 = 983301,
                                Field2 =
                                {
                                    1300101,
                                    2100201,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1839071274439041024UL,
                                Field1 = 983101,
                                Field2 =
                                {
                                    1100201,
                                    2100301,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1829565371798020096UL,
                                Field1 = 984202,
                                Field2 =
                                {
                                    1200402,
                                    2400701,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1846544928750985216UL,
                                Field1 = 983101,
                                Field2 =
                                {
                                    1100401,
                                    2300501,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1845186142339620864UL,
                                Field1 = 984302,
                                Field2 =
                                {
                                    1300302,
                                    2200201,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1830929806184701952UL,
                                Field1 = 983101,
                                Field2 =
                                {
                                    1100301,
                                    2400201,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1832835441797128192UL,
                                Field1 = 983301,
                                Field2 =
                                {
                                    1300401,
                                    2100701,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1845005422894800896UL,
                                Field1 = 984302,
                                Field2 =
                                {
                                    1300402,
                                    2300801,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1858088292359102464UL,
                                Field1 = 983101,
                                Field2 =
                                {
                                    1100301,
                                    2400101,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1836550333413744640UL,
                                Field1 = 983401,
                                Field2 =
                                {
                                    1400101,
                                    2300101,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1841010189906501632UL,
                                Field1 = 984402,
                                Field2 =
                                {
                                    1400202,
                                    2100201,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1835280701670318080UL,
                                Field1 = 984202,
                                Field2 =
                                {
                                    1200302,
                                    2200701,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1838893343599255552UL,
                                Field1 = 984402,
                                Field2 =
                                {
                                    1400102,
                                    2200301,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1842370612705648640UL,
                                Field1 = 984402,
                                Field2 =
                                {
                                    1400102,
                                    2100601,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1857996740069711872UL,
                                Field1 = 983301,
                                Field2 =
                                {
                                    1300401,
                                    2200801,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1843288855838482432UL,
                                Field1 = 984402,
                                Field2 =
                                {
                                    1400302,
                                    2200801,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1834636826666622976UL,
                                Field1 = 983101,
                                Field2 =
                                {
                                    1100101,
                                    2100801,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1845459095485702144UL,
                                Field1 = 984202,
                                Field2 =
                                {
                                    1200202,
                                    2400401,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1840808736761864192UL,
                                Field1 = 983401,
                                Field2 =
                                {
                                    1400201,
                                    2400201,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1842370402064556032UL,
                                Field1 = 983101,
                                Field2 =
                                {
                                    1100101,
                                    2200601,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1830196550596321280UL,
                                Field1 = 983401,
                                Field2 =
                                {
                                    1400301,
                                    2400401,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1831464973352591360UL,
                                Field1 = 983401,
                                Field2 =
                                {
                                    1400401,
                                    2300401,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1842097119480012800UL,
                                Field1 = 985102,
                                Field2 =
                                {
                                    1100203,
                                    2400101,
                                    2101001,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1827044870051618816UL,
                                Field1 = 984302,
                                Field2 =
                                {
                                    1300302,
                                    2200101,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1834013572877803520UL,
                                Field1 = 983101,
                                Field2 =
                                {
                                    1100201,
                                    2200701,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1856336655181438976UL,
                                Field1 = 983201,
                                Field2 =
                                {
                                    1200301,
                                    2100301,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1845640086511706112UL,
                                Field1 = 984302,
                                Field2 =
                                {
                                    1300302,
                                    2300501,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1828925846182715392UL,
                                Field1 = 985102,
                                Field2 =
                                {
                                    1100303,
                                    2400202,
                                },
                                Field4 = 0,
                                Field5 = true,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1826204793002024960UL,
                                Field1 = 983401,
                                Field2 =
                                {
                                    1400301,
                                    2400201,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1826383457987616768UL,
                                Field1 = 983401,
                                Field2 =
                                {
                                    1400101,
                                    2400201,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1833379456729767936UL,
                                Field1 = 983201,
                                Field2 =
                                {
                                    1200301,
                                    2200401,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1844548013226221568UL,
                                Field1 = 984102,
                                Field2 =
                                {
                                    1100102,
                                    2300101,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1845818391211827200UL,
                                Field1 = 984202,
                                Field2 =
                                {
                                    1200302,
                                    2200101,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1839905421879435264UL,
                                Field1 = 984402,
                                Field2 =
                                {
                                    1400302,
                                    2100401,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1846545133357522944UL,
                                Field1 = 984302,
                                Field2 =
                                {
                                    1300302,
                                    2400201,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1832285033641041920UL,
                                Field1 = 983201,
                                Field2 =
                                {
                                    1200301,
                                    2300501,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1837905451422867456UL,
                                Field1 = 984302,
                                Field2 =
                                {
                                    1300202,
                                    2100301,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1827847029261361152UL,
                                Field1 = 983401,
                                Field2 =
                                {
                                    1400101,
                                    2300701,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1828489963575992320UL,
                                Field1 = 983301,
                                Field2 =
                                {
                                    1300101,
                                    2200601,
                                },
                                Field4 = 0,
                                Field5 = false,
                            },
                        },
                    });
        }

        public override void HandleGunCostume(CS_GunCostume request, Connection connection)
        {
                
                connection.Send(new SC_GunCostume
                {
                    Field1 = request.Field1,
                    Field2 = request.Field2,
                });
        }

        public override void HandleGetGunRemouldingPluginLockPlan(CS_GetGunRemouldingPluginLockPlan request, Connection connection)
        {
                connection.Send(new SC_GetGunRemouldingPluginLockPlan
                {
                    Field1 = new SC_GetGunRemouldingPluginLockPlan_F1Type
                    {
                        Field1 = false,
                        Field2 =
                        {
                            new SC_GetGunRemouldingPluginLockPlan_F1Type_F2Type
                            {
                                Field1 =
                                {
                                    new SC_GetGunRemouldingPluginLockPlan_F1Type_F2Type_F1Type
                                    {
                                        Field1 = { 11001, 11002 },
                                        Field2 = { 21007, 21008 },
                                        Field3 = 1,
                                    },
                                },
                            },
                            new SC_GetGunRemouldingPluginLockPlan_F1Type_F2Type
                            {
                                Field1 =
                                {
                                    new SC_GetGunRemouldingPluginLockPlan_F1Type_F2Type_F1Type
                                    {
                                        Field1 = { 12001, 12002 },
                                        Field2 = { 22007, 22008 },
                                        Field3 = 1,
                                    },
                                },
                            },
                            new SC_GetGunRemouldingPluginLockPlan_F1Type_F2Type
                            {
                                Field1 =
                                {
                                    new SC_GetGunRemouldingPluginLockPlan_F1Type_F2Type_F1Type
                                    {
                                        Field1 = { 13001, 13002 },
                                        Field2 = { 23007, 23008 },
                                        Field3 = 1,
                                    },
                                },
                            },
                            new SC_GetGunRemouldingPluginLockPlan_F1Type_F2Type
                            {
                                Field1 =
                                {
                                    new SC_GetGunRemouldingPluginLockPlan_F1Type_F2Type_F1Type
                                    {
                                        Field1 = { 14001, 14002 },
                                        Field2 = { 24007, 24008 },
                                        Field3 = 1,
                                    },
                                },
                            },
                        },
                    },
                });
        }
    }
}
