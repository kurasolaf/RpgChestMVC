using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgChestMVC.Domain.Model;

namespace RpgChestMVC.Domain.Interfaces
{
    public  interface IItemRepository
    {
        
        void DeleteItem(int itemId);

        int AddItem(Item item);
        
        IQueryable<Item> GetItemByRarityId(int rarityId);
        
        Item GetItemById(int itemId);
        
        IQueryable<Item> GetItemByLvl(int itemLvl);

        IQueryable<Item> GetItemByConcentration(int concentration);

         IQueryable<Item> GetAllActiveItems(bool isActive);
        
        /*
* Add GetItemByTypeOfArmor method
* Add GetItemByTypeOfWeapon method
*
*/

    }
}
