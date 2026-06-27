using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace NTRSimulator.Database.Entities
{
    [Table("AvgDuos")]
    public class AvgDuoEntity
    {
        [Key]
        public uint Id { get; set; }

        public uint[] AvgDuoMainStageIds { get; set; } = [];

        public uint[] AvgDuoSubStageIds { get; set; } = [];

        [JsonIgnore]
        public virtual AccountEntity Account { get; set; } = null!;
    }
}
