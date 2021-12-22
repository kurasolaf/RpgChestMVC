using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using RpgChestMVC.Domain.Interfaces;
using RpgChestMVC.Domain.Model;

namespace RpgChestMVC.Infrastructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        // To do List:
        // TODO  // Add GetItemByTypeOfArmor method // Add GetItemByTypeOfWeapon method // Add GetItemBy some specific stat?
        

        private readonly Context _context;

        public ItemRepository(Context context)
        {

            _context = context;

        }

        public void DeleteItem(int itemId)
        {
            var item = _context.Items.Find(itemId);
            if(item != null)
            {
                _context.Items.Remove(item);
                _context.SaveChanges();

            }

        }

        public int AddItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return item.Id;
        }

        public IQueryable<Item> GetItemByRarityId(int rarityId)
        {
            var items = _context.Items.Where(i => i.RarityId == rarityId);
            return items;

        }

        public IQueryable<Item> GetItemByConcentration(int concentration )
        {
            var items = _context.Items.Where(i => i.Concentration == concentration );
            return items;

        }


        public Item GetItemById(int itemId)
        {
            var item = _context.Items.FirstOrDefault(i => i.Id == itemId);
            return item;
        }


        public IQueryable<Item> GetItemByLvl(int itemLvl)
        {
            var items = _context.Items.Where(i => i.ItemLvl == itemLvl);
            return items;
        }



    }
}
