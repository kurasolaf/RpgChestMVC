using RpgChestMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Interfaces
{
    public interface ISingleItemRepository
    {

        FullArmor GetItem(int FullArmorId);

    }
}
