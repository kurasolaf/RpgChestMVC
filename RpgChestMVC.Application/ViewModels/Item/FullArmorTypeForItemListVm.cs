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

        public int TypeOfArmorId { get; set; }
        public EnumArmorType EnumArmorType { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<RpgChestMVC.Domain.Model.FullArmorType, FullArmorTypeForItemListVm>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.TypeOfArmorId, opt => opt.MapFrom(s => s.TypeOfArmor.Id))
                .ForMember(d => d.EnumArmorType, opt => opt.MapFrom(s => s.TypeOfArmor.EnumArmorType));


        }




    }
}
