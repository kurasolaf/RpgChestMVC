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
        // dodatkowo IsActive = true
        // dodatkowo RarityId = 2
        public int Id { get; set; } //=7
        public int ItemLvl { get; set; }//=14
        public int Concentration { get; set; }//=10
        public int NumberOfSockets { get; set; }//=3

        public virtual ICollection<BasicStatForItemDetailsVm> BasicStats { get; set; }//=null
        

        public virtual ICollection<SecondaryStatForItemDetailsVm> SecondaryStats { get; set; }//=null

        public EnumRarity Rarity { get; set; }//=null

        public EnumWeaponType? EnumWeaponType { get; set; } // zamiast tego jest fullweapontype= null

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

        public virtual ICollection<BonusDmgForItemDetailsVm> BonusDmgs { get; set; }

        /// From inner BonusDmgFromElemental prop:
        public virtual ICollection<BonusDmgFromElementalForItemDetailsVm> BonusDmgFromElementals { get; set; }

        //////////////END FOR ABOVE /////////////////////////////////

        public EnumArmorType? EnumArmorType { get; set; } // zamiast tego jest fullarmortype =null
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

        public virtual ICollection<ResistanceForItemDetailsVm> Resistance { get; set; }

        //////////////END FOR ABOVE//////////////////////////////////

        
        public void Mapping(Profile profile)
        {

            profile.CreateMap<RpgChestMVC.Domain.Model.Item, ItemDetailsVm>()

                .ForMember(dest => dest.Rarity, opt => opt.MapFrom(src => src.Rarity.ItemRarity))
                .ForMember(dest => dest.EnumWeaponType, opt => opt.MapFrom(src => src.FullWeaponType != null ? src.FullWeaponType.TypeOfWeapon.EnumWeaponType : (EnumWeaponType?)null))
                .ForMember(dest => dest.EnumArmorType, opt => opt.MapFrom(src => src.FullArmorType != null ? src.FullArmorType.TypeOfArmor.EnumArmorType : (EnumArmorType?)null));
            profile.CreateMap<RpgChestMVC.Domain.Model.FullWeaponType, FullWeaponTypeForItemDetailsVm>();
            profile.CreateMap<RpgChestMVC.Domain.Model.TypeOfWeapon, TypeOfWeaponForItemDetails>();

        }
    }
}