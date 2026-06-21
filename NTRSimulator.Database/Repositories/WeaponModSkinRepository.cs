using NTRSimulator.Database.Core;
using NTRSimulator.Database.Entities;

namespace NTRSimulator.Database.Repositories
{
    public sealed class WeaponModSkinRepository(NTRSimulatorDbContext db) : Repository<WeaponModSkin>(db), IWeaponModSkinRepository
    {
        public WeaponModSkin[] GetWeaponModSkinsByUid(uint uid)
        {
            return Db.WeaponModSkins.Where(s => s.Account.Uid == uid).ToArray();
        }

        public WeaponModSkin? GetById(uint id) => Db.WeaponModSkins.SingleOrDefault(s => s.Id == id);
    }

    public interface IWeaponModSkinRepository : IRepository<WeaponModSkin>
    {
        WeaponModSkin? GetById(uint id);
        WeaponModSkin[] GetWeaponModSkinsByUid(uint uid);
    }
}
