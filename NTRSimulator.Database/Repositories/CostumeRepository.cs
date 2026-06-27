using NTRSimulator.Database.Core;
using NTRSimulator.Database.Entities;

namespace NTRSimulator.Database.Repositories
{
    public sealed class CostumeRepository(NTRSimulatorDbContext db) : Repository<CostumeEntity>(db), ICostumeRepository
    {
        public bool ContainsCostume(uint uid, uint costumeId)
        {
            return Db.Costumes.Any(c => c.Account.Uid == uid && c.CostumeId == costumeId);
        }

        public CostumeEntity[] GetCostumesByUid(uint uid)
        {
            return Db.Costumes.Where(c => c.Account.Uid == uid).ToArray();
        }
    }

    public interface ICostumeRepository : IRepository<CostumeEntity>
    {
        CostumeEntity[] GetCostumesByUid(uint uid);
        bool ContainsCostume(uint uid, uint costumeId);
    }
}
