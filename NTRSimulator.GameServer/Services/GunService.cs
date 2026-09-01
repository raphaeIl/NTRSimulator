using NTRSimulator.Common.Table;
using NTRSimulator.Database.Entities;
using NTRSimulator.Database.Repositories;
using NTRSimulator.Database.Services;
using Serilog;
using static NTRSimulator.Common.Proto.GunWeaponLite.Types;

namespace NTRSimulator.GameServer.Services
{
    public sealed class GunService(
        IGunRepository gunRepository,
        IAccountService accountService,
        ITableService tableService) : IGunService
    {
        public void AddAllGuns(uint accountUid)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            List<GunData> gunData = tableService.GetTable<GunData>();

            var existingGunIds = new HashSet<uint>(account.Guns.Select(g => g.GunId));
            foreach (GunData gData in gunData.Where(d => d.Id != 0 && !existingGunIds.Contains(d.Id)))
            {
                GunEntity gun = CreateDefault(gData, level: 60);
                account.Guns.Add(gun);

                uint? defaultWeaponId = GetDefaultWeaponId(gData);
                if (defaultWeaponId is uint weaponId)
                {
                    WeaponEntity weapon = CreateDefaultWeapon(weaponId, gData.Id);
                    account.Weapons.Add(weapon);
                    gunRepository.SaveChanges();
                    gun.WeaponId = weapon.Id;

                    Log.Information("AddAllGuns: added gun {GunId} with weapon {WeaponId} (uid {WeaponUid}) for account {AccountUid}",
                        gData.Id, weapon.WeaponId, weapon.Id, accountUid);
                }
                else
                {
                    Log.Information("AddAllGuns: added gun {GunId} without default weapon for account {AccountUid}",
                        gData.Id, accountUid);
                }
            }

            gunRepository.SaveChanges();
        }

        public GunEntity[] GetPlayerGuns(uint accountUid)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            return account.Guns.ToArray();
        }

        public void AddGun(uint accountUid, GunEntity gun)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            GunData? data = tableService.GetTable<GunData>().FirstOrDefault(d => d.Id == gun.GunId);

            account.Guns.Add(gun);

            uint defaultWeaponId = GetDefaultWeaponId(data);
            WeaponEntity weapon = CreateDefaultWeapon(defaultWeaponId, gun.GunId);
            
            account.Weapons.Add(weapon);

            gunRepository.SaveChanges();

            gun.WeaponId = weapon.Id;
            gunRepository.SaveChanges();
        }

        public bool RemoveGun(uint accountUid, GunEntity gun)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            if (!account.Guns.Remove(gun))
                return false;

            gunRepository.SaveChanges();
            return true;
        }

        public static GunEntity CreateDefault(GunData data, int level)
        {
            return new GunEntity
            {
                GunId = data.Id,
                Level = level,
                Exp = 120,
                Energy = 120,
                GunClass = level >= 60 ? 5u : 1u,
                CostumeId = data.GLMMIEHDLEG,
                CostumeParts = 0,
                Grade = 6,
                AuthLevel = 0,
                WeaponId = 0,
                IsGetPublicTalentSkillItem = false,
                IsAllTalentUnlock = false,
                Preset = 0,
                PresetId = 0,
                TalentResetNum = 0,
                PrivateTalentSkillItems = [0, 0, 0],
                PublicTalentSkillItems = [0, 0, 0],
                PublicTalentSkillItemsUid = [0, 0, 0],
                TalentTree = [],
                GunTalentConsume = [],
                LoveLevel = 1,
                LoveExp = 0,
                TimeCreated = DateTime.UtcNow,
            };
        }

        public static uint GetDefaultWeaponId(GunData data)
        {
            if (data.ILMACLKBCFF.Count > 0 && data.ILMACLKBCFF[0] != 0)
                return data.ILMACLKBCFF[0];
            if (data.WeaponPrivate.Count > 0 && data.WeaponPrivate[0] != 0)
                return data.WeaponPrivate[0];
            return 0;
        }

        public static WeaponEntity CreateDefaultWeapon(uint weaponId, uint gunId)
        {
            return new WeaponEntity
            {
                WeaponId = weaponId,
                Level = 1,
                CurExp = 0,
                BreakTimes = 1,
                GunId = gunId,
                Flags = 0,
                EquippedSkinId = 0,
                EquippedModIds = [],
                TimeCreated = DateTime.UtcNow,
            };
        }
    }

    public interface IGunService : IGameService
    {
        GunEntity[] GetPlayerGuns(uint accountUid);
        void AddGun(uint accountUid, GunEntity gun);
        bool RemoveGun(uint accountUid, GunEntity gun);
        void AddAllGuns(uint accountUid);
    }
}
