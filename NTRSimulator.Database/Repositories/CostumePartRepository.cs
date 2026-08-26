using NTRSimulator.Database.Core;
using NTRSimulator.Database.Entities;

namespace NTRSimulator.Database.Repositories
{
    public sealed class CostumePartRepository(NTRSimulatorDbContext db) : Repository<CostumePartEntity>(db), ICostumePartRepository
    {
        public CostumePartEntity[] GetCostumePartsByUid(uint uid)
        {
            return Db.CostumeParts.Where(p => p.Account.Uid == uid).ToArray();
        }

        public CostumePartEntity? GetById(uint id) => Db.CostumeParts.SingleOrDefault(p => p.Id == id);
    }

    public interface ICostumePartRepository : IRepository<CostumePartEntity>
    {
        CostumePartEntity? GetById(uint id);
        CostumePartEntity[] GetCostumePartsByUid(uint uid);
    }
}
