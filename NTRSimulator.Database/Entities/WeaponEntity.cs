using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace NTRSimulator.Database.Entities
{
    [Table("Weapons")]
    public class WeaponEntity
    {
        [Key]
        public uint Id { get; set; }

        public uint WeaponId { get; set; }

        public int Level { get; set; } = 1;

        public uint CurExp { get; set; }

        public int BreakTimes { get; set; } = 1;

        public uint GunId { get; set; }

        public DateTime TimeCreated { get; set; }

        [JsonIgnore]
        public virtual AccountEntity Account { get; set; } = null!;
    }
}
