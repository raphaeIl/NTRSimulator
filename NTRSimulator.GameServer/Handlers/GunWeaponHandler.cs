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
            if (connection.Account == null) return;

            SC_GunWeapons scGunWeapons = new SC_GunWeapons();

            foreach (Weapon weapon in inventoryService.GetPlayerInventory<Weapon>(connection.Account.Uid))
            {
                scGunWeapons.GunWeapons.Add(weapon.ToProtoWeapon());

                if (weapon.GunId != 0)
                    scGunWeapons.Belong[weapon.Id] = weapon.GunId;
            }

            connection.SendAutoEncrypted(scGunWeapons);
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
                    Field1 = new SC_GetGunWeaponModLockPlan_F1Type
                    {
                        Field1 = false,
                    },
                };
                foreach ((uint Index, uint[] Slots, uint PlanField2) plan in plans)
                {
                    SC_DelGunWeaponModLockPlan_F1Type entry = new SC_DelGunWeaponModLockPlan_F1Type
                    {
                        Field1 = plan.Index,
                    };
                    SC_DelGunWeaponModLockPlan_F1Type_F2ValueType planValue = new SC_DelGunWeaponModLockPlan_F1Type_F2ValueType
                    {
                        Field2 = plan.PlanField2,
                    };
                    planValue.Field1.AddRange(plan.Slots);
                    entry.Field2[1] = planValue;
                    response.Field1.Field2.Add(entry);
                }
                connection.Send(1, response);
        }

        public override void HandleGunWeaponMods(CS_GunWeaponMods request, Connection connection)
        {
            if (connection.Account == null) return;

            WeaponMod[] mods = inventoryService.GetPlayerInventory<WeaponMod>(connection.Account.Uid);

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
                    response.GunWeaponMods.Add(mods[i].ToProtoWeaponMod());

                connection.SendAutoEncrypted(response);
                offset += ModsPerResponse;
            }
        }

        public override void HandleGunWeaponSkinItems(CS_GunWeaponSkinItems request, Connection connection)
        {
            if (connection.Account == null)
            {
                connection.Send(new SC_GunWeaponSkinItems { Field1 = { } });
                return;
            }

            SC_GunWeaponSkinItems response = new SC_GunWeaponSkinItems();
            foreach (WeaponSkin weaponSkin in inventoryService.GetPlayerInventory<WeaponSkin>(connection.Account.Uid))
                response.Field1[weaponSkin.WeaponSkinId] = 1;

            connection.Send(response);
        }

        public override void HandleGunWeaponModGetContinuouslyPolarization(CS_GunWeaponModGetContinuouslyPolarization request, Connection connection)
        {
                connection.Send(new SC_GunWeaponModGetContinuouslyPolarization
                {
                    Field1 = new SC_GunWeaponModGetContinuouslyPolarization_F1Type
                    {
                        Field3 = 0,
                        Field4 = 0,
                        Field6 = { },
                    },
                });
        }

        public override void HandleReplaceGunWeaponSkin(CS_ReplaceGunWeaponSkin request, Connection connection)
        {
            connection.Send(new SC_ReplaceGunWeaponSkin
            {
                Field1 = request.Field1,
                Field2 = request.Field2,
            });
        }

        public override void HandleUseGunWeaponSkin(CS_UseGunWeaponSkin request, Connection connection)
        {
            connection.Send(new SC_UseGunWeaponSkin
            {
                Field1 = request.Field1,
                Field2 = request.Field2,
            });
        }

        public override void HandleUnlockGunWeaponModSkin(CS_UnlockGunWeaponModSkin request, Connection connection)
        {
            connection.Send(new SC_UnlockGunWeaponModSkin
            {
                Field2 = request.Field2,
            });
        }

    }
}
