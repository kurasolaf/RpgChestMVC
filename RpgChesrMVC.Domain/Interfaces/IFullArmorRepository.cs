using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgChestMVC.Domain.Model;


namespace RpgChestMVC.Domain.Interfaces
{
    public interface IFullArmorRepository
    {
        
        void DeleteItem(int itemId);

        int AddItem(FullArmor fullArmor);
        
       
        FullArmor GetItemById(int itemId);
        
        IQueryable<FullArmor> GetItemByLvl(int itemLvl);

        IQueryable<FullArmor> GetItemByConcentration(int concentration);

        IQueryable<FullArmor> GetAllActiveItems(bool isActive = true);
        
        /*
* Add GetItemByTypeOfArmor method
* Add GetItemByTypeOfWeapon method
*
*/

    }
}
