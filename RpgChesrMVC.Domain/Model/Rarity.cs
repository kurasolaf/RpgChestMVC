using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Model
{
    public class Rarity
    {
        public int Id { get; set; }
        public BasicRarity BasicRarity { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
