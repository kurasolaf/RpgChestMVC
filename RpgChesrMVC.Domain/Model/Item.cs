using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Model
{
   /**
   GLOBAL TO DO: 
    1- 
    2- add models
        2.1- Spells
      TO DO LISTS to COMPLETE in: Item Repository, 
   **/
    public class Item
    {

        //to do: add secondary stats, add connections
        //to do: add basic stats, add connections
        public int Id { get; set; }
        public int ItemLvl { get; set; }
        public int Concentration { get; set; }
        public int NumberOfSockets { get; set; }

        // connections below
        public int RarityId { get; set; }
        public virtual Rarity Rarity { get; set; }
        // one to many - DONE / context - DONE


        public FullArmorType FullArmorType { get; set; }
        // one to one - DONE /context - DONE
        public FullWeaponType FullWeaponType { get; set; }
        // one to one - DONE / context - DONE

    }


}
