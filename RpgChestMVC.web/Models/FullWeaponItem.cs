﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgChestMVC.web.Models
{
   





    public class FullWeaponItem : ItemOptionalStats
    {


        //Unique for Weapons//
        public EnumWeaponType WeaponType { get; set; }
        public int Dmg { get; set; }
        public int CritChance { get; set; }
        public int CritMultiplier { get; set; }
        public int CritBonusDmg { get; set; }
        public int HpDrain { get; set; }
        public int Bonus10ForKpPenetration { get; set; }
        public int BonusSA { get; set; }
        public int BonusDmgVsSummons { get; set; }
        public int ExtraWeaponRange { get; set; }
        public Resistance BonusDmgFromElemental { get; set; }
        public int ShieldPointDestroyer { get; set; }
        public int ExtraKpPenetrationForHammer { get; set; }


    }
}