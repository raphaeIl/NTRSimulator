using NTRSimulator.Database.Core;
using NTRSimulator.Database.Entities;
using System.Collections.Generic;
using System.Linq;

namespace NTRSimulator.Database.Repositories
{
    public sealed class CostumeRepository(NTRSimulatorDbContext db) : Repository<Costume>(db), ICostumeRepository
    {
        public bool ContainsCostume(uint uid, uint costumeId)
        {
            return Db.Costumes.Any(c => c.Account.Uid == uid && c.CostumeId == costumeId);
        }

        public Costume[] GetCostumesByUid(uint uid)
        {
            return Db.Costumes.Where(c => c.Account.Uid == uid).ToArray();
        }
    }

    public interface ICostumeRepository : IRepository<Costume>
    {
        Costume[] GetCostumesByUid(uint uid);
        bool ContainsCostume(uint uid, uint costumeId);
    }
}
