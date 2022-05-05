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

        private readonly IItemRepository _itemRepo;
        private readonly IMapper _mapper;

        public ItemService(IItemRepository itemRepo, IMapper mapper)
        {
            _itemRepo = itemRepo;
            _mapper = mapper;

        }


        public ListItemForVm GetAllItemsForList(bool isActive)
        {
            var items = _itemRepo.GetAllActiveItems(isActive);
            ListItemForVm result = new ListItemForVm();
            result.Items = new List<ItemForListVm>();
            foreach(var item in items)
            {
                var itmVm = new ItemForListVm()
                {
                    Id = item.Id,
                    EnumArmorType = item.FullArmorType.TypeOfArmor.EnumArmorType,
                    EnumWeaponType = item.FullWeaponType.TypeOfWeapon.EnumWeaponType,
                    ItemLvl = item.ItemLvl,
                    NumberOfSockets = item.NumberOfSockets,
                    Rarity = item.Rarity.ItemRarity

                };
                result.Items.Add(itmVm);

            }
            result.Count = result.Items.Count;
            return result;

        }

        public int AddItem(NewItemVm item)
        {
            throw new NotImplementedException();
           
        }
        public ItemDetailsVm GetItemDetails(int ItemId)
        {
            var item = _itemRepo.GetItemById(ItemId);
            var itemVm = new ItemDetailsVm();

            itemVm.Id = item.Id;
            itemVm.ItemLvl = item.ItemLvl;
            itemVm.NumberOfSockets = item.NumberOfSockets;
            itemVm.Concentration = item.Concentration;
            itemVm.Rarity.ItemRarity = item.Rarity.ItemRarity;

            itemVm.



            return itemVm;
            


        }



    }
}
