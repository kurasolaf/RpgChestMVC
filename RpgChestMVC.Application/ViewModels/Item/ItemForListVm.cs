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
    public class ItemForListVm : IMapFrom<RpgChestMVC.Domain.Model.Item>
    {
 
        public int Id { get; set; }
        public int ItemLvl { get; set; }
        public int NumberOfSockets { get; set; }
        public int Concentration { get; set; }
        public bool IsActive { get; set; }
        public EnumRarity Rarity { get; set; }
        public EnumWeaponType? EnumWeaponType { get; set; }

        public EnumArmorType? EnumArmorType { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<RpgChestMVC.Domain.Model.Item, ItemForListVm>()
                .ForMember(dest => dest.Rarity, opt => opt.MapFrom(src => src.Rarity.ItemRarity))
                .ForMember(dest => dest.EnumWeaponType, opt => opt.MapFrom(src => src.FullWeaponType != null ? src.FullWeaponType.TypeOfWeapon.EnumWeaponType : (EnumWeaponType?)null))
                .ForMember(dest => dest.EnumArmorType, opt => opt.MapFrom(src => src.FullArmorType != null ? src.FullArmorType.TypeOfArmor.EnumArmorType : (EnumArmorType?)null));
            profile.CreateMap<RpgChestMVC.Domain.Model.FullWeaponType, FullWeaponTypeForItemListVm>();     
        }
     
    }
}
