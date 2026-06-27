using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace NTRSimulator.Database.Entities
{
    [Table("WeaponMods")]
    public class WeaponModEntity
    {
        [Key]
        public uint Id { get; set; }

        public uint WeaponModId { get; set; }

        public ulong Uid { get; set; }

        public uint Level { get; set; }

        public uint Field5 { get; set; }

        public uint Field6 { get; set; }

        public ulong Field7 { get; set; }

        [JsonIgnore]
        public virtual AccountEntity Account { get; set; } = null!;
    }
}
