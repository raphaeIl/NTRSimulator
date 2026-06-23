using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NTRSimulator.Database.Entities
{
    public class AvgDuo
    {
        [Key]
        public uint Id { get; set; }

        public uint[] AvgDuoMainStageIds { get; set; } = [];

        public uint[] AvgDuoSubStageIds { get; set; } = [];

        [JsonIgnore]
        public virtual Account Account { get; set; } = null!;
    }
}
