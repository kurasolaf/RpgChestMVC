using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Application.Services
{
    public class RollService
    {
        //TO DO:
        /* Make methods 
         * *  Rolling Global
         * *  Rolling BonusDmgFromElemental + value
         * *  Rolling Abilities + value
         * *  Rolling BasicStats + value
         * *  Rolling Resistance + value
         * *  Rolling SecondaryStat + value
         * *  Rolling Rarity
         * *  Rolling ArmorType
         * *  Rolling WeaponType
         * *  Rolling Concentration (based on armor Type) (0 for weapon)
         * *  Rolling ItemSocets
         * *  Rolling Kp (based on armor Type) (0 for weapon)
         * *  Rolling Hp 
         * *  Rolling ResistanceForAll 
         * *  Rolling PhysicalAbsorption 
         * *  Rolling MagicalAbsorption 
         * *  Rolling PhysicalReduction 
         * *  Rolling MagicalReduction  
         * *  Rolling HpPerLvl 
         * *  Rolling DailyRegenerationFor4Turns 
         * *  Rolling Dmg (based on weapon Type) (0 for armor)
         * *  Rolling CritChance (based on weapon Type) (0 for armor)
         * *  Rolling CritMultiplier (based on weapon Type) (0 for armor)
         * *  Rolling CritBonusDmg (based on weapon Type) (0 for armor)
         * *  Rolling HpDrain (based on weapon Type) (0 for armor)
         * *  Rolling Bonus10ForKpPenetration (based on weapon Type) (0 for armor)
         * *  Rolling BonusSA (based on weapon Type) (0 for armor)
         * *  Rolling BonusDmgVsSummons (based on weapon Type) (0 for armor)
         * *  Rolling ExtraWeaponRange (based on weapon Type) (0 for armor) (0 for close combat weapon)
         * *  Rolling ShieldPointDestroyer (based on weapon Type) (0 for armor)
         * *  Rolling ExtraKpPenetrationForHammer (based on weapon Type) (0 for armor)
         * */






        public int Roll8()
        {                     
            Random rnd = new Random();

            int RolledNumber8 = rnd.Next(1, 9);     

            return RolledNumber8;
        }


        public int Roll10()
        {
            Random rnd = new Random();

            int RolledNumber10 = rnd.Next(1, 11);

            return RolledNumber10;
        }

        public int Roll21()
        {
            Random rnd = new Random();

            int RolledNumber21 = rnd.Next(1, 22);

            return RolledNumber21;
        }

        public int Roll100()
        {
            Random rnd = new Random();

            int RolledNumber100 = rnd.Next(1, 101);

            return RolledNumber100;
        }

        public int Roll500()
        {
            Random rnd = new Random();

            int RolledNumber500 = rnd.Next(1, 501);

            return RolledNumber500;
        }




        




    }
}
