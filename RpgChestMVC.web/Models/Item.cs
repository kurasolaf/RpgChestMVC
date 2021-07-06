using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgChestMVC.web.Models
{
    public class Item : IItemBasicStats

    {

        public int Id { get; set; }
        public int ItemLvl { get; set; }
        public StructRarity Rarity { get; set; }
        public int Concetration { get; set; }




    }
}
