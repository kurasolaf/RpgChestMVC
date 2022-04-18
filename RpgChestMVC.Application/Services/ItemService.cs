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



        public int AddItem(NewItemVm item)
        {
            throw new NotImplementedException();
        }
        public ItemDetailsVm GetItemDetails(int ItemId)
        {
            throw new NotImplementedException();
        }


        public List<int> GetAllItems()
        {


            return new List<int>();
        }

        public ListItemForVm GetListItemForList()
        {
            throw new NotImplementedException();
        }
    }
}
