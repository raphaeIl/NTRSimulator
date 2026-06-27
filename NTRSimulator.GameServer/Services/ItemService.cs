using NTRSimulator.Database.Entities;
using NTRSimulator.Database.Repositories;
using NTRSimulator.Database.Services;
using NTRSimulator.Common.Table;

namespace NTRSimulator.GameServer.Services
{
    public sealed class ItemService(
        IItemRepository itemRepository,
        IAccountService accountService,
        ITableService tableService) : IItemService
    {
        private const int DefaultItemCount = 999;

        public void AddAllItems(uint accountUid)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            List<ItemData> itemData = tableService.GetTable<ItemData>();
            var existingItemIds = new HashSet<uint>(account.Items.Select(i => i.ItemId));

            var newItems = itemData
                .Where(d => d.Id != 0 && !existingItemIds.Contains(d.Id))
                .Select(d => new ItemEntity
                {
                    ItemId = d.Id,
                    Type = d.Type,
                    Count = DefaultItemCount,
                })
                .ToList();

            account.AddItems(newItems);
            itemRepository.SaveChanges();
        }

        public ItemEntity[] GetPlayerItems(uint accountUid)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            return account.Items.ToArray();
        }

        public void AddItem(uint accountUid, ItemEntity item)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            account.Items.Add(item);
            itemRepository.SaveChanges();
        }

        public bool RemoveItem(uint accountUid, ItemEntity item)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            if (!account.Items.Remove(item))
                return false;

            itemRepository.SaveChanges();
            return true;
        }
    }

    public interface IItemService : IGameService
    {
        ItemEntity[] GetPlayerItems(uint accountUid);
        void AddItem(uint accountUid, ItemEntity item);
        bool RemoveItem(uint accountUid, ItemEntity item);
        void AddAllItems(uint accountUid);
    }
}
