using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NTRSimulator.Database.Entities
{
    public class Item
    {
        [Key]
        public uint Id { get; set; }

        public uint ItemId { get; set; }

        public int Count { get; set; } = 1;

        [JsonIgnore]
        public virtual Account Account { get; set; } = null!;
    }
}
