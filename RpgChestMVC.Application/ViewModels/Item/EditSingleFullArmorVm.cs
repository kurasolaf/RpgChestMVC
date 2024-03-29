﻿using AutoMapper;
using RpgChestMVC.Application.Mapping;
using System.Collections.Generic;

namespace RpgChestMVC.Application.ViewModels.Item
{
    public class EditSingleFullArmorVm : IMapFrom<RpgChestMVC.Domain.Model.FullArmor>
    {
       
        
        public int Id { get; set; }
        public int Kp { get; set; }
        public int Hp { get; set; }
        public int ResistanceForAll { get; set; }
        public int PhysicalAbsorption { get; set; }
        public int MagicalAbsorption { get; set; }
        public int PhysicalReduction { get; set; }
        public int MagicalReduction { get; set; }
        public int HpPerLvl { get; set; }
        public int DailyRegenerationFor4Turns { get; set; }

        public int ItemLvl { get; set; }
        public int Concentration { get; set; }
        public int NumberOfSockets { get; set; }
        public bool IsActive { get; set; }
        public string Rarity { get; set; }


        // // // // // // BELOW more complex properties // // // // // //


        public string ArmorType { get; set; }

        public List<ResistanceForListVm> Resistances { get; set; }

        public void Mapping(Profile profile)
        {

            profile.CreateMap<EditSingleFullArmorVm, RpgChestMVC.Domain.Model.FullArmor>()
                .ForMember(d => d.Resistances, opt => opt.Ignore());

        }

    }
  }

