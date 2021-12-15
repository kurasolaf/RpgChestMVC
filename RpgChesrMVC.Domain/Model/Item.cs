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
   **/
    public class Item
    {
        public int Id { get; set; }
        public int ItemLvl { get; set; }
        public int Concentration { get; set; }

        // connections below
        public int RarityId { get; set; }
        public virtual Rarity Rarity { get; set; }
        
        // one to many - DONE
        public FullArmorType FullArmorType { get; set; }
        // one to one - DONE 
        public FullWeaponType FullWeaponType { get; set; }
        // one to one - DONE

    }


}
