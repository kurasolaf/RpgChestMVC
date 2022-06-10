using System;
using AutoMapper;
using RpgChestMVC.Application.Mapping;
using RpgChestMVC.Domain.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Application.ViewModels.Item
{
    public class ItemDetailsVm : IMapFrom<RpgChestMVC.Domain.Model.Item>
    {

        public int Id { get; set; }
        public int ItemLvl { get; set; }
        public int Concentration { get; set; }
        public int NumberOfSockets { get; set; }

        public virtual ICollection<BasicStat> BasicStats { get; set; }
        

        public virtual ICollection<SecondaryStat> SecondaryStats { get; set; }

        public EnumRarity Rarity { get; set; }

        public EnumWeaponType? EnumWeaponType { get; set; }

        //PROP from Weapon Type Item////////////////////////////////

        /// From inner Dmg prop:
        public int DmgMultiplier { get; set; }
        public int DmgDice { get; set; }

        public int CritChance { get; set; }
        public int CritMultiplier { get; set; }
        public int CritBonusDmg { get; set; }
        public int HpDrain { get; set; }
        public int Bonus10ForKpPenetration { get; set; }
        public int BonusSA { get; set; }
        public int BonusDmgVsSummons { get; set; }
        public int ExtraWeaponRange { get; set; }
        public int ShieldPointDestroyer { get; set; }
        public int ExtraKpPenetrationForHammer { get; set; }

    
        /// From inner BonusDmg prop:
        public int BonusDmgMultiplier { get; set; }
        public int BonusDmgDice { get; set; }


        
        /// From inner BonusDmgFromElemental prop:
        public EnumResistance DmgFromElement { get; set; }
        public int ValueR { get; set; }

        //////////////END FOR ABOVE /////////////////////////////////

        public EnumArmorType? EnumArmorType { get; set; }
        //PROP from Armor Type Item

        public int Kp { get; set; }
        public int Hp { get; set; }
        public int ResistanceForAll { get; set; }
        public int PhysicalAbsorption { get; set; }
        public int MagicalAbsorption { get; set; }
        public int PhysicalReduction { get; set; }
        public int MagicalReduction { get; set; }
        public int HpPerLvl { get; set; }
        public int DailyRegenerationFor4Turns { get; set; }

        ///From inner Resistance prop:
        public int BasicResistanceValueR { get; set; }
        public EnumResistance BasicResistances { get; set; }

        //////////////END FOR ABOVE//////////////////////////////////




        // TODO: MAPPING: BasicStats, SecondaryStat, DmgMultiplier - DmgDice, BonusDmgMultiplier - BonusDmgDice,  DmgFromElement - ValueR//
        public void Mapping(Profile profile)
        {
            profile.CreateMap<RpgChestMVC.Domain.Model.Item, ItemDetailsVm>()
                .ForMember(dest => dest.Rarity, opt => opt.MapFrom(src => src.Rarity.ItemRarity))
                .ForMember(dest => dest.EnumWeaponType, opt => opt.MapFrom(src => src.FullWeaponType != null ? src.FullWeaponType.TypeOfWeapon.EnumWeaponType : (EnumWeaponType?)null))
                .ForMember(dest => dest.EnumArmorType, opt => opt.MapFrom(src => src.FullArmorType != null ? src.FullArmorType.TypeOfArmor.EnumArmorType : (EnumArmorType?)null));
                
                

        }
    }
}