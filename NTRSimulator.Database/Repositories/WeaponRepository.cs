using NTRSimulator.Database.Core;
using NTRSimulator.Database.Entities;

namespace NTRSimulator.Database.Repositories
{
    public sealed class WeaponRepository(NTRSimulatorDbContext db) : Repository<Weapon>(db), IWeaponRepository
    {
        public Weapon[] GetWeaponsByUid(uint uid)
        {
            return Db.Weapons.Where(w => w.Account.Uid == uid).ToArray();
        }

        public Weapon? GetById(uint id) => Db.Weapons.SingleOrDefault(w => w.Id == id);
    }

    public interface IWeaponRepository : IRepository<Weapon>
    {
        Weapon? GetById(uint id);
        Weapon[] GetWeaponsByUid(uint uid);
    }
}
