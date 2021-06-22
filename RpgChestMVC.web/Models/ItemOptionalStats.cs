using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgChestMVC.web.Models
{
    public abstract class ItemOptionalStats : IItemBasicStats
    {
        public string ItemName { get; set; }
        public int ExtraSocket { get; set; }
        public int LowerLvlReq { get; set; }
        public int BonusWill { get; set; }
        public BasicStats BonusBasicStat { get; set; }
        public Abilities BonusAbilitiesPoint { get; set; }
        public int ExtraGold { get; set; }
        public string Description { get; set; }
        public SecondaryStat BonuSecondaryStat { get; set; }
        // below from IItemBasicStats //
        public int Id { get; set; }
        public int ItemLvl { get; set; }
        public StructRarity Rarity { get; set; }
        public int Concetration { get; set; }

    }
}
