using NTRSimulator.Common.Proto;
using NTRSimulator.Database.Entities;

namespace NTRSimulator.GameServer.Extensions;

public static class ProtoExtensions
{
    public static Gun ToProtoGunCharacter(this GunEntity gun)
    {
        ArgumentNullException.ThrowIfNull(gun);

        var proto = new Gun
        {
            Id = gun.GunId,
            Timestamp = new DateTimeOffset(gun.TimeCreated).ToUnixTimeSeconds(),
            Level = (uint)gun.Level,
            GunClass = gun.GunClass,
            Costume = gun.CostumeId,
            CostumeParts = gun.CostumeParts,
            Grade = gun.Grade,
            Exp = gun.Exp,
            Energy = gun.Energy,
            AuthLevel = gun.AuthLevel,
            IsGetPublicTalentSkillItem = gun.IsGetPublicTalentSkillItem,
            IsAllTalnetUnlock = gun.IsAllTalentUnlock,
            Preset = (GunPresetType)gun.Preset,
            PresetId = gun.PresetId,
            TalentResetNum = gun.TalentResetNum,
            WeaponId = gun.WeaponId,
            Love = new LoungeChatMessage
            {
                KFIAKLNJHMB = gun.LoveLevel,
                ABOJJOJODME = gun.LoveExp,
            },
        };

        proto.PrivateTalentSkillItems.AddRange(gun.PrivateTalentSkillItems);
        proto.PublicTalentSkillItems.AddRange(gun.PublicTalentSkillItems);
        proto.PublicTalentSkillItemsUid.AddRange(gun.PublicTalentSkillItemsUid);

        foreach (KeyValuePair<ulong, uint> entry in gun.TalentTree)
        {
            proto.TalentTree[entry.Key] = entry.Value;
        }

        foreach (KeyValuePair<uint, uint> entry in gun.GunTalentConsume)
        {
            proto.GunTalentConsume[entry.Key] = entry.Value;
        }

        return proto;
    }

    public static GunWeaponLite ToProtoWeapon(this WeaponEntity weapon)
    {
        ArgumentNullException.ThrowIfNull(weapon);

        var proto = new GunWeaponLite
        {
            Id = weapon.Id,
            StcId = weapon.WeaponId,
            Level = (uint)weapon.Level,
            Exp = weapon.CurExp,
            GunId = weapon.GunId,
            BreakTimes = (uint)weapon.BreakTimes,
            LPEEABKNKKE = weapon.Flags,
        };

        if (weapon.EquippedModIds is { Length: > 0 })
        {
            foreach (uint modId in weapon.EquippedModIds)
            {
                proto.WeaponMods.Add(new GunWeaponLite.Types.WeaponMod
                {
                    Id = modId,
                    GunId = weapon.GunId,
                });
            }
        }

        return proto;
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
