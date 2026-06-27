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
                            new DBPDOCMENBN
                            {
                                Id = 1835910277177040896UL,
                                StcId = 983201,
                                ACEIFDEGLMH =
                                {
                                    1200201,
                                    2300501,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1846099719155113984UL,
                                StcId = 984102,
                                ACEIFDEGLMH =
                                {
                                    1100302,
                                    2100701,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1843288636979699712UL,
                                StcId = 983301,
                                ACEIFDEGLMH =
                                {
                                    1300101,
                                    2100201,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1839071274439041024UL,
                                StcId = 983101,
                                ACEIFDEGLMH =
                                {
                                    1100201,
                                    2100301,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1829565371798020096UL,
                                StcId = 984202,
                                ACEIFDEGLMH =
                                {
                                    1200402,
                                    2400701,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1846544928750985216UL,
                                StcId = 983101,
                                ACEIFDEGLMH =
                                {
                                    1100401,
                                    2300501,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1845186142339620864UL,
                                StcId = 984302,
                                ACEIFDEGLMH =
                                {
                                    1300302,
                                    2200201,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1830929806184701952UL,
                                StcId = 983101,
                                ACEIFDEGLMH =
                                {
                                    1100301,
                                    2400201,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1832835441797128192UL,
                                StcId = 983301,
                                ACEIFDEGLMH =
                                {
                                    1300401,
                                    2100701,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1845005422894800896UL,
                                StcId = 984302,
                                ACEIFDEGLMH =
                                {
                                    1300402,
                                    2300801,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1858088292359102464UL,
                                StcId = 983101,
                                ACEIFDEGLMH =
                                {
                                    1100301,
                                    2400101,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1836550333413744640UL,
                                StcId = 983401,
                                ACEIFDEGLMH =
                                {
                                    1400101,
                                    2300101,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1841010189906501632UL,
                                StcId = 984402,
                                ACEIFDEGLMH =
                                {
                                    1400202,
                                    2100201,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1835280701670318080UL,
                                StcId = 984202,
                                ACEIFDEGLMH =
                                {
                                    1200302,
                                    2200701,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1838893343599255552UL,
                                StcId = 984402,
                                ACEIFDEGLMH =
                                {
                                    1400102,
                                    2200301,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1842370612705648640UL,
                                StcId = 984402,
                                ACEIFDEGLMH =
                                {
                                    1400102,
                                    2100601,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1857996740069711872UL,
                                StcId = 983301,
                                ACEIFDEGLMH =
                                {
                                    1300401,
                                    2200801,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1843288855838482432UL,
                                StcId = 984402,
                                ACEIFDEGLMH =
                                {
                                    1400302,
                                    2200801,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1834636826666622976UL,
                                StcId = 983101,
                                ACEIFDEGLMH =
                                {
                                    1100101,
                                    2100801,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1845459095485702144UL,
                                StcId = 984202,
                                ACEIFDEGLMH =
                                {
                                    1200202,
                                    2400401,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1840808736761864192UL,
                                StcId = 983401,
                                ACEIFDEGLMH =
                                {
                                    1400201,
                                    2400201,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1842370402064556032UL,
                                StcId = 983101,
                                ACEIFDEGLMH =
                                {
                                    1100101,
                                    2200601,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1830196550596321280UL,
                                StcId = 983401,
                                ACEIFDEGLMH =
                                {
                                    1400301,
                                    2400401,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1831464973352591360UL,
                                StcId = 983401,
                                ACEIFDEGLMH =
                                {
                                    1400401,
                                    2300401,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1842097119480012800UL,
                                StcId = 985102,
                                ACEIFDEGLMH =
                                {
                                    1100203,
                                    2400101,
                                    2101001,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1827044870051618816UL,
                                StcId = 984302,
                                ACEIFDEGLMH =
                                {
                                    1300302,
                                    2200101,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1834013572877803520UL,
                                StcId = 983101,
                                ACEIFDEGLMH =
                                {
                                    1100201,
                                    2200701,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1856336655181438976UL,
                                StcId = 983201,
                                ACEIFDEGLMH =
                                {
                                    1200301,
                                    2100301,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1845640086511706112UL,
                                StcId = 984302,
                                ACEIFDEGLMH =
                                {
                                    1300302,
                                    2300501,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1828925846182715392UL,
                                StcId = 985102,
                                ACEIFDEGLMH =
                                {
                                    1100303,
                                    2400202,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = true,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1826204793002024960UL,
                                StcId = 983401,
                                ACEIFDEGLMH =
                                {
                                    1400301,
                                    2400201,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1826383457987616768UL,
                                StcId = 983401,
                                ACEIFDEGLMH =
                                {
                                    1400101,
                                    2400201,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1833379456729767936UL,
                                StcId = 983201,
                                ACEIFDEGLMH =
                                {
                                    1200301,
                                    2200401,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1844548013226221568UL,
                                StcId = 984102,
                                ACEIFDEGLMH =
                                {
                                    1100102,
                                    2300101,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1845818391211827200UL,
                                StcId = 984202,
                                ACEIFDEGLMH =
                                {
                                    1200302,
                                    2200101,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1839905421879435264UL,
                                StcId = 984402,
                                ACEIFDEGLMH =
                                {
                                    1400302,
                                    2100401,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1846545133357522944UL,
                                StcId = 984302,
                                ACEIFDEGLMH =
                                {
                                    1300302,
                                    2400201,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1832285033641041920UL,
                                StcId = 983201,
                                ACEIFDEGLMH =
                                {
                                    1200301,
                                    2300501,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1837905451422867456UL,
                                StcId = 984302,
                                ACEIFDEGLMH =
                                {
                                    1300202,
                                    2100301,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1827847029261361152UL,
                                StcId = 983401,
                                ACEIFDEGLMH =
                                {
                                    1400101,
                                    2300701,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
                            },
                            new DBPDOCMENBN
                            {
                                Id = 1828489963575992320UL,
                                StcId = 983301,
                                ACEIFDEGLMH =
                                {
                                    1300101,
                                    2200601,
                                },
                                GunId = 0,
                                MDFIDAFPBJN = false,
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
                        COFDFFJMNMA = false,
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
