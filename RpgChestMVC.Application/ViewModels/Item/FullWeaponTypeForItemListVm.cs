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
        public int TypeOfWeaponId { get; set; }

        public EnumWeaponType EnumWeaponType { get; set; }




        public void Mapping(Profile profile)
        {
            profile.CreateMap<RpgChestMVC.Domain.Model.FullWeaponType, FullWeaponTypeForItemListVm>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.TypeOfWeaponId, opt => opt.MapFrom(s => s.TypeOfWeapon.Id))
                .ForMember(d => d.EnumWeaponType, opt => opt.MapFrom(s => s.TypeOfWeapon.EnumWeaponType));


        }

    }
}
