using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgChestMVC.Application.ViewModels.Item;
using RpgChestMVC.Domain.Model;

namespace RpgChestMVC.Application.Interfaces
{
    public interface IFullArmorService
    {

        List<int> GetAllFullArmors();
        
        
       ListofFullArmorsVm GetAllFullArmorsForList(int pageSize, int pageNo, string searchString,bool isActive);



        SingleFullArmorForDetailsVm GetFullArmorDetails(int fullArmorId);

        int AddNewFullArmor(NewSingleFullArmorWm fullArmor);





    }
}
