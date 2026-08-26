using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace NTRSimulator.Database.Entities
{
    [Table("Backgrounds")]
    public class BackgroundEntity
    {
        [Key]
        public uint Id { get; set; }

        public uint BackgroundId { get; set; }

        [JsonIgnore]
        public virtual AccountEntity Account { get; set; } = null!;
    }
}
