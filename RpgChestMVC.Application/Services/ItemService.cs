using RpgChestMVC.Application.Interfaces;
using RpgChestMVC.Application.ViewModels.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgChestMVC.Domain.Interfaces;

namespace RpgChestMVC.Application.Services
{
    public class ItemService : IItemService
    {
        //DONE stworzenie Losowości 1-8/1-10/1-21/1-500 / RollService  DONE
        //składanie przedmiotów pośrednich w cały ITEM
        //// skladanie Armorów
        //// skladanie Weaponów
        //// składanie Itemu

        private readonly ISingleItemRepository _itemRepo;

        public int AddItem(NewItemVm item)
        {
            throw new NotImplementedException();
        }

        public ItemDetailsVm GetItemDetails(int ItemId)
        {
            throw new NotImplementedException();
        }



       
        public ListItemForVm GetListItemForList()
        {
            var items = _itemRepo.GetAllActiveItems();
            ListItemForVm result = new ListItemForVm();
            result.Items = new List<ItemForListVm>();
            foreach (var item in items)
            {



            }
            result.Count = result.Items.Count;
            return result;


        }


            
        






    }
}
