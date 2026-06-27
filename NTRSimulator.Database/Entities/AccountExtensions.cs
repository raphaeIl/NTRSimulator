using System.Collections.Generic;

namespace NTRSimulator.Database.Entities
{
    public static class AccountExtensions
    {
        public static void AddCostumes(this AccountEntity account, IReadOnlyList<CostumeEntity> costumes)
        {
            foreach (var costume in costumes)
                account.Costumes.Add(costume);
        }

        public static void AddGuns(this AccountEntity account, IReadOnlyList<GunEntity> guns)
        {
            foreach (var gun in guns)
                account.Guns.Add(gun);
        }

        public static void AddWeapons(this AccountEntity account, IReadOnlyList<WeaponEntity> weapons)
        {
            foreach (var weapon in weapons)
                account.Weapons.Add(weapon);
        }

        public static void AddItems(this AccountEntity account, IReadOnlyList<ItemEntity> items)
        {
            foreach (var item in items)
                account.Items.Add(item);
        }

        public static void AddWeaponMods(this AccountEntity account, IReadOnlyList<WeaponModEntity> weaponMods)
        {
            foreach (var weaponMod in weaponMods)
                account.WeaponMods.Add(weaponMod);
        }

        public static void AddWeaponSkins(this AccountEntity account, IReadOnlyList<WeaponSkinEntity> weaponSkins)
        {
            foreach (var weaponSkin in weaponSkins)
                account.WeaponSkins.Add(weaponSkin);
        }

        public static void AddWeaponModSkins(this AccountEntity account, IReadOnlyList<WeaponModSkinEntity> weaponModSkins)
        {
            foreach (var weaponModSkin in weaponModSkins)
                account.WeaponModSkins.Add(weaponModSkin);
        }
    }
}
