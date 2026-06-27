using NTRSimulator.Database.Core;
using NTRSimulator.Database.Entities;

namespace NTRSimulator.Database.Repositories
{
    public sealed class GunRepository(NTRSimulatorDbContext db) : Repository<GunEntity>(db), IGunRepository
    {
        public List<GunEntity> GetGunsByUid(uint uid)
        {
            return Db.Guns.Where(g => g.Account.Uid == uid).ToList();
        }

        public void DeleteAll()
        {
            Db.Guns.RemoveRange(Db.Guns);
        }

        public int Count() => Db.Guns.Count();

        public GunEntity? GetById(uint id) => Db.Guns.SingleOrDefault(g => g.Id == id);
    }

    public interface IGunRepository : IRepository<GunEntity>
    {
        GunEntity? GetById(uint id);
        int Count();
        List<GunEntity> GetGunsByUid(uint uid);
        void DeleteAll();
    }
}
