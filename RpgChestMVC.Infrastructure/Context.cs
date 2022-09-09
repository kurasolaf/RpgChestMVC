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

        
      
        public DbSet<FullArmor> FullArmors { get; set; }    
       
        //public DbSet<TypeOfArmor> TypeOfArmors { get; set; }

        public DbSet<PlayerBackpack> PlayerBackpacks { get; set; }

        //public DbSet<Resistance> Resistances { get; set; }


         //public DbSet<BonusDmgFromElemental> BonusDmgFromElementals { get; set; }
        //public DbSet<TypeOfWeapon> TypeOfWeapons { get; set; }
        
 //public DbSet<FullWeapon> FullWeapons { get; set; }
        //public DbSet<Dmg> Dmgs { get; set; }

        //public DbSet<BonusDmg> BonusDmgs { get; set; }

        //public DbSet<BasicStat> BasicStats { get; set; }

        //public DbSet<SecondaryStat> SecondaryStats { get; set; }

        public Context(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            // below connection one to many

            var fullArmors = builder.Entity<FullArmor>();
                fullArmors.HasKey(k => k.Id);
                fullArmors.HasOne<PlayerBackpack>(m => m.PlayerBackpack).WithMany(m => m.FullArmors)
                .HasForeignKey(c => c.PlayerBackpackId);

            //var fulArmors = builder.Entity<FullArmor>();    
            //    fulArmors.HasKey(k => k.Id);
            //    fullArmors.HasOne<TypeOfArmor>(m => m.TypeOfArmor).WithMany(m => m.FullArmors)
            //    .HasForeignKey(c =>c.TypeOfArmorId);

            // below connection one to many

            var resistances = builder.Entity<Resistance>();
                resistances.HasKey(k => k.Id);
                resistances.HasOne<FullArmor>(m => m.FullArmor).WithMany(m => m.Resistances)
                .HasForeignKey(c => c.FullArmorId);




            //builder.Entity<Item>()
            //    .HasOne<Rarity>(a => a.Rarity).WithMany(b => b.Items)
            //    .HasForeignKey(c => c.RarityId);
           

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
