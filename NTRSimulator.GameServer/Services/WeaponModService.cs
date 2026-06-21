using NTRSimulator.Common.Table;
using NTRSimulator.Database.Entities;
using NTRSimulator.Database.Repositories;
using NTRSimulator.Database.Services;

namespace NTRSimulator.GameServer.Services
{
    public sealed class WeaponModService(
        IWeaponModRepository weaponModRepository,
        IAccountService accountService,
        ITableService tableService) : IWeaponModService
    {
        public void AddAllWeaponMods(uint accountUid)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            List<WeaponModData> modData = tableService.GetTable<WeaponModData>();
            var existingModIds = new HashSet<uint>(account.WeaponMods.Select(m => m.WeaponModId));

            var newMods = modData
                .Where(d => d.Field1 != 0 && !existingModIds.Contains(d.Field1))
                .Select(d => new WeaponMod
                {
                    WeaponModId = d.Field1,
                    Uid = GenerateUid(),
                    Level = 0,
                    Field5 = 0,
                    Field6 = 0,
                    Field7 = 0,
                })
                .ToList();

            account.AddWeaponMods(newMods);
            weaponModRepository.SaveChanges();
        }

        public WeaponMod[] GetPlayerWeaponMods(uint accountUid)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            return account.WeaponMods.ToArray();
        }

        public void AddWeaponMod(uint accountUid, WeaponMod weaponMod)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            account.WeaponMods.Add(weaponMod);
            weaponModRepository.SaveChanges();
        }

        public bool RemoveWeaponMod(uint accountUid, WeaponMod weaponMod)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            if (!account.WeaponMods.Remove(weaponMod))
                return false;

            weaponModRepository.SaveChanges();
            return true;
        }

        private static ulong nextUid;

        private static ulong GenerateUid() => ++nextUid;
    }

    public interface IWeaponModService : IGameService
    {
        WeaponMod[] GetPlayerWeaponMods(uint accountUid);
        void AddWeaponMod(uint accountUid, WeaponMod weaponMod);
        bool RemoveWeaponMod(uint accountUid, WeaponMod weaponMod);
        void AddAllWeaponMods(uint accountUid);
    }
}
