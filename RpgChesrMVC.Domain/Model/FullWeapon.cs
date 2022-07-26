using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Model
{
    public class FullWeapon : Item
    {
        public int Id { get; set; }
                
        public int CritChance { get; set; }    //Range 16-20
        public int CritMultiplier { get; set; } //Range 1-4
        public int CritBonusDmg { get; set; }  // Range 1-50 - amount of dice's, max player LVL/2
        public int HpDrain { get; set; }       // Range 1-100
        public int Bonus10ForKpPenetration { get; set; } //Range 10-20
        public int BonusSA { get; set; }    // Range 1-20
        public int BonusDmgVsSummons { get; set; } // Range 1-50 - amount of dice's, max player LVL/2
        public int ExtraWeaponRange { get; set; } // Range 5-100 - per 5m
        public int ShieldPointDestroyer { get; set; } // Range 1-10 - multiplier for weapon dmg
        public int ExtraKpPenetrationForHammer { get; set; } //Range 1-10


        public int TypeOfWeaponId  { get; set; }
        public virtual TypeOfWeapon TypeOfWeapon { get; set; }

        // connections below
        public virtual ICollection<BonusDmg> BonusDmgs { get; set; }
       
       
        
        
        public Dmg Dmg { get; set; } 
       


        public virtual ICollection<BonusDmgFromElemental> BonusDmgFromElementals { get; set; } // Range 5-50 - per 5%

    }
}
