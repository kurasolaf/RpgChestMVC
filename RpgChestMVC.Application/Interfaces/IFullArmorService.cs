using System.Collections.Generic;
using RpgChestMVC.Application.ViewModels.Item;

namespace RpgChestMVC.Application.Interfaces
{
    public interface IFullArmorService
    {

        List<int> GetAllFullArmors();
        
        
        ListofFullArmorsVm GetAllFullArmorsForList(int pageSize, int pageNo, string searchString,bool isActive);


        
        SingleFullArmorForDetailsVm GetFullArmorDetails(int fullArmorId);

        int AddNewFullArmor(NewSingleFullArmorWm fullArmor);


        void DeleteFullArmor(int fullArmorId);


  
        void UpdateFullArmor(EditSingleFullArmorVm model, int fullArmorId);

    }
}
