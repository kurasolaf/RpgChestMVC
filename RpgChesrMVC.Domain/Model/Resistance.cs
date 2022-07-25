using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Model
{
    public class Resistance
    {
        public int Id { get; set; }
        public int ValueR { get; set; }
        public string Resistances { get; set; }

        public int FullArmorTypeId { get; set; }
        public virtual FullArmorType SingleArmor { get; set; }

    }
}
