using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace NTRSimulator.Database.Entities
{
    [Table("Guns")]
    public class GunEntity
    {
        [Key]
        public uint Id { get; set; }

        public uint GunId { get; set; }

        public int Level { get; set; } = 1;

        public uint CostumeId { get; set; }

        public DateTime TimeCreated { get; set; }

        [JsonIgnore]
        public virtual AccountEntity Account { get; set; } = null!;
    }
}
