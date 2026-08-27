using NTRSimulator.Common.Proto;
using NTRSimulator.Database.Entities;

namespace NTRSimulator.GameServer.Extensions;

public static class ProtoExtensions
{
    public static Gun ToProtoGunCharacter(this GunEntity gun)
    {
        ArgumentNullException.ThrowIfNull(gun);

        return new Gun
        {
            Id = gun.GunId,
            Timestamp = new DateTimeOffset(gun.TimeCreated).ToUnixTimeSeconds(),
            Level = (uint)gun.Level,
            GunClass = 5,
            Costume = gun.CostumeId,
            Exp = 120,
            Energy = 120,
            //Grade = 9,
            PrivateTalentSkillItems = { 0, 0, 0 },
            PublicTalentSkillItems = { 0, 0, 0 },
            PublicTalentSkillItemsUid = { 0, 0, 0 },
            IsGetPublicTalentSkillItem = true,
            //IsAllTalnetUnlock = true,
            //WeaponId = 739
        };
    }

    public static GunWeaponLite ToProtoWeapon(this WeaponEntity weapon)
    {
        ArgumentNullException.ThrowIfNull(weapon);

        return new GunWeaponLite
        {
            Id = weapon.Id,
            StcId = weapon.WeaponId,
            Level = (uint)weapon.Level,
            Exp = weapon.CurExp,
            GunId = weapon.GunId,
            BreakTimes = (uint)weapon.BreakTimes
        };
    }

    public static GunWeaponMod ToProtoWeaponMod(this WeaponModEntity weaponMod)
    {
        ArgumentNullException.ThrowIfNull(weaponMod);

        return new GunWeaponMod
        {
            Id = weaponMod.Id,
            StcId = weaponMod.WeaponModId,
            Level = weaponMod.Level,
            Exp = weaponMod.Field6,
            Suit = weaponMod.Field7
        };
    }
}
