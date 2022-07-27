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
    public class FullArmorRepository : IFullArmorRepository
    {
        // To do List:
        // TODO  // Add GetItemByTypeOfArmor method // Add GetItemByTypeOfWeapon method // Add GetItemBy some specific stat?


        private readonly Context _context;

        public FullArmorRepository(Context context)
        {

            _context = context;

        }

        public void DeleteItem(int fullArmorId)
        {
            var item = _context.FullArmors.Find(fullArmorId);
            if (item != null)
            {
                _context.FullArmors.Remove(item);
                _context.SaveChanges();

            }

        }

        public int AddItem(FullArmor fullArmor)
        {
            _context.FullArmors.Add(fullArmor);
            _context.SaveChanges();
            return fullArmor.Id;
        }

        public IQueryable<FullArmor> GetItemByConcentration(int concentration)
        {
            var items = _context.FullArmors.Where(i => i.Concentration == concentration);
            return items;

        }


        public FullArmor GetItemById(int itemId)
        {
            var item = _context.FullArmors.FirstOrDefault(i => i.Id == itemId);
            return item;
        }


        public IQueryable<FullArmor> GetItemByLvl(int itemLvl)
        {
            var items = _context.FullArmors.Where(i => i.ItemLvl == itemLvl);
            return items;
        }
      

        public IQueryable<FullArmor> GetAllActiveItems(bool isActive)
        {
            var items = _context.FullArmors.Where(i => i.IsActive == isActive);
            return items;
        }


    }
}
