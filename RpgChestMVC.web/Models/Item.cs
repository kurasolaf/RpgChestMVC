using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgChestMVC.web.Models
{

    // Pamiętać o przeniesieniu do DOMAIN do modeli oraz zrobić
    // klucze własne i obce w każdym dac ID
    public class Item : IItemBasicStats
    {
        public int Id { get; set; }
        public int ItemLvl { get; set; }
        public StructRarity Rarity { get; set; }
        public int Concetration { get; set; }

        public Item(int Id, int ItemLvl, StructRarity Rarity, int Concetration)
        {
            this.Id = Id;
            this.ItemLvl = ItemLvl;
            this.Rarity = Rarity;
            this.Concetration = Concetration;
        }

    }



}
