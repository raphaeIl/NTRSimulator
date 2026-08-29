using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace NTRSimulator.Database.Entities
{
    [Table("Guns")]
    public class GunEntity
    {
        [Key]
        public uint Id { get; set; }

        public uint GunId { get; set; }

        public int Level { get; set; } = 1;

        public uint Exp { get; set; } = 120;

        public uint Energy { get; set; } = 120;

        public uint GunClass { get; set; } = 1;

        public uint CostumeId { get; set; }

        public uint CostumeParts { get; set; }

        public uint Grade { get; set; }

        public uint AuthLevel { get; set; }

        public uint WeaponId { get; set; }

        public bool IsGetPublicTalentSkillItem { get; set; }

        public bool IsAllTalentUnlock { get; set; }

        public uint Preset { get; set; }

        public uint PresetId { get; set; }

        public uint TalentResetNum { get; set; }

        public uint[] PrivateTalentSkillItems { get; set; } = [0, 0, 0];

        public uint[] PublicTalentSkillItems { get; set; } = [0, 0, 0];

        public ulong[] PublicTalentSkillItemsUid { get; set; } = [0, 0, 0];

        public Dictionary<ulong, uint> TalentTree { get; set; } = [];

        public Dictionary<uint, uint> GunTalentConsume { get; set; } = [];

        public uint LoveLevel { get; set; } = 1;

        public long LoveExp { get; set; }

        public DateTime TimeCreated { get; set; }

        [JsonIgnore]
        public virtual AccountEntity Account { get; set; } = null!;
    }
}
