using System.Collections.Generic;

namespace RpgChestMVC.Application.ViewModels.Item
{
    public class FullWeaponTypeForItemDetailsVm
    {
        public int Id { get; set; }
        public int Dmg { get; set; }
        public int CritChance { get; set; }
        public int CritMultiplier { get; set; }
        public int CritBonusDmg { get; set; }
        public int HpDrain { get; set; }
        public int Bonus10ForKpPenetration { get; set; }
        public int BonusSA { get; set; }
        public int BonusDmgVsSummons { get; set; }
        public int ExtraWeaponRange { get; set; }
        public int ShieldPointDestroyer { get; set; }
        public int ExtraKpPenetrationForHammer { get; set; }

        public TypeOfWeaponForItemDetails TypeOfWeapon { get; set; }
        
        public virtual ICollection<BonusDmgFromElementalForItemDetails> BonusDmgFromElementals { get; set; }

    }
}