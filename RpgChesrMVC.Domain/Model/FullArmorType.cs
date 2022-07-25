using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Model
{
    public class FullArmorType : Item
    {
        //Unique for Armors//
        public int Id { get; set; }
        public int Kp { get; set; } // Range 1-100
        public int Hp { get; set; } // Range 1-100, max player lvl
        public int ResistanceForAll { get; set; } // Range 5-50 - per 5%
        public int PhysicalAbsorption { get; set; } // Range 1-100
        public int MagicalAbsorption { get; set; } // Range 1-100
        public int PhysicalReduction { get; set; } // Range 1-20
        public int MagicalReduction { get; set; } // Range 1-20
        public int HpPerLvl { get; set; } // Range 1-10
        public int DailyRegenerationFor4Turns { get; set; } // Range 1-50


        public int TypeOfArmorId { get; set; }
        public virtual TypeOfArmor TypeOfArmor { get; set; }

        public virtual ICollection<Resistance> Resistances { get; set; } //// Range 5-50 - per 5%
        //connections below



    }
}
