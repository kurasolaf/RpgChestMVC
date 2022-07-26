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
        public int DmgMultiplier { get; set; }  //Range 1-100 Max ItemLvl

        public int DmgDice { get; set; } //Range 4,6,8,10,12,20

        //connections below
        public int FullWeaponRef { get; set; }
        public FullWeapon FullWeapon { get; set; }
        // one to one - DONE / context - DONE




    }
}