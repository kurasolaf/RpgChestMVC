using AutoMapper;
using RpgChestMVC.Application.Mapping;
using RpgChestMVC.Domain.Model.EnumsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Application.ViewModels.Item
{
    public class SingleFullArmorForListVm : IMapFrom<RpgChestMVC.Domain.Model.FullArmor>
    {
        public int Id { get; set; }
        public int ItemLvl { get; set; }
        public int Concentration { get; set; }
        public int NumberOfSockets { get; set; }
        public bool IsActive { get; set; }
        public string Rarity { get; set; }

        public string TypeOfArmor { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<RpgChestMVC.Domain.Model.FullArmor, SingleFullArmorForListVm>()
            .ForMember(d => d.TypeOfArmor, opt => opt.MapFrom(s => s.TypeOfArmor.ArmorTypes));

        }
     
    }
}
