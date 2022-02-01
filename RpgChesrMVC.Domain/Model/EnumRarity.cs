using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Model
{
    public enum EnumRarity
    {
        Common = 1,       //Pospolity +1, szansa: 250 na 500        50,0%  przedział;    1-250
        Uncommon = 2,    //Niepospolity  +2,  szansa: 125 na 500    25,0%  przedział; 251 - 376
        Rare = 3,       //Rzadki +3, szansa: 75 na 500              15,0%  przedział; 377 - 451
        Epic = 4,      //Epicki +4, szansa: 30 na 500                6,0%  przedział; 451 - 480
        Legendary = 5, //Legendarny +5, szansa: 11 na 500            2,2%  przedział; 481 - 491
        Artifact = 6, //Artefakt +7, szansa: 6 na 500                1,2%  przedział; 492 - 497
        Titanic = 7, //Tytaniczny +10, szansa: 2 na 500              0,4%  przedział; 498 - 499
        Global = 8, //Globalny +15, szansa: 1 na 500                 0,2%  przedział; 500 - 500

                    // szansa 1 na 500 = 0,20%


    }

}
