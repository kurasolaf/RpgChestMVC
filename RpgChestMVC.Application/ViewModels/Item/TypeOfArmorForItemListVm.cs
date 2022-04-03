using RpgChestMVC.Domain.Model;
using AutoMapper;
using RpgChestMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Application.ViewModels.Item
{
   public class TypeOfArmorForItemListVm : IMapFrom<RpgChestMVC.Domain.Model.TypeOfArmor>
    {
        public int Id { get; set; }
        public EnumArmorType EnumArmorType { get; set; }



    }
}
