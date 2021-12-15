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
            // connection one to many
        }

    }
}
