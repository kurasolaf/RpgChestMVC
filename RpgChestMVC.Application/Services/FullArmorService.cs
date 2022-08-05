using RpgChestMVC.Application.Interfaces;
using RpgChestMVC.Application.ViewModels.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Application.Services
{
    public class FullArmorService : IFullArmorService
    {
        public List<int> GetAllFullArmors()
        {
            return new List<int>();
        }

        public ListofFullArmorsVm GetAllFullArmorsForList(bool isActive)
        {
            throw new NotImplementedException();
        }

        public SingleFullArmorForDetailsVm GetFullArmorDetails(int FullArmorId)
        {
            throw new NotImplementedException();
        }
    }
}
