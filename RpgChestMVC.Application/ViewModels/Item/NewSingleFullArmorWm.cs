using AutoMapper;
using FluentValidation;
using RpgChestMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Application.ViewModels.Item
{
    public class NewSingleFullArmorWm : IMapFrom<RpgChestMVC.Domain.Model.FullArmor>
    {
        public int Id { get; set; }
        [Range(0,100)]
        public int Kp { get; set; }
        [Range(0, 100)]
        public int Hp { get; set; }
        [Range(0, 50)]
        public int ResistanceForAll { get; set; }
        [Range(0, 100)]
        public int PhysicalAbsorption { get; set; }
        [Range(0, 100)]
        public int MagicalAbsorption { get; set; }
        [Range(0, 100)]
        public int PhysicalReduction { get; set; }
        [Range(0, 100)]
        public int MagicalReduction { get; set; }
        [Range(0, 25)]
        public int HpPerLvl { get; set; }
        [Range(0, 4)]
        public int DailyRegenerationFor4Turns { get; set; }
        [Range(0, 100)]
        public int ItemLvl { get; set; }
        [Range(0, 100)]
        public int Concentration { get; set; }
        [Range(0, 4)]
        public int NumberOfSockets { get; set; }
        public bool IsActive { get; set; }
        public string Rarity { get; set; }


        // // // // // // BELOW more complex properties // // // // // //


        public string ArmorType { get; set; }

        public List<ResistanceForListVm> Resistances { get; set; }

        public void Mapping(Profile profile)
        {

            profile.CreateMap<NewSingleFullArmorWm, RpgChestMVC.Domain.Model.FullArmor>()
                .ForMember(d => d.Resistances, opt => opt.Ignore());


        }



    }
}
