using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Model
{
   /**
   Add database connection between classes, Add context, Migration
   **/
    class Item
    {
        public int Id { get; set; }
        public int ItemLvl { get; set; }
        public int Concentration { get; set; }
        public Rarity Rarity { get; set; }

    }


}
