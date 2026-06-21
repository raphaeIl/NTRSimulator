using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NTRSimulator.Database.Entities
{
    public class WeaponModSkin
    {
        [Key]
        public uint Id { get; set; }

        public uint WeaponModSkinId { get; set; }

        [JsonIgnore]
        public virtual Account Account { get; set; } = null!;
    }
}
