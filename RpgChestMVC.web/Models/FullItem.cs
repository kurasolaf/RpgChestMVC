using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgChestMVC.web.Models
{
    public abstract class FullItem
    {
        public int Id { get; set; }
        public int ItemLvl { get; set; }
        public int Dmg { get; set; }
        public int CritChance { get; set; }
        public int CritMultiplier { get; set; }
        public int CritBonusDmg { get; set; }
        public int Kp { get; set; }
        public int Hp { get; set; }
        public int HpDrain { get; set; }
        public int Bonus10ForKpPenetration { get; set; }
        public int BonusSA { get; set; }
        public int BonusWill { get; set; }
        public int BonusDmgVsSummons { get; set; }
        public int ExtraWeaponRange { get; set; }
        public int ExtraSocket { get; set; }
        public int ExtraKpPenetrationForHammer { get; set; }
        public Resistance Resistance { get; set; }
        public Resistance BonusDmgFromElemental { get; set; }
        public int LowerLvlReq { get; set; }
        public int ShieldPointDestroyer { get; set; }
        public int HpPerLvl { get; set; }
        public int Concentration { get; set; }
        public BasicStats BonusBasicStat { get; set; }
        public int ResistanceForAll { get; set; }
        public Abilities BonusAbilitiesPoint { get; set; }
        public int PhysicalAbsorption { get; set; }
        public int MagicalAbsorption { get; set; }
        public int PhysicalReduction { get; set; }
        public int MagicalReduction { get; set; }
        public int ExtraGold { get; set; }
        public int DailyRegenerationFor4Turns { get; set; }
        public string Description { get; set; }
        public SecondaryStat BonuSecondaryStat { get; set; }

    }


}
