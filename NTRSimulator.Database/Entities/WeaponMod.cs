using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NTRSimulator.Database.Entities
{
    public class WeaponMod
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
        public virtual Account Account { get; set; } = null!;
    }
}
