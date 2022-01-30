using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Application.ViewModels.Item
{
    public class ItemForListVm
    {

        // ID + to co chce wyświetlić w liście ogólnej
        
        public int Id { get; set; }
        public int ItemLvl { get; set; }

        public RarityForItemVm Rarity { get; set; }



        // jedno z poniższych w przypadku nulla ma się nie wyświetlać.
        public FullArmorTypeForItemListVm ArmorType { get; set; }

        public FullWeaponTypeForItemListVm WeaponType { get; set; }


        
     
    }
}
