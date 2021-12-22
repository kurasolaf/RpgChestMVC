﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Model
{
    public class TypeOfArmor
    {
        public int Id { get; set; }
        public EnumArmorType EnumArmorType { get; set; }
        // connection below
        
        public int FullArmorTypeRef { get; set; }
        public FullArmorType FullArmorType { get; set; }
        // one to one - DONE / context - DONE



    }
}
