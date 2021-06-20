using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgChestMVC.web.Models
{
    interface IFullArmorItem : IItemStats
    {
        public EnumArmorType ArmorType { get; set; }
        public int Kp { get; set; }
        public int Hp { get; set; }
        public Resistance Resistance { get; set; }
        public int ResistanceForAll { get; set; }
        public int PhysicalAbsorption { get; set; }
        public int MagicalAbsorption { get; set; }
        public int PhysicalReduction { get; set; }
        public int MagicalReduction { get; set; }
        public int HpPerLvl { get; set; }
        public int DailyRegenerationFor4Turns { get; set; }
    }
}
