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

        public int BonusMultiplier;
        public EnumRarity ItemRarity;

        //connections below
        public int ItemRef { get; set; }
        public Item Item { get; set; }
        // one to one - DONE

        
    }
}
