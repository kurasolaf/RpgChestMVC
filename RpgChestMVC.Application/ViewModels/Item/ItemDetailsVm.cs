﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Application.ViewModels.Item
{
    public class ItemDetailsVm
    {

        

        public int Id { get; set; }
        public int ItemLvl { get; set; }
        public int Concentration { get; set; }
        public int NumberOfSockets { get; set; }

        public RarityForItemVm Rarity { get; set; }

        public FullArmorTypeForItemDetailsVm FullArmorType { get; set; }


        public FullWeaponTypeForItemDetailsVm FullWeaponType { get; set; }
      
        
        

    }
}
