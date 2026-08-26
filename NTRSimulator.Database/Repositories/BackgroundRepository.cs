using NTRSimulator.Database.Core;
using NTRSimulator.Database.Entities;

namespace NTRSimulator.Database.Repositories
{
    public sealed class BackgroundRepository(NTRSimulatorDbContext db) : Repository<BackgroundEntity>(db), IBackgroundRepository
    {
        public BackgroundEntity[] GetBackgroundsByUid(uint uid)
        {
            return Db.Backgrounds.Where(b => b.Account.Uid == uid).ToArray();
        }

        public BackgroundEntity? GetById(uint id) => Db.Backgrounds.SingleOrDefault(b => b.Id == id);
    }

    public interface IBackgroundRepository : IRepository<BackgroundEntity>
    {
        BackgroundEntity? GetById(uint id);
        BackgroundEntity[] GetBackgroundsByUid(uint uid);
    }
}
