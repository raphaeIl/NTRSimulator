using NTRSimulator.Database.Core;
using NTRSimulator.Database.Entities;

namespace NTRSimulator.Database.Repositories
{
    public sealed class WeaponModRepository(NTRSimulatorDbContext db) : Repository<WeaponMod>(db), IWeaponModRepository
    {
        public WeaponMod[] GetWeaponModsByUid(uint uid)
        {
            return Db.WeaponMods.Where(m => m.Account.Uid == uid).ToArray();
        }

        public WeaponMod? GetById(uint id) => Db.WeaponMods.SingleOrDefault(m => m.Id == id);
    }

    public interface IWeaponModRepository : IRepository<WeaponMod>
    {
        WeaponMod? GetById(uint id);
        WeaponMod[] GetWeaponModsByUid(uint uid);
    }
}
