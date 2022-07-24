using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Model
{

    public class Item
    {

        public int Id { get; set; }
        public int ItemLvl { get; set; }
        public int Concentration { get; set; } 
        public int NumberOfSockets { get; set; }
        public bool IsActive { get; set; }
        public string Rarity{ get; set; }

        public bool IsArmorType { get; set; }
        public string ArmorType{ get; set; }

        public bool IsWeaponType { get; set; }
        public string WeaponType { get; set; }

        // connections below

        public virtual ICollection<BasicStat> BasicStats { get; set; }
        // one to many - DONE / context - DONE

        public virtual ICollection<SecondaryStat> SecondaryStats { get; set; }
        // one to many - DONE / context - DONE
















    }


}
