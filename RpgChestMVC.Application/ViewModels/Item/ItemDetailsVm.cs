using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Application.ViewModels.Item
{
    class ItemDetailsVm
    {
        public int Id { get; set; }
        public int ItemLvl { get; set; }
        public int Concentration { get; set; }

        public Rarity rarity { get; set; }

        public FullArmorType FullArmorType { get; set; }
      
        public FullWeaponType FullWeaponType { get; set; }


    }
}
