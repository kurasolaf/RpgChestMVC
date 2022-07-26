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
        public DbSet<FullArmor> FullArmors { get; set; }    
        public DbSet<FullWeapon> FullWeapons { get; set; }


        public DbSet<PlayerBackpack> PlayerBackpacks { get; set; }

        public DbSet<Resistance> Resistances { get; set; }
       
        public DbSet<TypeOfWeapon> TypeOfWeapons { get; set; }
        public DbSet<TypeOfArmor> TypeOfArmors { get; set; }

        public DbSet<Dmg> Dmgs { get; set; }

        public DbSet<BonusDmg> BonusDmgs { get; set; }

        public DbSet<BasicStat> BasicStats { get; set; }

        public DbSet<SecondaryStat> SecondaryStats { get; set; }

        public Context(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // connection one to one 



            builder.Entity<Item>()
                .HasOne(a => a.FullWeaponType).WithOne(b => b.Item)
                .HasForeignKey<FullWeapon>(e => e.ItemRef);



            builder.Entity<FullArmor>()
                .HasOne(a => a.TypeOfArmor).WithOne(b => b.FullArmorType)
                .HasForeignKey<TypeOfArmor>(e => e.FullArmorTypeRef);




            /* connection one to many
            ADD: Many BasicStats to one Item
            ADD: Many SecondaryStats to one Item
            */

            //builder.Entity<Item>()
            //    .HasOne<Rarity>(a => a.Rarity).WithMany(b => b.Items)
            //    .HasForeignKey(c => c.RarityId);

            builder.Entity<Resistance>()
                .HasOne<FullArmor>(a => a.FullArmor).WithMany(b => b.Resistances)
                .HasForeignKey(e => e.FullArmorId);


           
           

            //builder.Entity<BonusDmgFromElemental>()
            //    .HasOne<FullWeapon>(a => a.FullWeapon).WithMany(b => b.BonusDmgFromElementals)
            //    .HasForeignKey(e => e.FullWeaponId);

            //builder.Entity<BonusDmg>()
            //    .HasOne<FullWeapon>(a => a.FullWeapon).WithMany(b => b.BonusDmgs)
            //    .HasForeignKey(e => e.FullWeaponId);



            // connection many to one

            //builder.Entity<BasicStat>()
            //    .HasOne<Item>(c => c.Item)
            //    .WithMany(o => o.BasicStats)
            //    .HasForeignKey(c => c.ItemId);

            //builder.Entity<SecondaryStat>()
            //    .HasOne<Item>(c => c.item)
            //    .WithMany(o => o.SecondaryStats)
            //    .HasForeignKey(c => c.ItemId);


        }

    }
}
