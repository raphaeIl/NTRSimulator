using NTRSimulator.Database.Entities;
using NTRSimulator.Database.Repositories;
using NTRSimulator.Database.Services;
using NTRSimulator.Common.Table;

namespace NTRSimulator.GameServer.Services
{
    public sealed class GunService(
        IGunRepository gunRepository,
        IAccountService accountService,
        ITableService tableService) : IGunService
    {
        public void AddAllGuns(uint accountUid)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            List<GunData> gunData = tableService.GetTable<GunData>();
            var existingGunIds = new HashSet<uint>(account.Guns.Select(g => g.GunId));

            var newGuns = gunData
                .Where(d => !existingGunIds.Contains(d.Id))
                .Select(d => new GunEntity
                {
                    GunId = d.Id,
                    Level = 60,
                    CostumeId = d.Avatar,
                    TimeCreated = DateTime.UtcNow,
                })
                .ToList();

            account.AddGuns(newGuns);
            gunRepository.SaveChanges();
        }

        public GunEntity[] GetPlayerGuns(uint accountUid)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            return account.Guns.ToArray();
        }

        public void AddGun(uint accountUid, GunEntity gun)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            account.Guns.Add(gun);

            gunRepository.SaveChanges();
        }

        public bool RemoveGun(uint accountUid, GunEntity gun)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            if (!account.Guns.Remove(gun))
                return false;

            gunRepository.SaveChanges();
            return true;
        }
    }

    public interface IGunService : IGameService
    {
        GunEntity[] GetPlayerGuns(uint accountUid);
        void AddGun(uint accountUid, GunEntity gun);
        bool RemoveGun(uint accountUid, GunEntity gun);
        void AddAllGuns(uint accountUid);
    }
}
