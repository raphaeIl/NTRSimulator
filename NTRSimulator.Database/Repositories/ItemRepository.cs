using NTRSimulator.Database.Core;
using NTRSimulator.Database.Entities;

namespace NTRSimulator.Database.Repositories
{
    public sealed class ItemRepository(NTRSimulatorDbContext db) : Repository<Item>(db), IItemRepository
    {
        public Item[] GetItemsByUid(uint uid)
        {
            return Db.Items.Where(i => i.Account.Uid == uid).ToArray();
        }

        public Item? GetByItemId(uint uid, uint itemId) =>
            Db.Items.SingleOrDefault(i => i.Account.Uid == uid && i.ItemId == itemId);
    }

    public interface IItemRepository : IRepository<Item>
    {
        Item? GetByItemId(uint uid, uint itemId);
        Item[] GetItemsByUid(uint uid);
    }
}
