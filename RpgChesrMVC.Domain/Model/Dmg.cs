using System.Collections.Generic;

namespace RpgChestMVC.Domain.Model
{
    public class Dmg
    {
        /* how it works
         * DmgMultiplier * DmgDice
         * 
         * (DmgMultiplier)K(DmgDice)
         * 
         * example "5K8"
         */

        public int Id { get; set; }
        public int DmgMultiplier { get; set; }

        public int DmgDice { get; set; }

        //connections below
        public virtual ICollection<FullWeaponType> FullWeaponTypes { get; set; }
        // many to one - 




    }
}