using NTRSimulator.Database.Entities;
using NTRSimulator.Database.Repositories;
using NTRSimulator.Database.Services;
using NTRSimulator.Common.Table;

namespace NTRSimulator.GameServer.Services
{
    public sealed class CostumeService(
        ICostumeRepository costumeRepository,
        IAccountService accountService,
        ITableService tableService) : ICostumeService
    {
        public void AddAllCostumes(uint accountUid)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            var existingIds = new HashSet<uint>(account.Costumes.Select(c => c.CostumeId));
            var newCostumes = new List<CostumeEntity>();

            foreach (CostumeData data in tableService.GetTable<CostumeData>())
            {
                if (!existingIds.Add(data.Id))
                    continue;

                newCostumes.Add(new CostumeEntity { CostumeId = data.Id });
            }

            foreach (GunData data in tableService.GetTable<GunData>())
            {
                foreach (var costumeId in data.EILBLOLKOCM)
                {
                    if (!existingIds.Add(costumeId))
                        continue;

                    newCostumes.Add(new CostumeEntity { CostumeId = costumeId });
                }
            }

            account.AddCostumes(newCostumes);
            costumeRepository.SaveChanges();
        }

        public CostumeEntity[] GetPlayerCostumes(uint accountUid)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            return account.Costumes.ToArray();
        }

        public void AddCostume(uint accountUid, CostumeEntity costume)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            account.Costumes.Add(costume);
            costumeRepository.SaveChanges();
        }

        public bool RemoveCostume(uint accountUid, CostumeEntity costume)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            if (!account.Costumes.Remove(costume))
                return false;

            costumeRepository.SaveChanges();
            return true;
        }
    }

    public interface ICostumeService : IGameService
    {
        void AddAllCostumes(uint accountUid);
        CostumeEntity[] GetPlayerCostumes(uint accountUid);
        void AddCostume(uint accountUid, CostumeEntity costume);
        bool RemoveCostume(uint accountUid, CostumeEntity costume);
    }
}
