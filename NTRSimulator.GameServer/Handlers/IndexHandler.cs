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
                                { 1009u, false },
                                { 1013u, false },
                                { 1015u, false },
                                { 1017u, false },
                                { 1021u, false },
                                { 1022u, false },
                                { 1023u, false },
                                { 1024u, false },
                                { 1025u, false },
                                { 1026u, false },
                                { 1027u, false },
                                { 1029u, false },
                                { 1032u, false },
                                { 1033u, false },
                                { 1034u, false },
                                { 1035u, false },
                                { 1036u, false },
                                { 1038u, false },
                                { 1039u, false },
                                { 1040u, false },
                                { 1042u, false },
                                { 1043u, false },
                                { 1044u, false },
                                { 1045u, false },
                                { 1047u, false },
                                { 1048u, false },
                                { 1049u, false },
                                { 1050u, false },
                                { 1051u, false },
                                { 1052u, false },
                                { 1053u, false },
                                { 1054u, false },
                                { 1055u, false },
                                { 1056u, false },
                                { 1057u, false },
                                { 1058u, false },
                                { 1059u, false },
                                { 1060u, false },
                                { 1061u, false },
                                { 1062u, false },
                                { 1063u, false },
                                { 1064u, false },
                                { 1065u, false },
                                { 1066u, false },
                                { 1068u, false },
                                { 1069u, false },
                                { 1070u, false },
                                { 1071u, false },
                                { 1072u, false },
                                { 1073u, false },
                                { 1074u, false },
                                { 1076u, false },
                                { 1077u, false },
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
                                { 21002u, true },
                                { 21003u, true },
                                { 21004u, true },
                                { 21005u, true },
                                { 21008u, true },
                                { 21009u, true },
                                { 21010u, true },
                                { 21011u, true },
                                { 21012u, true },
                                { 21014u, true },
                                { 21015u, true },
                                { 21025u, true },
                                { 21026u, true },
                                { 21027u, true },
                                { 21028u, true },
                                { 21029u, true },
                                { 21030u, true },
                                { 21031u, true },
                                { 21032u, true },
                                { 21033u, true },
                                { 21034u, true },
                                { 21035u, true },
                                { 21036u, true },
                                { 21038u, true },
                                { 21039u, true },
                                { 21040u, true },
                                { 21041u, true },
                                { 21042u, true },
                                { 21045u, true },
                                { 21053u, true },
                                { 21054u, true },
                                { 21055u, true },
                                { 21056u, true },
                                { 21057u, true },
                                { 21058u, true },
                                { 21060u, true },
                                { 21061u, true },
                                { 21063u, true },
                                { 21064u, true },
                                { 21065u, true },
                                { 21066u, true },
                                { 21068u, true },
                                { 21069u, true },
                                { 21070u, true },
                                { 21071u, true },
                                { 21072u, true },
                                { 21073u, true },
                                { 21077u, true },
                                { 21080u, true },
                                { 21086u, true },
                                { 21087u, true },
                                { 21088u, true },
                                { 21089u, true },
                                { 21090u, true },
                                { 21091u, true },
                                { 21092u, true },
                                { 21093u, true },
                                { 21094u, true },
                                { 21095u, true },
                                { 21096u, true },
                                { 21097u, true },
                                { 21098u, true },
                                { 21099u, true },
                                { 21100u, true },
                                { 21102u, true },
                                { 21103u, true },
                                { 21104u, true },
                                { 21105u, true },
                                { 21106u, true },
                                { 21110u, true },
                                { 21111u, true },
                                { 21156u, true },
                                { 21157u, true },
                                { 21158u, true },
                                { 21160u, true },
                                { 21162u, true },
                                { 21165u, true },
                                { 21166u, true },
                                { 21167u, true },
                                { 21168u, true },
                                { 21169u, true },
                                { 21173u, true },
                                { 21174u, true },
                                { 21175u, true },
                                { 21177u, true },
                                { 21178u, true },
                                { 21179u, true },
                                { 21181u, true },
                                { 21182u, true },
                                { 21185u, true },
                                { 21187u, true },
                                { 21188u, true },
                                { 21191u, true },
                                { 21192u, true },
                                { 21193u, true },
                                { 21197u, true },
                                { 21198u, true },
                                { 21200u, true },
                                { 21201u, true },
                                { 21202u, true },
                                { 21204u, true },
                                { 21205u, true },
                                { 21206u, true },
                                { 21207u, true },
                                { 21208u, true },
                                { 21210u, true },
                                { 21213u, true },
                                { 21214u, true },
                                { 21215u, true },
                                { 21216u, true },
                                { 21227u, true },
                                { 21228u, true },
                                { 21233u, true },
                                { 21234u, true },
                                { 21243u, true },
                                { 21244u, true },
                                { 21248u, true },
                                { 21249u, true },
                                { 21251u, true },
                                { 21252u, true },
                                { 21256u, true },
                                { 21260u, true },
                                { 21263u, true },
                                { 21264u, true },
                                { 21265u, true },
                                { 21266u, true },
                                { 21501u, true },
                                { 21502u, true },
                                { 21503u, true },
                                { 21504u, true },
                                { 21506u, true },
                                { 21507u, true },
                                { 21901u, true },
                                { 21902u, true },
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
                                { 11014u, false },
                                { 11015u, false },
                                { 11016u, false },
                                { 11017u, false },
                                { 11020u, false },
                                { 11021u, false },
                                { 11022u, false },
                                { 11023u, false },
                                { 11024u, false },
                                { 11026u, false },
                                { 11030u, false },
                                { 11031u, false },
                                { 11036u, false },
                                { 11037u, false },
                                { 11038u, false },
                                { 11039u, false },
                                { 11040u, false },
                                { 11042u, false },
                                { 11043u, false },
                                { 11044u, false },
                                { 11045u, false },
                                { 11046u, false },
                                { 11047u, false },
                                { 11048u, false },
                                { 11049u, false },
                                { 11051u, false },
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
                        30u,
                        new SC_Index_F1ValueType
                        {
                            Field1 = 30,
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
                                { 23020u, true },
                                { 23021u, true },
                                { 23022u, true },
                                { 23023u, true },
                                { 23024u, true },
                                { 23039u, true },
                                { 23040u, true },
                                { 23041u, true },
                                { 23043u, true },
                                { 23044u, true },
                                { 23045u, true },
                                { 23053u, true },
                                { 23054u, true },
                                { 23056u, true },
                                { 23057u, true },
                                { 23059u, true },
                                { 23060u, true },
                                { 23061u, true },
                                { 23062u, true },
                                { 23064u, true },
                                { 23065u, true },
                                { 23066u, true },
                                { 23067u, true },
                                { 23068u, true },
                                { 23069u, true },
                                { 23074u, true },
                                { 23075u, true },
                                { 23076u, true },
                                { 23077u, true },
                                { 23078u, true },
                                { 23079u, true },
                                { 23080u, true },
                                { 23081u, true },
                                { 23082u, true },
                                { 23083u, true },
                                { 23085u, true },
                                { 23086u, true },
                                { 23087u, true },
                                { 23089u, true },
                                { 23090u, true },
                                { 23091u, true },
                                { 23092u, true },
                                { 23093u, true },
                                { 23141u, true },
                                { 23143u, true },
                                { 23144u, true },
                                { 23145u, true },
                                { 23146u, true },
                                { 23147u, true },
                                { 23158u, true },
                                { 23160u, true },
                                { 23163u, true },
                                { 23164u, true },
                                { 23165u, true },
                                { 23166u, true },
                                { 23167u, true },
                                { 23169u, true },
                                { 23171u, true },
                                { 23173u, true },
                                { 23174u, true },
                                { 23175u, true },
                                { 23176u, true },
                                { 23177u, true },
                                { 23178u, true },
                                { 23179u, true },
                                { 23180u, true },
                                { 23200u, true },
                                { 23202u, true },
                                { 23204u, true },
                                { 23206u, true },
                                { 23208u, true },
                                { 23400u, true },
                                { 23401u, true },
                                { 23402u, true },
                                { 23403u, true },
                                { 23405u, true },
                                { 23406u, true },
                                { 23407u, true },
                                { 25000u, true },
                                { 231204u, true },
                                { 232306u, true },
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
                                { 24032u, true },
                                { 24056u, true },
                                { 24057u, true },
                                { 24061u, true },
                                { 24063u, true },
                                { 24108u, true },
                                { 24109u, true },
                                { 24110u, true },
                                { 24111u, true },
                                { 24112u, true },
                                { 24113u, true },
                                { 24115u, true },
                                { 24129u, true },
                                { 24130u, true },
                                { 24131u, true },
                                { 24132u, true },
                                { 24133u, true },
                                { 24136u, true },
                                { 24139u, true },
                                { 24140u, true },
                                { 24141u, true },
                                { 24142u, true },
                                { 24143u, true },
                                { 24148u, true },
                                { 24149u, true },
                                { 24150u, true },
                                { 24151u, true },
                                { 24152u, true },
                                { 24153u, true },
                                { 24154u, true },
                                { 24159u, true },
                                { 24160u, true },
                                { 24161u, true },
                                { 24162u, true },
                                { 24163u, true },
                                { 24164u, true },
                                { 24166u, true },
                                { 24169u, true },
                                { 24170u, true },
                                { 24171u, true },
                                { 24172u, true },
                                { 24176u, true },
                                { 24178u, true },
                                { 24179u, true },
                                { 24184u, true },
                                { 24186u, true },
                                { 24190u, true },
                                { 24193u, true },
                                { 24194u, true },
                                { 24195u, true },
                                { 24200u, true },
                                { 24201u, true },
                                { 24202u, true },
                                { 24203u, true },
                                { 24204u, true },
                                { 24205u, true },
                            },
                        }
                    },
                    {
                        40u,
                        new SC_Index_F1ValueType
                        {
                            Field1 = 40, // DO NOT ENABLE, why does this break the whole menu
                            Field2 =
                            {
                                { 25001u, true },
                                // { 25009u, true },
                                // { 25016u, false },
                                // { 25021u, true },
                            },
                        }
                    },
                    {
                        60u,
                        new SC_Index_F1ValueType
                        {
                            Field1 = 60,
                            Field2 =
                            {
 
                            },
                        }
                    },
                    {
                        61u,
                        new SC_Index_F1ValueType
                        {
                            Field1 = 61,
                            Field2 =
                            {
 
                            },
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
                                //{ 1335002u, false },
                                { 1335101u, false },
                            },
                        }
                    },
                    {
                        162u,    // special char cgs
                        new SC_Index_F1ValueType
                        {
                            Field1 = 162, 
                            Field2 =
                            {
                                { 1630001u, false },
                                { 1630002u, false },
                                { 1630003u, false },
                                { 1630004u, false },
                                { 1630005u, false },
                                { 1630006u, false },
                                { 1630007u, false },
                            },
                        }
                    },
                    {
                        171u,
                        new SC_Index_F1ValueType
                        {
                            Field1 = 171,
                            Field2 =
                            {
                                { 1600001u, false },
                                { 1600002u, false },
                            },
                        }
                    },
                    {
                        181u,
                        new SC_Index_F1ValueType
                        {
                            Field1 = 181,
                            Field2 =
                            {
                                { 1581008u, false },
                            },
                        }
                    },
                    {
                        201u,
                        new SC_Index_F1ValueType
                        {
                            Field1 = 201,
                            Field2 =
                            {
                                { 1002u, false },
                                { 2001u, false },
                                { 2002u, false },
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
