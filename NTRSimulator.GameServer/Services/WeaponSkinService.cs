using NTRSimulator.Common.Table;
using NTRSimulator.Database.Entities;
using NTRSimulator.Database.Repositories;
using NTRSimulator.Database.Services;

namespace NTRSimulator.GameServer.Services
{
    public sealed class WeaponSkinService(
        IWeaponSkinRepository weaponSkinRepository,
        IAccountService accountService,
        ITableService tableService) : IWeaponSkinService
    {
        public void AddAllWeaponSkins(uint accountUid)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            List<WeaponSkinData> skinData = tableService.GetTable<WeaponSkinData>();
            var existingSkinIds = new HashSet<uint>(account.WeaponSkins.Select(s => s.WeaponSkinId));

            var newSkins = skinData
                .Where(d => d.Id != 0 && !existingSkinIds.Contains(d.Id))
                .Select(d => new WeaponSkinEntity
                {
                    WeaponSkinId = d.Id,
                })
                .ToList();

            account.AddWeaponSkins(newSkins);
            weaponSkinRepository.SaveChanges();
        }

        public WeaponSkinEntity[] GetPlayerWeaponSkins(uint accountUid)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            return account.WeaponSkins.ToArray();
        }

        public void AddWeaponSkin(uint accountUid, WeaponSkinEntity weaponSkin)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            account.WeaponSkins.Add(weaponSkin);
            weaponSkinRepository.SaveChanges();
        }

        public bool RemoveWeaponSkin(uint accountUid, WeaponSkinEntity weaponSkin)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            if (!account.WeaponSkins.Remove(weaponSkin))
                return false;

            weaponSkinRepository.SaveChanges();
            return true;
        }
    }

    public interface IWeaponSkinService : IGameService
    {
        WeaponSkinEntity[] GetPlayerWeaponSkins(uint accountUid);
        void AddWeaponSkin(uint accountUid, WeaponSkinEntity weaponSkin);
        bool RemoveWeaponSkin(uint accountUid, WeaponSkinEntity weaponSkin);
        void AddAllWeaponSkins(uint accountUid);
    }
}
