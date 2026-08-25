using NTRSimulator.Common.Table;
using NTRSimulator.Database.Entities;
using NTRSimulator.Database.Repositories;
using NTRSimulator.Database.Services;

namespace NTRSimulator.GameServer.Services
{
    public sealed class WeaponModSkinService(
        IWeaponModSkinRepository weaponModSkinRepository,
        IAccountService accountService,
        ITableService tableService) : IWeaponModSkinService
    {
        public void AddAllWeaponModSkins(uint accountUid)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            List<WeaponModSkinData> skinData = tableService.GetTable<WeaponModSkinData>();
            var existingSkinIds = new HashSet<uint>(account.WeaponModSkins.Select(s => s.WeaponModSkinId));

            var newSkins = skinData
                .Where(d => d.Id != 0 && !existingSkinIds.Contains(d.Id))
                .Select(d => new WeaponModSkinEntity
                {
                    WeaponModSkinId = d.Id,
                })
                .ToList();

            account.AddWeaponModSkins(newSkins);
            weaponModSkinRepository.SaveChanges();
        }

        public WeaponModSkinEntity[] GetPlayerWeaponModSkins(uint accountUid)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            return account.WeaponModSkins.ToArray();
        }

        public void AddWeaponModSkin(uint accountUid, WeaponModSkinEntity weaponModSkin)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            account.WeaponModSkins.Add(weaponModSkin);
            weaponModSkinRepository.SaveChanges();
        }

        public bool RemoveWeaponModSkin(uint accountUid, WeaponModSkinEntity weaponModSkin)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            if (!account.WeaponModSkins.Remove(weaponModSkin))
                return false;

            weaponModSkinRepository.SaveChanges();
            return true;
        }
    }

    public interface IWeaponModSkinService : IGameService
    {
        WeaponModSkinEntity[] GetPlayerWeaponModSkins(uint accountUid);
        void AddWeaponModSkin(uint accountUid, WeaponModSkinEntity weaponModSkin);
        bool RemoveWeaponModSkin(uint accountUid, WeaponModSkinEntity weaponModSkin);
        void AddAllWeaponModSkins(uint accountUid);
    }
}
