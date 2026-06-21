using System.Collections.Generic;

namespace NTRSimulator.Database.Entities
{
    public static class AccountExtensions
    {
        public static void AddCostumes(this Account account, IReadOnlyList<Costume> costumes)
        {
            foreach (var costume in costumes)
                account.Costumes.Add(costume);
        }

        public static void AddGuns(this Account account, IReadOnlyList<Gun> guns)
        {
            foreach (var gun in guns)
                account.Guns.Add(gun);
        }

        public static void AddWeapons(this Account account, IReadOnlyList<Weapon> weapons)
        {
            foreach (var weapon in weapons)
                account.Weapons.Add(weapon);
        }

        public static void AddItems(this Account account, IReadOnlyList<Item> items)
        {
            foreach (var item in items)
                account.Items.Add(item);
        }

        public static void AddWeaponMods(this Account account, IReadOnlyList<WeaponMod> weaponMods)
        {
            foreach (var weaponMod in weaponMods)
                account.WeaponMods.Add(weaponMod);
        }

        public static void AddWeaponSkins(this Account account, IReadOnlyList<WeaponSkin> weaponSkins)
        {
            foreach (var weaponSkin in weaponSkins)
                account.WeaponSkins.Add(weaponSkin);
        }

        public static void AddWeaponModSkins(this Account account, IReadOnlyList<WeaponModSkin> weaponModSkins)
        {
            foreach (var weaponModSkin in weaponModSkins)
                account.WeaponModSkins.Add(weaponModSkin);
        }
    }
}
