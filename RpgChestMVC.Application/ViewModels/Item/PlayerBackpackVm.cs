using AutoMapper;
using RpgChestMVC.Application.Mapping;

namespace RpgChestMVC.Application.ViewModels.Item
{
    public class PlayerBackpackVm : IMapFrom<RpgChestMVC.Domain.Model.PlayerBackpack>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {

            profile.CreateMap<RpgChestMVC.Domain.Model.PlayerBackpack, PlayerBackpackVm>();



        }

    }
}