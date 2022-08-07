using RpgChestMVC.Application.Interfaces;
using RpgChestMVC.Application.ViewModels.Item;
using RpgChestMVC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Application.Services
{
    public class FullArmorService : IFullArmorService
    {

        private readonly IFullArmorRepository _fullArmorRepository;




        public int AddNewFullArmor(NewSingleFullArmorWm fullArmor)
        {
            throw new NotImplementedException();
        }

        public List<int> GetAllFullArmors()
        {
            return new List<int>();
        }

        public ListofFullArmorsVm GetAllFullArmorsForList(bool isActive)
        {
            var fullArmors = _fullArmorRepository.GetAllActiveFullArmors();

            ListofFullArmorsVm result = new ListofFullArmorsVm();
            result.FullArmors = new List<SingleFullArmorForListVm>();

            foreach ( var fullArmor in fullArmors)
            {
                var fAmor = new SingleFullArmorForListVm();
                {
                    Id = fullArmor.Id;
                    ItemLvl = fullArmor.ItemLvl;
                    Concentration = fullArmor.Concentration;
                    NumberOfSockets = fullArmor.NumberOfSockets;
                    Rarity = fullArmor.Rarity;
                    TypeOfArmor = fullArmor.TypeOfArmor;

                }
                result.FullArmors.Add(fAmor);
            }
            result.Count = result.FullArmors.Count;
            return result;
             
            
        }

        public SingleFullArmorForDetailsVm GetFullArmorDetails(int fullArmorId)
        {
            var fullArmor = _fullArmorRepository.GetFullArmorById(fullArmorId);
            var singleFullArmorVm = new SingleFullArmorForDetailsVm();
            singleFullArmorVm.Id = fullArmor.Id;
            singleFullArmorVm.Kp = fullArmor.Kp;
            singleFullArmorVm.ItemLvl = fullArmor.ItemLvl;
            singleFullArmorVm.Concentration = fullArmor.Concentration;
            singleFullArmorVm.NumberOfSockets = fullArmor.NumberOfSockets;
            singleFullArmorVm.Rarity = fullArmor.Rarity;
            singleFullArmorVm.PlayerBackpack = fullArmor.PlayerBackpack.Name;
            
        }
    }
}
