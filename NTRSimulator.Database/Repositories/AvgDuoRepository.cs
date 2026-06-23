using NTRSimulator.Database.Core;
using NTRSimulator.Database.Entities;

namespace NTRSimulator.Database.Repositories
{
    public sealed class AvgDuoRepository(NTRSimulatorDbContext db) : Repository<AvgDuo>(db), IAvgDuoRepository
    {
        public AvgDuo? GetByUid(uint uid)
        {
            return Db.AvgDuos.SingleOrDefault(a => a.Account.Uid == uid);
        }
    }

    public interface IAvgDuoRepository : IRepository<AvgDuo>
    {
        AvgDuo? GetByUid(uint uid);
    }
}
