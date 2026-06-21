using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;
using NTRSimulator.Database.Entities;
using NTRSimulator.GameServer.Services;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class IndexHandler(
        IInventoryService inventoryService) : IndexHandlerBase
    {
        public override void HandleIndex(CS_Index request, Connection connection)
        {
            if (connection.Account == null) return;

            SC_Index scIndex = new SC_Index
            {
                Field1 =
                {
                    {
                        10u,
                        new SC_Index_F1ValueType
                        {
                            Field1 = 10,
                            Field2 =
                            {
                                { 1001u, false },
                                { 1008u, false },
                                { 1017u, false },
                                { 1024u, false },
                            },
                        }
                    },
                    {
                        12u,
                        new SC_Index_F1ValueType
                        {
                            Field1 = 12,
                            Field2 =
                            {
                                { 21000u, true },
                                { 21001u, true },
                                { 21004u, true },
                                { 21009u, true },
                                { 21038u, false },
                                { 21999u, true },
                            },
                        }
                    },
                    {
                        13u,
                        new SC_Index_F1ValueType
                        {
                            Field1 = 13,
                            Field2 =
                            {
 
                            },
                        }
                    },
                    {
                        14u,
                        new SC_Index_F1ValueType
                        {
                            Field1 = 14,
                            Field2 = { },
                        }
                    },
                    {
                        20u,
                        new SC_Index_F1ValueType
                        {
                            Field1 = 20,
                            Field2 =
                            {
                                { 11009u, false },
                                { 11010u, false },
                                { 11022u, false },
                                { 11023u, false },
                                { 11039u, false },
                            },
                        }
                    },
                    {
                        21u,
                        new SC_Index_F1ValueType
                        {
                            Field1 = 21,
                            Field2 =
                            {

                            },
                        }
                    },
                    {
                        36u,
                        new SC_Index_F1ValueType
                        {
                            Field1 = 36,
                            Field2 =
                            {
                                { 22001u, true },
                                { 22002u, false },
                                { 22019u, false },
                                { 22020u, false },
                                { 22022u, false },
                                { 22023u, false },
                            },
                        }
                    },
                    {
                        37u,
                        new SC_Index_F1ValueType
                        {
                            Field1 = 37,
                            Field2 =
                            {
                                { 23001u, true },
                                { 23012u, true },
                                { 23014u, true },
                                { 23015u, true },
                                { 23019u, true },
                            },
                        }
                    },
                    {
                        39u,
                        new SC_Index_F1ValueType
                        {
                            Field1 = 39,
                            Field2 =
                            {
                                { 24001u, true },
                            },
                        }
                    },
                    {
                        40u,
                        new SC_Index_F1ValueType
                        {
                            Field1 = 40,
                            Field2 =
                            {
                                { 25001u, true },
                            },
                        }
                    },
                    {
                        60u,
                        new SC_Index_F1ValueType
                        {
                            Field1 = 60,
                            Field2 = { },
                        }
                    },
                    {
                        61u,
                        new SC_Index_F1ValueType
                        {
                            Field1 = 61,
                            Field2 = { },
                        }
                    },
                    {
                        133u,
                        new SC_Index_F1ValueType
                        {
                            Field1 = 133,
                            Field2 =
                            {
                                { 1335001u, false },
                                { 1335101u, false },
                            },
                        }
                    },
                },
                Field2 =
                {
                    {
                        36u,
                        new SC_Index_F2ValueType
                        {
                            Field1 =
                            {
                                { 22001u, 1703592104 },
                                { 22002u, 1728668611 },
                                { 22019u, 1737270231 },
                                { 22020u, 1736063989 },
                                { 22022u, 1737956678 },
                                { 22023u, 1731480838 },
                            },
                        }
                    },
                    {
                        37u,
                        new SC_Index_F2ValueType
                        {
                            Field1 =
                            {
                                { 23001u, 1703592104 },
                                { 23012u, 1703900704 },
                                { 23014u, 1703900704 },
                                { 23015u, 1704824955 },
                                { 23019u, 1703901382 },
                            },
                        }
                    },
                },
            };

            foreach (Costume costume in inventoryService.GetPlayerInventory<Costume>(connection.Account.Uid))
            {
                scIndex.Field1[13].Field2.Add(costume.CostumeId, true);
            }

            foreach (WeaponMod weaponMod in inventoryService.GetPlayerInventory<WeaponMod>(connection.Account.Uid))
            {
                scIndex.Field1[21].Field2.Add(weaponMod.WeaponModId, true);
            }

            foreach (WeaponSkin weaponSkin in inventoryService.GetPlayerInventory<WeaponSkin>(connection.Account.Uid))
            {
                scIndex.Field1[60].Field2.Add(weaponSkin.WeaponSkinId, true);
            }

            foreach (WeaponModSkin weaponModSkin in inventoryService.GetPlayerInventory<WeaponModSkin>(connection.Account.Uid))
            {
                scIndex.Field1[61].Field2.Add(weaponModSkin.WeaponModSkinId, true);
            }

            //connection.Send(2, scIndex);
            connection.SendAutoEncrypted(scIndex);
        }

        public override void HandleReadIndex(CS_ReadIndex request, Connection connection)
        {
            
        }
    }
}
