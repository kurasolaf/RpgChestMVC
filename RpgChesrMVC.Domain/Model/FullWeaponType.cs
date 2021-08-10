﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Model
{
    public class FullWeaponType
    {
        public int Id { get; set; }
        //Unique for Weapons//
        
        public int Dmg { get; set; }
        public int CritChance { get; set; }
        public int CritMultiplier { get; set; }
        public int CritBonusDmg { get; set; }
        public int HpDrain { get; set; }
        public int Bonus10ForKpPenetration { get; set; }
        public int BonusSA { get; set; }
        public int BonusDmgVsSummons { get; set; }
        public int ExtraWeaponRange { get; set; }
       
        public int ShieldPointDestroyer { get; set; }
        public int ExtraKpPenetrationForHammer { get; set; }
        // connections below
        public int TypeOfWeaponId { get; set; }
        public int BonusDmgFromElementalId { get; set; }
        public virtual TypeOfWeapon TypeOfWeapon { get; set; }
        public virtual BonusDmgFromElemental BonusDmgFromElemental { get; set; }

        public ICollection<Item> Items { get; set; }

    }
}