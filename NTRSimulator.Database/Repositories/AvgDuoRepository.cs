using NTRSimulator.Database.Core;
using NTRSimulator.Database.Entities;

namespace NTRSimulator.Database.Repositories
{
    public sealed class AvgDuoRepository(NTRSimulatorDbContext db) : Repository<AvgDuoEntity>(db), IAvgDuoRepository
    {
        public AvgDuoEntity? GetByUid(uint uid)
        {
            return Db.AvgDuos.SingleOrDefault(a => a.Account.Uid == uid);
        }
    }

    public interface IAvgDuoRepository : IRepository<AvgDuoEntity>
    {
        AvgDuoEntity? GetByUid(uint uid);
    }
}
