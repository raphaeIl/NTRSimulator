using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NTRSimulator.Database.Entities
{
    public class WeaponSkin
    {
        [Key]
        public uint Id { get; set; }

        public uint WeaponSkinId { get; set; }

        [JsonIgnore]
        public virtual Account Account { get; set; } = null!;
    }
}
