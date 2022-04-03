using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using RpgChestMVC.Application.Mapping;
using RpgChestMVC.Domain.Model;

namespace RpgChestMVC.Application.ViewModels.Item
{
    public class FullArmorTypeForItemListVm : IMapFrom<RpgChestMVC.Domain.Model.FullArmorType>
    {
        public int Id { get; set; }

        public TypeOfArmorForItemListVm TypeOfArmor { get; set; }






    }
}
