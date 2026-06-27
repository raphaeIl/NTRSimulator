using NTRSimulator.Database.Core;
using NTRSimulator.Database.Entities;

namespace NTRSimulator.Database.Repositories
{
    public sealed class WeaponModRepository(NTRSimulatorDbContext db) : Repository<WeaponModEntity>(db), IWeaponModRepository
    {
        public WeaponModEntity[] GetWeaponModsByUid(uint uid)
        {
            return Db.WeaponMods.Where(m => m.Account.Uid == uid).ToArray();
        }

        public WeaponModEntity? GetById(uint id) => Db.WeaponMods.SingleOrDefault(m => m.Id == id);
    }

    public interface IWeaponModRepository : IRepository<WeaponModEntity>
    {
        WeaponModEntity? GetById(uint id);
        WeaponModEntity[] GetWeaponModsByUid(uint uid);
    }
}
