using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Model
{
    public enum EnumRarity
    {
        Common = 1,          //Pospolity +1,                  przedział;    1201-2000
        Uncommon = 2,        //Niepospolity  +2,              przedział;    701-1200
        Rare = 3,            //Rzadki +3,                     przedział;    451-700
        Epic = 4,            //Epicki +4,                     przedział;    301-450
        EliteEpic =5,        //Elitarny Epicki +6             przedział;    211-300
        Legendary = 6,       //Legendarny +7,                 przedział;    152-210
        EliteLegendary =7,   //Elitarny Legendarny +8         przedział;    92-152
        Artifact = 8,        //Artefakt +9,                   przedział;    61-91
        EliteArtifact = 9,   //Elitarny Artefakt +10          przedział;    39-60
        Titanic = 10,        //Tytaniczny +12,                przedział;    23-38
        EliteTitanic = 11,   //Elitarny Tytaniczny +14        przedział;    11-22
        Global = 12,         //Globalny +16,                  przedział;    4-10
        EliteGlobal = 13,    //Elitarny Globalny +18          przedział;    2-4
        Godly =14,           //Boski +20                      przedział;    1-1



        // szansa 1 na 2000 = 0,05%


    }

}
