using NTRSimulator.Common.Proto;
using NTRSimulator.Database.Entities;

namespace NTRSimulator.GameServer.Extensions;

public static class ProtoExtensions
{
    public static Gun_3 ToProtoGunCharacter(this GunEntity gun)
    {
        ArgumentNullException.ThrowIfNull(gun);

        return new Gun_3
        {
            Id = gun.GunId,
            Exp = 120,
            Timestamp = new DateTimeOffset(gun.TimeCreated).ToUnixTimeSeconds(),
            Level = (uint)gun.Level,
            GunClass = 5,
            Costume = gun.CostumeId,
            Grade = 9,
            Energy = 4,
            PrivateTalentSkillItems = { 0, 0, 0 },
            PublicTalentSkillItems = { 0, 0, 0 },
            PublicTalentSkillItemsUid = { 0, 0, 0 },
            JJKGLEOOAPH = new LoungeChatMessage
            {
                KFIAKLNJHMB = 1,
                ABOJJOJODME = 0,
                FDKIHAPHHPD = 0,
                APPPIAJDHLD = false,
                PCPEAMOJPCF = 0
            },
            WeaponId = gun.Id
        };
    }

    public static GunWeapon_2 ToProtoWeapon(this WeaponEntity weapon)
    {
        ArgumentNullException.ThrowIfNull(weapon);

        return new GunWeapon_2
        {
            Id = weapon.Id,
            StcId = weapon.WeaponId,
            Level = (uint)weapon.Level,
            Exp = weapon.CurExp,
            GunId = weapon.GunId,
            BreakTimes = (uint)weapon.BreakTimes,
            WeaponMods = { 0, 0, 0, 0 }
        };
    }

    public static GunWeaponMod_2 ToProtoWeaponMod(this WeaponModEntity weaponMod)
    {
        ArgumentNullException.ThrowIfNull(weaponMod);

        return new GunWeaponMod_2
        {
            Id = weaponMod.Id,
            StcId = weaponMod.WeaponModId,
            Level = weaponMod.Level,
            Exp = weaponMod.Field6,
            Suit = weaponMod.Field7
        };
    }
}
