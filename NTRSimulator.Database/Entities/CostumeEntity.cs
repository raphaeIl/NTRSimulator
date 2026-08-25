using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace NTRSimulator.Database.Entities
{
    [Table("Costumes")]
    public class CostumeEntity
    {
        [Key]
        public uint Id { get; set; }

        public uint CostumeId { get; set; }

        [JsonIgnore]
        public virtual AccountEntity Account { get; set; } = null!;
    }
}
