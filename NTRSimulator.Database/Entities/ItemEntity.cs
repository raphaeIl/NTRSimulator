using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace NTRSimulator.Database.Entities
{
    [Table("Items")]
    public class ItemEntity
    {
        [Key]
        public uint Id { get; set; }

        public uint ItemId { get; set; }

        public int Type { get; set; }

        public int Count { get; set; } = 1;

        [JsonIgnore]
        public virtual AccountEntity Account { get; set; } = null!;
    }
}
