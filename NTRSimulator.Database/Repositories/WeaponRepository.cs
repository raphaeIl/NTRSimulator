using NTRSimulator.Database.Core;
using NTRSimulator.Database.Entities;

namespace NTRSimulator.Database.Repositories
{
    public sealed class WeaponRepository(NTRSimulatorDbContext db) : Repository<WeaponEntity>(db), IWeaponRepository
    {
        public WeaponEntity[] GetWeaponsByUid(uint uid)
        {
            return Db.Weapons.Where(w => w.Account.Uid == uid).ToArray();
        }

        public WeaponEntity? GetById(uint id) => Db.Weapons.SingleOrDefault(w => w.Id == id);
    }

    public interface IWeaponRepository : IRepository<WeaponEntity>
    {
        WeaponEntity? GetById(uint id);
        WeaponEntity[] GetWeaponsByUid(uint uid);
    }
}
