using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Model
{

    public class FullArmor : IItem
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

        public int PlayerBackpackId { get; set; } 
        public virtual PlayerBackpack? PlayerBackpack { get; set; }
        //connection many to one/ context -done


        //public int TypeOfArmorId { get; set; }
        //public virtual TypeOfArmor TypeOfArmor { get; set; }
        ////Connection many to one/context -done

        public string ArmorType { get; set; }

        public virtual ICollection<Resistance> Resistances { get; set; } //// Range 5-50 - per 5%
        //connection one to many/context -done

        public int ItemLvl { get; set; }  
        public int Concentration { get; set; } 
        public int NumberOfSockets { get; set; } 
        public bool IsActive { get; set; }
        public string Rarity { get; set; }
       
    }
}
