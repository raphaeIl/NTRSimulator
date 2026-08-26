using NTRSimulator.Common.Table;
using NTRSimulator.Database.Entities;
using NTRSimulator.Database.Repositories;
using NTRSimulator.Database.Services;

namespace NTRSimulator.GameServer.Services
{
    public sealed class CostumePartService(
        ICostumePartRepository costumePartRepository,
        IAccountService accountService,
        ITableService tableService) : ICostumePartService
    {
        public void AddAllCostumeParts(uint accountUid)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            List<PartsListData> partData = tableService.GetTable<PartsListData>();
            var existingPartIds = new HashSet<uint>(account.CostumeParts.Select(p => p.CostumePartId));

            var newParts = partData
                .Where(d => d.ItemId != 0 && !existingPartIds.Contains(d.ItemId))
                .Select(d => new CostumePartEntity
                {
                    CostumePartId = d.ItemId,
                })
                .ToList();

            account.AddCostumeParts(newParts);
            costumePartRepository.SaveChanges();
        }

        public CostumePartEntity[] GetPlayerCostumeParts(uint accountUid)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            return account.CostumeParts.ToArray();
        }

        public void AddCostumePart(uint accountUid, CostumePartEntity costumePart)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            account.CostumeParts.Add(costumePart);
            costumePartRepository.SaveChanges();
        }

        public bool RemoveCostumePart(uint accountUid, CostumePartEntity costumePart)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            if (!account.CostumeParts.Remove(costumePart))
                return false;

            costumePartRepository.SaveChanges();
            return true;
        }
    }

    public interface ICostumePartService : IGameService
    {
        CostumePartEntity[] GetPlayerCostumeParts(uint accountUid);
        void AddCostumePart(uint accountUid, CostumePartEntity costumePart);
        bool RemoveCostumePart(uint accountUid, CostumePartEntity costumePart);
        void AddAllCostumeParts(uint accountUid);
    }
}
