using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgChestMVC.Domain.Model;

namespace RpgChestMVC.Infrastructure.Repositories
{
    public class ItemRepository
    {


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

        public IQueryable<Item> GetItemByRarityId(int RarityId)
        {
            var items = _context.Items.Where(i => i.RarityId == RarityId);
            return items;

        }


        public Item GetItemById(int itemId)
        {
            var item = _context.Items.FirstOrDefault(i => i.Id == itemId);
            return item;
        }


    }
}
