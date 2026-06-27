using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace NTRSimulator.Database.Entities
{
    [Table("Accounts")]
    public class AccountEntity
    {
        [Key]
        public uint Uid { get; set; }

        public string Email { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public bool IsGuest { get; set; }

        public DateTime TimeCreated { get; set; }

        public DateTime TimeLastLogin { get; set; }

        [JsonIgnore]
        public virtual ICollection<GunEntity> Guns { get; set; } = new List<GunEntity>();

        [JsonIgnore]
        public virtual ICollection<CostumeEntity> Costumes { get; set; } = new List<CostumeEntity>();

        [JsonIgnore]
        public virtual ICollection<WeaponEntity> Weapons { get; set; } = new List<WeaponEntity>();

        [JsonIgnore]
        public virtual ICollection<ItemEntity> Items { get; set; } = new List<ItemEntity>();

        [JsonIgnore]
        public virtual ICollection<WeaponModEntity> WeaponMods { get; set; } = new List<WeaponModEntity>();

        [JsonIgnore]
        public virtual ICollection<WeaponSkinEntity> WeaponSkins { get; set; } = new List<WeaponSkinEntity>();

        [JsonIgnore]
        public virtual ICollection<WeaponModSkinEntity> WeaponModSkins { get; set; } = new List<WeaponModSkinEntity>();

        [JsonIgnore]
        public virtual AvgDuoEntity? AvgDuo { get; set; }
    }
}
