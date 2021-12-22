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
        //Connection below
        public int FullArmorTypeId { get; set; }
        public virtual FullArmorType FullArmorType { get; set; }
        // many to one - DONE / context - DONE
    }
}
