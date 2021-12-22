using System;
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
        public int ItemRef { get; set; }
        public Item Item { get; set; }
        //// one to one - DONE / context - DONE
        
        public TypeOfWeapon TypeOfWeapon { get; set; }
        // one to one - DONE / context - DONE
        public virtual ICollection<BonusDmgFromElemental> BonusDmgFromElementals { get; set; }
        // one to MANY - DONE / context - DONE


    }
}
