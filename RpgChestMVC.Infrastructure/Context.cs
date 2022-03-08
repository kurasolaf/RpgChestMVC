using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RpgChestMVC.Domain.Model;

namespace RpgChestMVC.Infrastructure
{
    public class Context : IdentityDbContext
    {

        
        public DbSet<BonusDmgFromElemental> BonusDmgFromElementals { get; set; }
        public DbSet<FullArmorType> FullArmorTypes { get; set; }    
        public DbSet<FullWeaponType> FullWeaponTypes { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Rarity> Rarities { get; set; }
        public DbSet<Resistance> Resistances { get; set; }
       
        public DbSet<TypeOfWeapon> TypeOfWeapons { get; set; }
        public DbSet<TypeOfArmor> TypeOfArmors { get; set; }

        public DbSet<Dmg> Dmgs { get; set; }

        public DbSet<BonusDmg> BonusDmgs { get; set; }
        

        public Context(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // connection one to one 

            builder.Entity<Item>()
                .HasOne(a => a.FullArmorType).WithOne(b => b.Item)
                .HasForeignKey<FullArmorType>(e => e.ItemRef);

            builder.Entity<Item>()
                .HasOne(a => a.FullWeaponType).WithOne(b => b.Item)
                .HasForeignKey<FullWeaponType>(e => e.ItemRef);

            builder.Entity<FullArmorType>()
                .HasOne(a => a.TypeOfArmor).WithOne(b => b.FullArmorType)
                .HasForeignKey<TypeOfArmor>(e => e.FullArmorTypeRef);

            builder.Entity<FullWeaponType>()
                .HasOne(a => a.TypeOfWeapon).WithOne(b => b.FullWeaponType)
                .HasForeignKey<TypeOfWeapon>(e => e.FullWeaponTypesRef);

            builder.Entity<FullWeaponType>()
                .HasOne(a => a.Dmg).WithOne(b => b.FullWeaponType)
                .HasForeignKey<Dmg>(c => c.FullWeaponTypeRef);
            

            /* connection one to many
            ADD: one Item to many Rarity
            */

            builder.Entity<Item>()
                .HasOne<Rarity>(a => a.Rarity).WithMany(b => b.Items)
                .HasForeignKey(c => c.RarityId);

            builder.Entity<Resistance>()
                .HasOne<FullArmorType>(a => a.FullArmorType).WithMany(b => b.Resistances)
                .HasForeignKey(e => e.FullArmorTypeId);

            builder.Entity<BonusDmgFromElemental>()
                .HasOne<FullWeaponType>(a => a.FullWeaponType).WithMany(b => b.BonusDmgFromElementals)
                .HasForeignKey(e => e.FullWeaponTypeId);

            builder.Entity<BonusDmg>()
                .HasOne<FullWeaponType>(a => a.FullWeaponType).WithMany(b => b.BonusDmgs)
                .HasForeignKey(e => e.FullWeaponTypeId);



        }

    }
}
