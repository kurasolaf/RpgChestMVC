using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Application.ViewModels.Item
{
    public class FullArmorTypeForItemDetailsVm
    {
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
        public TypeOfArmorForItemDetails TypeOfArmor { get; set; } 
        public virtual ICollection<ResistanceForItemDetails> Resistances { get; set; } 


    }
}
