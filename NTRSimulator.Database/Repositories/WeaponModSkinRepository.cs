using NTRSimulator.Database.Core;
using NTRSimulator.Database.Entities;

namespace NTRSimulator.Database.Repositories
{
    public sealed class WeaponModSkinRepository(NTRSimulatorDbContext db) : Repository<WeaponModSkinEntity>(db), IWeaponModSkinRepository
    {
        public WeaponModSkinEntity[] GetWeaponModSkinsByUid(uint uid)
        {
            return Db.WeaponModSkins.Where(s => s.Account.Uid == uid).ToArray();
        }

        public WeaponModSkinEntity? GetById(uint id) => Db.WeaponModSkins.SingleOrDefault(s => s.Id == id);
    }

    public interface IWeaponModSkinRepository : IRepository<WeaponModSkinEntity>
    {
        WeaponModSkinEntity? GetById(uint id);
        WeaponModSkinEntity[] GetWeaponModSkinsByUid(uint uid);
    }
}
