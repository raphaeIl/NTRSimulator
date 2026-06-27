using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace NTRSimulator.Database.Entities
{
    [Table("WeaponModSkins")]
    public class WeaponModSkinEntity
    {
        [Key]
        public uint Id { get; set; }

        public uint WeaponModSkinId { get; set; }

        [JsonIgnore]
        public virtual AccountEntity Account { get; set; } = null!;
    }
}
