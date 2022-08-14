using AutoMapper;
using RpgChestMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Application.ViewModels.Item
{
   public class ResistanceForListVm : IMapFrom<RpgChestMVC.Domain.Model.Resistance>
    {
        public int Id { get; set; }
        public int ValueR { get; set; }
        public string Resistances { get; set; }

        public void Mapping(Profile profile)
        {

            profile.CreateMap<RpgChestMVC.Domain.Model.Resistance, ResistanceForListVm>();
              


        }


    }
}
