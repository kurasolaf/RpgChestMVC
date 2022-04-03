using AutoMapper;
using RpgChestMVC.Application.Mapping;
using RpgChestMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Application.ViewModels.Item
{
    public class FullWeaponTypeForItemListVm : IMapFrom<RpgChestMVC.Domain.Model.FullWeaponType>
    {
        public int Id { get; set; }

        public TypeOfWeaponForItemListVm TypeOfWeapon { get; set; }




    }
}
