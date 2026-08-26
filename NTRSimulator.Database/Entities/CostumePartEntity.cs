using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace NTRSimulator.Database.Entities
{
    [Table("CostumeParts")]
    public class CostumePartEntity
    {
        [Key]
        public uint Id { get; set; }

        public uint CostumePartId { get; set; }

        [JsonIgnore]
        public virtual AccountEntity Account { get; set; } = null!;
    }
}
