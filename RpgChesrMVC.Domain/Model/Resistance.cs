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
        public EnumResistance BasicResistances { get; set; }

        public virtual ICollection<FullArmorType> FullArmorTypes { get; set; }
    }
}
