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

        //to do: add secondary stats, add connections, update database, 
        //to do: add basic stats, add connections, update database,
        public int Id { get; set; }
        public int ItemLvl { get; set; }
        public int Concentration { get; set; }
        public int NumberOfSockets { get; set; }
        public bool IsActive { get; set; }


        // connections below


        // public BasicStat


        // public SecondaryStat


        public int RarityId { get; set; }
        public virtual Rarity Rarity { get; set; }
        // one to many - DONE / context - DONE


        public FullArmorType FullArmorType { get; set; }
        // one to one - DONE /context - DONE
        public FullWeaponType FullWeaponType { get; set; }
        // one to one - DONE / context - DONE

    }


}
