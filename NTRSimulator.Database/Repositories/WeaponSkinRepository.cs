using NTRSimulator.Database.Core;
using NTRSimulator.Database.Entities;

namespace NTRSimulator.Database.Repositories
{
    public sealed class WeaponSkinRepository(NTRSimulatorDbContext db) : Repository<WeaponSkin>(db), IWeaponSkinRepository
    {
        public WeaponSkin[] GetWeaponSkinsByUid(uint uid)
        {
            return Db.WeaponSkins.Where(s => s.Account.Uid == uid).ToArray();
        }

        public WeaponSkin? GetById(uint id) => Db.WeaponSkins.SingleOrDefault(s => s.Id == id);
    }

    public interface IWeaponSkinRepository : IRepository<WeaponSkin>
    {
        WeaponSkin? GetById(uint id);
        WeaponSkin[] GetWeaponSkinsByUid(uint uid);
    }
}
