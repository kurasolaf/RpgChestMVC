using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Model
{
    public interface IItem
    {
        public int Id { get; set; }
        public int ItemLvl { get; set; } // Range 1-100
        public int Concentration { get; set; } // Range 1-100
        public int NumberOfSockets { get; set; } //Range 1-3
        public bool IsActive { get; set; }
        public string Rarity { get; set; }


    }
}
