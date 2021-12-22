using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Model
{
    public class FullArmorType
    {
        //Unique for Armors//
        public int Id { get; set; }
        public int Kp { get; set; }
        public int Hp { get; set; }
        public int ResistanceForAll { get; set; }
        public int PhysicalAbsorption { get; set; }
        public int MagicalAbsorption { get; set; }
        public int PhysicalReduction { get; set; }
        public int MagicalReduction { get; set; }
        public int HpPerLvl { get; set; }
        public int DailyRegenerationFor4Turns { get; set; }
        //connections below
        public int ItemRef { get; set; }
        public Item Item { get; set; }
        //// One to One - DONE / context - DONE
        public TypeOfArmor TypeOfArmor { get; set; }
        // One to One - DONE / context - DONE

        public virtual ICollection<Resistance> Resistances { get; set; }
        // One to Many - DONE / context - DONE

    }
}
