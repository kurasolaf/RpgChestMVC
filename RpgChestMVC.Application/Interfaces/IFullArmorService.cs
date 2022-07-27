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
        ListofFullArmorsVm GetAllItemsForList(bool isActive);

        //int AddItem(NewItemVm item);

        SingleFullArmorForDetailsVm GetItemDetails(int itemId);







    }
}
