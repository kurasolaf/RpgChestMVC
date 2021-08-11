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

        public DbSet<Item> Items { get; set; }
        public DbSet<FullArmorType> FullArmorTypes { get; set; }    
        public DbSet<FullWeaponType> FullWeaponTypes { get; set; }
        public DbSet<Rarity> Rarities { get; set; }
        public DbSet<TypeOfWeapon> TypeOfWeapons { get; set; }
        public DbSet<TypeOfArmor> TypeOfArmors { get; set; }
        public DbSet<BonusDmgFromElemental> BonusDmgFromElementals { get; set; }

        public Context(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
