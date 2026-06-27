using NTRSimulator.Database.Core;
using NTRSimulator.Database.Entities;

namespace NTRSimulator.Database.Repositories
{
    public sealed class WeaponSkinRepository(NTRSimulatorDbContext db) : Repository<WeaponSkinEntity>(db), IWeaponSkinRepository
    {
        public WeaponSkinEntity[] GetWeaponSkinsByUid(uint uid)
        {
            return Db.WeaponSkins.Where(s => s.Account.Uid == uid).ToArray();
        }

        public WeaponSkinEntity? GetById(uint id) => Db.WeaponSkins.SingleOrDefault(s => s.Id == id);
    }

    public interface IWeaponSkinRepository : IRepository<WeaponSkinEntity>
    {
        WeaponSkinEntity? GetById(uint id);
        WeaponSkinEntity[] GetWeaponSkinsByUid(uint uid);
    }
}
