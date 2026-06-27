using NTRSimulator.Database.Core;
using NTRSimulator.Database.Entities;

namespace NTRSimulator.Database.Repositories
{
    public sealed class ItemRepository(NTRSimulatorDbContext db) : Repository<ItemEntity>(db), IItemRepository
    {
        public ItemEntity[] GetItemsByUid(uint uid)
        {
            return Db.Items.Where(i => i.Account.Uid == uid).ToArray();
        }

        public ItemEntity? GetByItemId(uint uid, uint itemId) =>
            Db.Items.SingleOrDefault(i => i.Account.Uid == uid && i.ItemId == itemId);
    }

    public interface IItemRepository : IRepository<ItemEntity>
    {
        ItemEntity? GetByItemId(uint uid, uint itemId);
        ItemEntity[] GetItemsByUid(uint uid);
    }
}
