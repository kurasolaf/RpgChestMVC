﻿using RpgChestMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Application.ViewModels.Item
{
   public class TypeOfArmorForItemListVm
    {
        public int Id { get; set; }
        public EnumArmorType EnumArmorType { get; set; }

    }
}
