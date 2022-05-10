using AutoMapper;
using RpgChestMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Application.ViewModels.Item
{
    public class ListItemForVm : IMapFrom<RpgChestMVC.Domain.Model.Item>
    {
        //to jest jak DTO
        // pod paginacje (dzielenie na mniejsze strony)
        public List<ItemForListVm> Items { get; set; }
        public int Count { get; set; }

        public bool IsActive { get; set; }



        public void Mapping(Profile profile)
        {
            profile.CreateMap<RpgChestMVC.Domain.Model.Item, ListItemForVm>();


        }

    }
}
