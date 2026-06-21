using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NTRSimulator.Database.Entities
{
    public class Gun
    {
        [Key]
        public uint Id { get; set; }

        public uint GunId { get; set; }

        public int Level { get; set; } = 1;
        
        public uint CostumeId { get; set; }
        
        public DateTime TimeCreated { get; set; }

        [JsonIgnore]
        public virtual Account Account { get; set; } = null!;
    }
}
