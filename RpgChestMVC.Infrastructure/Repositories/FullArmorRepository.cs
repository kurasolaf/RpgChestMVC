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
            var fullArmor = _context.FullArmors.FirstOrDefault(i => i.Id == fullArmorId);
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


        int IFullArmorRepository.EditFullArmor(FullArmor fullArmor)
        {
            throw new NotImplementedException();
        }

        public void UpdateFullArmor(FullArmor fullArmor)
        {
            _context.Attach(fullArmor);
            _context.Entry(fullArmor).Property("Kp").IsModified = true;
            _context.Entry(fullArmor).Property("Hp").IsModified = true;
            _context.Entry(fullArmor).Property("ResistanceForAll").IsModified = true;
            _context.Entry(fullArmor).Property("PhysicalAbsorption").IsModified = true;
            _context.Entry(fullArmor).Property("MagicalAbsorption").IsModified = true;
            _context.Entry(fullArmor).Property("PhysicalReduction").IsModified = true;
            _context.Entry(fullArmor).Property("MagicalReduction").IsModified = true;
            _context.Entry(fullArmor).Property("HpPerLvl").IsModified = true;
            _context.Entry(fullArmor).Property("DailyRegenerationFor4Turns").IsModified = true;
            _context.Entry(fullArmor).Property("PlayerBackpack").IsModified = true;
            _context.Entry(fullArmor).Property("ArmorType").IsModified = true;
            _context.Entry(fullArmor).Property("Resistances").IsModified = true;
            _context.Entry(fullArmor).Property("ItemLvl").IsModified = true;
            _context.Entry(fullArmor).Property("Concentration").IsModified = true;
            _context.Entry(fullArmor).Property("NumberOfSockets").IsModified = true;
            _context.Entry(fullArmor).Property("IsActive").IsModified = true;
            _context.Entry(fullArmor).Property("Rarity").IsModified = true;
            _context.SaveChanges();
        }
    }
}
