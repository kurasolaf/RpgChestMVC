using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Model
{
    public class BasicRarity
    {
        int Id;
        public int BonusMultiplier;
        public EnumRarity ItemRarity;

        public int RarityRef { get; set; }
        public Rarity Rarity { get; set; }
        // one to one - DONE
    }
}
