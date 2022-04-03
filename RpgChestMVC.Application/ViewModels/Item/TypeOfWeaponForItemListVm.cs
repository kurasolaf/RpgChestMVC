using RpgChestMVC.Domain.Model;
using RpgChestMVC.Application.Mapping;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Application.ViewModels.Item
{
    public class TypeOfWeaponForItemListVm : IMapFrom<RpgChestMVC.Domain.Model.TypeOfWeapon>
    {
        public int Id { get; set; }

        public EnumWeaponType EnumWeaponType { get; set; }


    }
}
