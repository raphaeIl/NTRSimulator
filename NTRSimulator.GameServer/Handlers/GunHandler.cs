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

            foreach (GunEntity gun in inventoryService.GetPlayerInventory<GunEntity>(connection.Account.Uid))
            {
                scGuns.Guns.Add(gun.ToProtoGunCharacter());

            }

            //uint[] chars = new uint[] { 1017, 1024, 1001, 1008 };
            //uint[] chars = new uint[] { 1032, 1063 };
            //scGuns.Guns.Add(CreateNewGunCharacter(1032, 20));
            //scGuns.Guns.Add(CreateNewGunCharacter(1063, 20));
            
            connection.SendAutoEncrypted(scGuns);
        }

        public override void HandleGunRemouldingPlugins(CS_GunRemouldingPlugins request, Connection connection)
        {
                connection.Send(4,
                    new SC_GunRemouldingPlugins
                    {
                        AIDIBGJDNLM =
                        {
                            new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F11Type
                            {
                                Field3 = 1835910277177040896UL,
                                AIDIBGJDNLM = 983201,
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
                                AIDIBGJDNLM = 984102,
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
                                AIDIBGJDNLM = 983301,
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
                                AIDIBGJDNLM = 983101,
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
                                AIDIBGJDNLM = 984202,
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
                                AIDIBGJDNLM = 983101,
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
                                AIDIBGJDNLM = 984302,
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
                                AIDIBGJDNLM = 983101,
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
                                AIDIBGJDNLM = 983301,
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
                                AIDIBGJDNLM = 984302,
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
                                AIDIBGJDNLM = 983101,
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
                                AIDIBGJDNLM = 983401,
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
                                AIDIBGJDNLM = 984402,
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
                                AIDIBGJDNLM = 984202,
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
                                AIDIBGJDNLM = 984402,
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
                                AIDIBGJDNLM = 984402,
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
                                AIDIBGJDNLM = 983301,
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
                                AIDIBGJDNLM = 984402,
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
                                AIDIBGJDNLM = 983101,
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
                                AIDIBGJDNLM = 984202,
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
                                AIDIBGJDNLM = 983401,
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
                                AIDIBGJDNLM = 983101,
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
                                AIDIBGJDNLM = 983401,
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
                                AIDIBGJDNLM = 983401,
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
                                AIDIBGJDNLM = 985102,
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
                                AIDIBGJDNLM = 984302,
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
                                AIDIBGJDNLM = 983101,
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
                                AIDIBGJDNLM = 983201,
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
                                AIDIBGJDNLM = 984302,
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
                                AIDIBGJDNLM = 985102,
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
                                AIDIBGJDNLM = 983401,
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
                                AIDIBGJDNLM = 983401,
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
                                AIDIBGJDNLM = 983201,
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
                                AIDIBGJDNLM = 984102,
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
                                AIDIBGJDNLM = 984202,
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
                                AIDIBGJDNLM = 984402,
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
                                AIDIBGJDNLM = 984302,
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
                                AIDIBGJDNLM = 983201,
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
                                AIDIBGJDNLM = 984302,
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
                                AIDIBGJDNLM = 983401,
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
                                AIDIBGJDNLM = 983301,
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
                    GunId = request.GunId,
                    CostumeId = request.CostumeId,
                });
        }

        public override void HandleGetGunRemouldingPluginLockPlan(CS_GetGunRemouldingPluginLockPlan request, Connection connection)
        {
                connection.Send(new SC_GetGunRemouldingPluginLockPlan
                {
                    DJNPEOFHKHD = new AOEAJGGGBBM
                    {
                        Open = false,
                        PMDFJCLFFPB =
                        {
                            new PBPDJINOMHG
                            {
                                CLMMDIGBOJC =
                                {
                                    new HGHONBPDMNG
                                    {
                                        JMCMFMNNENL = { 11001, 11002 },
                                        AEBNOHIKJOI = { 21007, 21008 },
                                        IJMINJLDENL = 1,
                                    },
                                },
                            },
                            new PBPDJINOMHG
                            {
                                CLMMDIGBOJC =
                                {
                                    new HGHONBPDMNG
                                    {
                                        JMCMFMNNENL = { 12001, 12002 },
                                        AEBNOHIKJOI = { 22007, 22008 },
                                        IJMINJLDENL = 1,
                                    },
                                },
                            },
                            new PBPDJINOMHG
                            {
                                CLMMDIGBOJC =
                                {
                                    new HGHONBPDMNG
                                    {
                                        JMCMFMNNENL = { 13001, 13002 },
                                        AEBNOHIKJOI = { 23007, 23008 },
                                        IJMINJLDENL = 1,
                                    },
                                },
                            },
                            new PBPDJINOMHG
                            {
                                CLMMDIGBOJC =
                                {
                                    new HGHONBPDMNG
                                    {
                                        JMCMFMNNENL = { 14001, 14002 },
                                        AEBNOHIKJOI = { 24007, 24008 },
                                        IJMINJLDENL = 1,
                                    },
                                },
                            },
                        },
                    },
                });
        }
    }
}
