using System.Collections.Generic;
using System.Linq;
using NTRSimulator.Database.Entities;
using NTRSimulator.Database.Services;

namespace NTRSimulator.GameServer.Services
{
    public interface IInventoryService : IGameService
    {
        void Add<T>(uint accountUid, T item) where T : class;
        bool Remove<T>(uint accountUid, T item) where T : class;
        T[] GetPlayerInventory<T>(uint accountUid) where T : class;
        void AddAll<T>(uint accountUid) where T : class;
    }

    public sealed class InventoryService(
        IAccountService accountService,
        IGunService gunService,
        IWeaponService weaponService,
        IItemService itemService,
        IWeaponModService weaponModService,
        IWeaponSkinService weaponSkinService,
        IWeaponModSkinService weaponModSkinService,
        ICostumeService costumeService,
        IAvgDuoService avgDuoService) : IInventoryService
    {
        public void Add<T>(uint accountUid, T item) where T : class
        {
            ArgumentNullException.ThrowIfNull(item);

            if (item is GunEntity gun)
            {
                gunService.AddGun(accountUid, gun);
                return;
            }

            if (item is Weapon weapon)
            {
                weaponService.AddWeapon(accountUid, weapon);
                return;
            }

            if (item is Item inventoryItem)
            {
                itemService.AddItem(accountUid, inventoryItem);
                return;
            }

            if (item is WeaponMod weaponMod)
            {
                weaponModService.AddWeaponMod(accountUid, weaponMod);
                return;
            }

            if (item is WeaponSkin weaponSkin)
            {
                weaponSkinService.AddWeaponSkin(accountUid, weaponSkin);
                return;
            }

            if (item is WeaponModSkin weaponModSkin)
            {
                weaponModSkinService.AddWeaponModSkin(accountUid, weaponModSkin);
                return;
            }

            if (item is Costume costume)
            {
                costumeService.AddCostume(accountUid, costume);
                return;
            }

            throw new NotSupportedException($"Inventory type '{typeof(T).Name}' is not supported.");
        }

        public bool Remove<T>(uint accountUid, T item) where T : class
        {
            ArgumentNullException.ThrowIfNull(item);

            if (item is GunEntity gun)
            {
                return gunService.RemoveGun(accountUid, gun);
            }

            if (item is Weapon weapon)
            {
                return weaponService.RemoveWeapon(accountUid, weapon);
            }

            if (item is Item inventoryItem)
            {
                return itemService.RemoveItem(accountUid, inventoryItem);
            }

            if (item is WeaponMod weaponMod)
            {
                return weaponModService.RemoveWeaponMod(accountUid, weaponMod);
            }

            if (item is WeaponSkin weaponSkin)
            {
                return weaponSkinService.RemoveWeaponSkin(accountUid, weaponSkin);
            }

            if (item is WeaponModSkin weaponModSkin)
            {
                return weaponModSkinService.RemoveWeaponModSkin(accountUid, weaponModSkin);
            }

            if (item is Costume costume)
            {
                return costumeService.RemoveCostume(accountUid, costume);
            }

            throw new NotSupportedException($"Inventory type '{typeof(T).Name}' is not supported.");
        }

        public T[] GetPlayerInventory<T>(uint accountUid) where T : class
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            return GetCollection<T>(account).ToArray();
        }

        public void AddAll<T>(uint accountUid) where T : class
        {
            if (typeof(T) == typeof(GunEntity))
            {
                gunService.AddAllGuns(accountUid);
                return;
            }

            if (typeof(T) == typeof(Weapon))
            {
                weaponService.AddAllWeapons(accountUid);
                return;
            }

            if (typeof(T) == typeof(Item))
            {
                itemService.AddAllItems(accountUid);
                return;
            }

            if (typeof(T) == typeof(WeaponMod))
            {
                weaponModService.AddAllWeaponMods(accountUid);
                return;
            }

            if (typeof(T) == typeof(WeaponSkin))
            {
                weaponSkinService.AddAllWeaponSkins(accountUid);
                return;
            }

            if (typeof(T) == typeof(WeaponModSkin))
            {
                weaponModSkinService.AddAllWeaponModSkins(accountUid);
                return;
            }

            if (typeof(T) == typeof(Costume))
            {
                costumeService.AddAllCostumes(accountUid);
                return;
            }

            if (typeof(T) == typeof(AvgDuo))
            {
                avgDuoService.AddAllAvgDuo(accountUid);
                return;
            }

            throw new NotSupportedException($"Inventory type '{typeof(T).Name}' is not supported.");
        }

        private static ICollection<T> GetCollection<T>(Account account) where T : class
        {
            if (typeof(T) == typeof(GunEntity))
                return (ICollection<T>)(object)account.Guns;

            if (typeof(T) == typeof(Weapon))
                return (ICollection<T>)(object)account.Weapons;

            if (typeof(T) == typeof(Item))
                return (ICollection<T>)(object)account.Items;

            if (typeof(T) == typeof(WeaponMod))
                return (ICollection<T>)(object)account.WeaponMods;

            if (typeof(T) == typeof(WeaponSkin))
                return (ICollection<T>)(object)account.WeaponSkins;

            if (typeof(T) == typeof(WeaponModSkin))
                return (ICollection<T>)(object)account.WeaponModSkins;

            if (typeof(T) == typeof(Costume))
                return (ICollection<T>)(object)account.Costumes;

            throw new NotSupportedException($"Inventory type '{typeof(T).Name}' is not supported.");
        }

    }
}
