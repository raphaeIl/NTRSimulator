using Microsoft.EntityFrameworkCore;
using NTRSimulator.Database.Entities;

namespace NTRSimulator.Database.Core
{
    public class NTRSimulatorDbContext : DbContext
    {
        public NTRSimulatorDbContext(DbContextOptions<NTRSimulatorDbContext> options) : base(options)
        {
        }

        public DbSet<Gun> Guns => Set<Gun>();

        public DbSet<Costume> Costumes => Set<Costume>();

        public DbSet<Account> Accounts => Set<Account>();

        public DbSet<Weapon> Weapons => Set<Weapon>();

        public DbSet<Item> Items => Set<Item>();

        public DbSet<WeaponMod> WeaponMods => Set<WeaponMod>();

        public DbSet<WeaponSkin> WeaponSkins => Set<WeaponSkin>();

        public DbSet<WeaponModSkin> WeaponModSkins => Set<WeaponModSkin>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gun>(e =>
            {
                e.HasIndex(g => g.GunId);
                e.Property(g => g.Id).ValueGeneratedOnAdd();
                e.Property(g => g.Level).HasDefaultValue(1);
            });

            modelBuilder.Entity<Costume>(e =>
            {
                e.HasIndex(c => c.CostumeId);
                e.Property(c => c.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Weapon>(e =>
            {
                e.HasIndex(w => w.WeaponId);
                e.HasIndex(w => w.GunId);
                e.Property(w => w.Id).ValueGeneratedOnAdd();
                e.Property(w => w.Level).HasDefaultValue(1);
                e.Property(w => w.BreakTimes).HasDefaultValue(1);
            });

            modelBuilder.Entity<Item>(e =>
            {
                e.HasIndex(i => i.ItemId);
                e.HasIndex("AccountUid", "ItemId").IsUnique();
                e.Property(i => i.Id).ValueGeneratedOnAdd();
                e.Property(i => i.Count).HasDefaultValue(1);
            });

            modelBuilder.Entity<WeaponMod>(e =>
            {
                e.HasIndex(m => m.WeaponModId);
                e.HasIndex(m => m.Uid).IsUnique();
                e.HasIndex("AccountUid", "WeaponModId").IsUnique();
                e.Property(m => m.Id).ValueGeneratedOnAdd();
                e.Property(m => m.Level).HasDefaultValue(0u);
                e.Property(m => m.Field5).HasDefaultValue(0u);
                e.Property(m => m.Field6).HasDefaultValue(0u);
                e.Property(m => m.Field7).HasDefaultValue(0ul);
            });

            modelBuilder.Entity<WeaponSkin>(e =>
            {
                e.HasIndex(s => s.WeaponSkinId);
                e.HasIndex("AccountUid", "WeaponSkinId").IsUnique();
                e.Property(s => s.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WeaponModSkin>(e =>
            {
                e.HasIndex(s => s.WeaponModSkinId);
                e.HasIndex("AccountUid", "WeaponModSkinId").IsUnique();
                e.Property(s => s.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Account>(e =>
            {
                e.HasKey(a => a.Uid);
                e.HasIndex(a => a.Email).IsUnique();
                e.Property(a => a.Uid).ValueGeneratedOnAdd();
                e.Property(a => a.Email).IsRequired();
                e.Property(a => a.PasswordHash).IsRequired();

                e.HasMany(a => a.Guns)
                 .WithOne(g => g.Account)
                 .IsRequired();

                e.HasMany(a => a.Costumes)
                 .WithOne(c => c.Account)
                 .IsRequired();

                e.HasMany(a => a.Weapons)
                 .WithOne(w => w.Account)
                 .IsRequired();

                e.HasMany(a => a.Items)
                 .WithOne(i => i.Account)
                 .IsRequired();

                e.HasMany(a => a.WeaponMods)
                 .WithOne(m => m.Account)
                 .IsRequired();

                e.HasMany(a => a.WeaponSkins)
                 .WithOne(s => s.Account)
                 .IsRequired();

                e.HasMany(a => a.WeaponModSkins)
                 .WithOne(s => s.Account)
                 .IsRequired();
            });
        }
    }
}
