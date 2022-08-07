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
        
        void DeleteFullArmor(int fullArmorId);

        int AddFullArmor(FullArmor fullArmor);
        
       
        FullArmor GetFullArmorById(int fullArmorId);
        
        IQueryable<FullArmor> GetFullArmorByLvl(int fullArmorLvl);


        IQueryable<FullArmor> GetAllActiveFullArmors(bool isActive = true);
        
        /*
* Add GetItemByTypeOfArmor method
* Add GetItemByTypeOfWeapon method
*
*/

    }
}
