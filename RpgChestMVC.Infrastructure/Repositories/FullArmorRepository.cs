using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using Microsoft.EntityFrameworkCore;
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
        public void DeleteFullArmor(int fullArmorId)
        {
            var item = _context.FullArmors.Find(fullArmorId);
            if (item != null)
            {
                _context.FullArmors.Remove(item);
                _context.SaveChanges();

            }

        }
        public int AddFullArmor(FullArmor fullArmor)
        {
            _context.FullArmors.Add(fullArmor);
            _context.SaveChanges();
            return fullArmor.Id;
        }
        public FullArmor GetFullArmorById(int fullArmorId)
        {
            var fullArmor = _context.FullArmors.Include(x => x.PlayerBackpack).FirstOrDefault(i => i.Id == fullArmorId);
            return fullArmor;
        }


        public IQueryable<FullArmor> GetAllActiveFullArmors(bool isActive)
        {
            var fullArmors = _context.FullArmors.Where(i => i.IsActive == isActive);
            return fullArmors;
        }

        public int AddNewFullArmor(FullArmor fullArmor)
        {
            _context.FullArmors.Add(fullArmor);
            _context.SaveChanges();
            return fullArmor.Id;
        }


 
        public void UpdateFullArmor(FullArmor fullArmor, int fullArmorId)
        {
            var forEditfullArmor = _context.FullArmors.FirstOrDefault(i => i.Id == fullArmorId);
            _context.Entry(forEditfullArmor).CurrentValues.SetValues(fullArmor);
            _context.SaveChanges();
        }
    }
}
