using RpgChestMVC.Application.Interfaces;
using RpgChestMVC.Application.ViewModels.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgChestMVC.Domain.Interfaces;
using AutoMapper.QueryableExtensions;
using AutoMapper;
using RpgChestMVC.Domain.Model;

namespace RpgChestMVC.Application.Services
{
    public class ItemService : IItemService
    {
        //DONE stworzenie Losowości 1-8/1-10/1-21/1-500 / RollService  DONE
        //składanie przedmiotów pośrednich w cały ITEM
        //// skladanie Armorów
        //// skladanie Weaponów
        //// składanie Itemu
        //// wyświetlanie listy
        //// wyświetlanie detali item
        

        private readonly IItemRepository _itemRepo;
        private readonly IMapper _mapper;

        public ItemService(IItemRepository itemRepo, IMapper mapper)
        {
            _itemRepo = itemRepo;
            _mapper = mapper;

        }


        public ListOfItemsVm GetAllItemsForList(bool isActive)
        {
            var items = _itemRepo.GetAllActiveItems(isActive)
                .ProjectTo<ItemForListVm>(_mapper.ConfigurationProvider).ToList();
            var itemList = new ListOfItemsVm()
            {
                Items = items,
                Count = items.Count

            };
            return itemList;
            

        }

        public int AddItem(NewItemVm item)
        {
            throw new NotImplementedException();
           
        }
        public ItemDetailsVm GetItemDetails(int ItemId)
        {
            var item = _itemRepo.GetItemById(ItemId);
            var itemVm = _mapper.Map<ItemDetailsVm>(item);


            itemVm.Rarity = new RarityForItemVm();
            itemVm.FullArmorType = new FullArmorTypeForItemDetailsVm();
            itemVm.FullWeaponType = new FullWeaponTypeForItemDetailsVm();
            

            return itemVm;
            
        }
    }
}
