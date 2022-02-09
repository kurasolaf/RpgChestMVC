using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Model
{
    public class Rarity
    {
        public int Id { get; set; }
       
        public int BonusMultiplier { get; set; }
        public EnumRarity ItemRarity { get; set; }

        //connections below
        public virtual  ICollection<Item> Items { get; set; }
        // many to one - DONE

        
    }
}
