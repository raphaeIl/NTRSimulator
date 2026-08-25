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

            if (item is WeaponEntity weapon)
            {
                weaponService.AddWeapon(accountUid, weapon);
                return;
            }

            if (item is ItemEntity inventoryItem)
            {
                itemService.AddItem(accountUid, inventoryItem);
                return;
            }

            if (item is WeaponModEntity weaponMod)
            {
                weaponModService.AddWeaponMod(accountUid, weaponMod);
                return;
            }

            if (item is WeaponSkinEntity weaponSkin)
            {
                weaponSkinService.AddWeaponSkin(accountUid, weaponSkin);
                return;
            }

            if (item is WeaponModSkinEntity weaponModSkin)
            {
                weaponModSkinService.AddWeaponModSkin(accountUid, weaponModSkin);
                return;
            }

            if (item is CostumeEntity costume)
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

            if (item is WeaponEntity weapon)
            {
                return weaponService.RemoveWeapon(accountUid, weapon);
            }

            if (item is ItemEntity inventoryItem)
            {
                return itemService.RemoveItem(accountUid, inventoryItem);
            }

            if (item is WeaponModEntity weaponMod)
            {
                return weaponModService.RemoveWeaponMod(accountUid, weaponMod);
            }

            if (item is WeaponSkinEntity weaponSkin)
            {
                return weaponSkinService.RemoveWeaponSkin(accountUid, weaponSkin);
            }

            if (item is WeaponModSkinEntity weaponModSkin)
            {
                return weaponModSkinService.RemoveWeaponModSkin(accountUid, weaponModSkin);
            }

            if (item is CostumeEntity costume)
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

            if (typeof(T) == typeof(WeaponEntity))
            {
                weaponService.AddAllWeapons(accountUid);
                return;
            }

            if (typeof(T) == typeof(ItemEntity))
            {
                itemService.AddAllItems(accountUid);
                return;
            }

            if (typeof(T) == typeof(WeaponModEntity))
            {
                weaponModService.AddAllWeaponMods(accountUid);
                return;
            }

            if (typeof(T) == typeof(WeaponSkinEntity))
            {
                weaponSkinService.AddAllWeaponSkins(accountUid);
                return;
            }

            if (typeof(T) == typeof(WeaponModSkinEntity))
            {
                weaponModSkinService.AddAllWeaponModSkins(accountUid);
                return;
            }

            if (typeof(T) == typeof(CostumeEntity))
            {
                costumeService.AddAllCostumes(accountUid);
                return;
            }

            if (typeof(T) == typeof(AvgDuoEntity))
            {
                avgDuoService.AddAllAvgDuo(accountUid);
                return;
            }

            throw new NotSupportedException($"Inventory type '{typeof(T).Name}' is not supported.");
        }

        private static ICollection<T> GetCollection<T>(AccountEntity account) where T : class
        {
            if (typeof(T) == typeof(GunEntity))
                return (ICollection<T>)(object)account.Guns;

            if (typeof(T) == typeof(WeaponEntity))
                return (ICollection<T>)(object)account.Weapons;

            if (typeof(T) == typeof(ItemEntity))
                return (ICollection<T>)(object)account.Items;

            if (typeof(T) == typeof(WeaponModEntity))
                return (ICollection<T>)(object)account.WeaponMods;

            if (typeof(T) == typeof(WeaponSkinEntity))
                return (ICollection<T>)(object)account.WeaponSkins;

            if (typeof(T) == typeof(WeaponModSkinEntity))
                return (ICollection<T>)(object)account.WeaponModSkins;

            if (typeof(T) == typeof(CostumeEntity))
                return (ICollection<T>)(object)account.Costumes;

            throw new NotSupportedException($"Inventory type '{typeof(T).Name}' is not supported.");
        }

    }
}
