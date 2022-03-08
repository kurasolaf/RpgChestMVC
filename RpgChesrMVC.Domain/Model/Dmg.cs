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
        public int FullWeaponTypeRef { get; set; }
        public FullWeaponType FullWeaponType { get; set; }
        // one to one - DONE / context - DONE




    }
}