using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NTRSimulator.Database.Entities
{
    public class Account
    {
        [Key]
        public uint Uid { get; set; }

        public string Email { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public bool IsGuest { get; set; }

        public DateTime TimeCreated { get; set; }

        public DateTime TimeLastLogin { get; set; }

        [JsonIgnore]
        public virtual ICollection<Gun> Guns { get; set; } = new List<Gun>();

        [JsonIgnore]
        public virtual ICollection<Costume> Costumes { get; set; } = new List<Costume>();

        [JsonIgnore]
        public virtual ICollection<Weapon> Weapons { get; set; } = new List<Weapon>();

        [JsonIgnore]
        public virtual ICollection<Item> Items { get; set; } = new List<Item>();

        [JsonIgnore]
        public virtual ICollection<WeaponMod> WeaponMods { get; set; } = new List<WeaponMod>();

        [JsonIgnore]
        public virtual ICollection<WeaponSkin> WeaponSkins { get; set; } = new List<WeaponSkin>();

        [JsonIgnore]
        public virtual ICollection<WeaponModSkin> WeaponModSkins { get; set; } = new List<WeaponModSkin>();

        [JsonIgnore]
        public virtual AvgDuo? AvgDuo { get; set; }
    }
}
