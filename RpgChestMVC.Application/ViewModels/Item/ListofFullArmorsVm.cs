using AutoMapper;
using RpgChestMVC.Application.Mapping;
using System.Collections.Generic;

namespace RpgChestMVC.Application.ViewModels.Item
{
    public class ListofFullArmorsVm : IMapFrom<RpgChestMVC.Domain.Model.FullArmor>
    {
        
        // pod paginacje (dzielenie na mniejsze strony)
        public List<SingleFullArmorForListVm> FullArmors { get; set; }
        public int Count { get; set; }
        public int CurrentPage { get; set; }

        public int PageSize { get; set; }

        public string SearchString { get; set; }

        public bool IsActive { get; set; }






        public void Mapping(Profile profile)
        {

            profile.CreateMap<RpgChestMVC.Domain.Model.FullArmor, SingleFullArmorForListVm>();


        }


    }
}
