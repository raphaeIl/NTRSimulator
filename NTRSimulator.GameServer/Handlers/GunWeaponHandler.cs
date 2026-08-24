using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;
using NTRSimulator.Common.Protocol;
using NTRSimulator.Database.Entities;
using NTRSimulator.GameServer.Extensions;
using NTRSimulator.GameServer.Services;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class GunWeaponHandler(
        IInventoryService inventoryService) : GunWeaponHandlerBase
    {
        // Official captures send 50 mods per SC_GunWeaponMods (see all_skins.json).
        private const int ModsPerResponse = 50;

        public override void HandleGunWeapons(CS_GunWeapons request, Connection connection)
        {
            connection.SendAutoEncrypted(new SC_GunWeapons
            {
                Weapons =
                {
                    new GunWeaponLite
                    {
                        Id = 739,
                        StcId = 11056,
                        Level = 60,
                        GunId = 0,
                    },
                    new GunWeaponLite
                    {
                        Id = 455,
                        StcId = 11073,
                        Level = 20,
                        GunId = 0,
                    },
                },
                FEDCFGGDNBN =
                {
                    [739] = 1056,
                    [455] = 1073,
                },
            });
        }

        public override void HandleGetGunWeaponModLockPlan(CS_GetGunWeaponModLockPlan request, Connection connection)
        {
                (uint Index, uint[] Slots, uint PlanField2)[] plans =
                {
                    (0, new uint[] { 1, 2, 9 }, 2),
                    (1, new uint[] { 1, 2, 4 }, 2),
                    (2, new uint[] { 1, 2, 9 }, 2),
                    (3, new uint[] { 1, 2, 10 }, 3),
                    (4, new uint[] { 1, 2, 4 }, 2),
                    (5, new uint[] { 1, 2, 4 }, 2),
                    (6, new uint[] { 1, 2, 4 }, 2),
                    (7, new uint[] { 1, 2, 10 }, 3),
                    (8, new uint[] { 1, 2, 10 }, 3),
                    (9, new uint[] { 1, 2, 10 }, 3),
                    (10, new uint[] { 1, 2, 10 }, 3),
                    (11, new uint[] { 1, 2, 10 }, 3),
                    (12, new uint[] { 1, 2, 10 }, 3),
                    (13, new uint[] { 1, 2, 9 }, 3),
                    (14, new uint[] { 1, 2, 9 }, 3),
                    (15, new uint[] { 1, 2, 9 }, 3),
                    (16, new uint[] { 1, 2, 9 }, 3),
                };
                SC_GetGunWeaponModLockPlan response = new SC_GetGunWeaponModLockPlan
                {
                    DEOAAPJBIGP = new AOEAJGGGBBM
                    {
                        KJDFHNBFOMB = false,
                    },
                };
                foreach ((uint Index, uint[] Slots, uint PlanField2) plan in plans)
                {
                    CDANONKGCHB entry = new CDANONKGCHB
                    {
                        BEFHELAINLN = plan.Index,
                    };
                    CDANONKGCHB.Types.BHHOCNGPPJN planValue = new CDANONKGCHB.Types.BHHOCNGPPJN
                    {
                        IFKCJEAGCFH = plan.PlanField2,
                    };
                    planValue.CEAEBKMHDCJ.AddRange(plan.Slots);
                    entry.KKLPCCBIFOM[1] = planValue;
                    response.DEOAAPJBIGP.PMDFJCLFFPB.Add(entry);
                }
                connection.Send(1, response);
        }

        public override void HandleGunWeaponMods(CS_GunWeaponMods request, Connection connection)
        {
            if (connection.Account == null) return;

            WeaponModEntity[] mods = inventoryService.GetPlayerInventory<WeaponModEntity>(connection.Account.Uid);

            if (mods.Length == 0)
            {
                connection.SendAutoEncrypted(new SC_GunWeaponMods());
                return;
            }

            int offset = 0;
            while (offset < mods.Length)
            {
                SC_GunWeaponMods response = new SC_GunWeaponMods();
                int end = Math.Min(offset + ModsPerResponse, mods.Length);

                for (int i = offset; i < end; i++)
                    response.Mods.Add(mods[i].ToProtoWeaponMod());

                connection.SendAutoEncrypted(response);
                offset += ModsPerResponse;
            }
        }

        public override void HandleGunWeaponSkinItems(CS_GunWeaponSkinItems request, Connection connection)
        {
            if (connection.Account == null)
            {
                connection.Send(new SC_GunWeaponSkinItems { PGMKLGCFAOF = { } });
                return;
            }

            SC_GunWeaponSkinItems response = new SC_GunWeaponSkinItems();
            foreach (WeaponSkinEntity weaponSkin in inventoryService.GetPlayerInventory<WeaponSkinEntity>(connection.Account.Uid))
                response.PGMKLGCFAOF[weaponSkin.WeaponSkinId] = 1;

            connection.Send(response);
        }

        public override void HandleGunWeaponModGetContinuouslyPolarization(CS_GunWeaponModGetContinuouslyPolarization request, Connection connection)
        {
                connection.Send(new SC_GunWeaponModGetContinuouslyPolarization
                {
                    NHJFCEMIPEO = new GEDLLJGMIED
                    {
                        AMKICOIHKPD = 0,
                        DDGMKANMOLN = 0,
                        GENGCMEPHFM = { },
                    },
                });
        }

        public override void HandleReplaceGunWeaponSkin(CS_ReplaceGunWeaponSkin request, Connection connection)
        {
            connection.Send(new SC_ReplaceGunWeaponSkin
            {
                Id = request.Id,
                GunId = request.GunId,
            });
        }

        public override void HandleUseGunWeaponSkin(CS_UseGunWeaponSkin request, Connection connection)
        {
            connection.Send(new SC_UseGunWeaponSkin
            {
                Id = request.Id,
                PMKFBMGBDNP = request.PMKFBMGBDNP,
            });
        }

        public override void HandleUnlockGunWeaponModSkin(CS_UnlockGunWeaponModSkin request, Connection connection)
        {
            connection.Send(new SC_UnlockGunWeaponModSkin
            {
                GunId = request.GunId,
            });
        }

    }
}
