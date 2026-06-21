using NTRSimulator.Common.Proto;
using NTRSimulator.Database.Entities;

namespace NTRSimulator.GameServer.Extensions;

public static class ProtoExtensions
{
    public static BattleReplayNbcopResult_F4Type_F3Type_F101Type_F12Type ToProtoGunCharacter(this Gun gun)
    {
        ArgumentNullException.ThrowIfNull(gun);

        return new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F12Type
        {
            GunId = gun.GunId,
            Field41 = 9,
            CreateTime = new DateTimeOffset(gun.TimeCreated).ToUnixTimeSeconds(),
            Level = (uint)gun.Level,
            AscensionLevel = 5,
            CostumeId = gun.CostumeId,
            Exp = 120,
            Field42 = { 0, 0, 0 },
            Field43 = { 0, 0, 0 },
            Field45 = { 0, 0, 0 },
            Field50 = new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F12Type_F50Type
            {
                Field1 = 1,
                Field2 = 0,
                Field3 = 0,
                Field4 = false,
                Field5 = 0
            },
            Field62 = gun.Id
        };
    }

    public static GunWeapon ToProtoWeapon(this Weapon weapon)
    {
        ArgumentNullException.ThrowIfNull(weapon);

        return new GunWeapon
        {
            Id = weapon.Id,
            WeaponId = weapon.WeaponId,
            Level = (uint)weapon.Level,
            CurExp = weapon.CurExp,
            Field5 = 0,
            BreakTimes = (uint)weapon.BreakTimes,
            GunId = weapon.GunId,
            ModSlots =
            {
                new GunWeaponModSlot { Field1 = 0, Field2 = 0 },
                new GunWeaponModSlot { Field1 = 0, Field2 = 0 },
                new GunWeaponModSlot { Field1 = 0, Field2 = 0 },
                new GunWeaponModSlot { Field1 = 0, Field2 = 0 }
            }
        };
    }

    public static GunWeaponMod ToProtoWeaponMod(this WeaponMod weaponMod)
    {
        ArgumentNullException.ThrowIfNull(weaponMod);

        return new GunWeaponMod
        {
            InstanceId = weaponMod.Id,
            WeaponModId = weaponMod.WeaponModId,
            Uid = weaponMod.Id,
            Level = weaponMod.Level,
            Field5 = weaponMod.Field5,
            Field6 = weaponMod.Field6,
            Field7 = weaponMod.Field7
        };
    }
}
