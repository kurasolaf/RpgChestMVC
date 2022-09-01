using AutoMapper;
using RpgChestMVC.Application.Mapping;

namespace RpgChestMVC.Application.ViewModels.Item
{
    
    public class TypeOfArmorVm : IMapFrom<RpgChestMVC.Domain.Model.TypeOfArmor>
    {
        public int Id { get; set; }
        public string ArmorTypes { get; set; }

        public void Mapping(Profile profile)
        {

            profile.CreateMap<RpgChestMVC.Domain.Model.TypeOfArmor, TypeOfArmorVm>();



        }


    }
}