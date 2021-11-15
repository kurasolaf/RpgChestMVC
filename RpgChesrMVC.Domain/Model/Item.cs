using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Model
{
   /**
   Add database connection between classes, Add context, Migration
   !ADD CONNECTION FROM ARMOR & WEAPONS to ITEM
   **/
    public class Item
    {
        public int Id { get; set; }
        public int ItemLvl { get; set; }
        public int Concentration { get; set; }
        
        //relations below ?
        public int RarityId { get; set; }
        public virtual Rarity Rarity { get; set; }
        //one to many?
        public virtual FullArmorType FullArmorType { get; set; }
        public virtual FullWeaponType FullWeaponType { get; set; }


    }


}
