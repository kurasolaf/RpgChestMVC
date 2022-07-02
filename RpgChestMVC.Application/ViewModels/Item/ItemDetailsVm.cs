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

        public ICollection<BonusDmgVm> BonusDmgs { get; set; }


        
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
                   .ForMember(dest => dest.DmgMultiplier, opt => opt.MapFrom(src => src.FullWeaponType != null ? src.FullWeaponType.Dmg.DmgMultiplier : (int?)0))
                   .ForMember(dest => dest.DmgDice, opt => opt.MapFrom(src => src.FullWeaponType != null ? src.FullWeaponType.Dmg.DmgDice : (int?)0))
                   .ForMember(dest => dest.CritChance, opt => opt.MapFrom(src => src.FullWeaponType != null ? src.FullWeaponType.CritChance : (int?)0))
                   .ForMember(dest => dest.CritMultiplier, opt => opt.MapFrom(src => src.FullWeaponType != null ? src.FullWeaponType.CritMultiplier : (int?)0))
                   .ForMember(dest => dest.CritBonusDmg, opt => opt.MapFrom(src => src.FullWeaponType != null ? src.FullWeaponType.CritBonusDmg : (int?)0))
                   .ForMember(dest => dest.HpDrain, opt => opt.MapFrom(src => src.FullWeaponType != null ? src.FullWeaponType.HpDrain : (int?)0))
                   .ForMember(dest => dest.Bonus10ForKpPenetration, opt => opt.MapFrom(src => src.FullWeaponType != null ? src.FullWeaponType.Bonus10ForKpPenetration : (int?)0))
                   .ForMember(dest => dest.BonusSA, opt => opt.MapFrom(src => src.FullWeaponType != null ? src.FullWeaponType.BonusSA : (int?)0))
                   .ForMember(dest => dest.BonusDmgVsSummons, opt => opt.MapFrom(src => src.FullWeaponType != null ? src.FullWeaponType.BonusDmgVsSummons : (int?)0))
                   .ForMember(dest => dest.ExtraWeaponRange, opt => opt.MapFrom(src => src.FullWeaponType != null ? src.FullWeaponType.ExtraWeaponRange : (int?)0))
                   .ForMember(dest => dest.ShieldPointDestroyer, opt => opt.MapFrom(src => src.FullWeaponType != null ? src.FullWeaponType.ShieldPointDestroyer : (int?)0))
                   .ForMember(dest => dest.ExtraKpPenetrationForHammer, opt => opt.MapFrom(src => src.FullWeaponType != null ? src.FullWeaponType.ExtraKpPenetrationForHammer : (int?)0))

                   .ForMember(dest => dest.EnumArmorType, opt => opt.MapFrom(src => src.FullArmorType != null ? src.FullArmorType.TypeOfArmor.EnumArmorType : (EnumArmorType?)null));
            profile.CreateMap<RpgChestMVC.Domain.Model.BonusDmg, BonusDmgVm>();
                

        }
    }
}