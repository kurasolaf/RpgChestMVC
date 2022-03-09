using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Application.ViewModels.Item
{
    public class DmgForFullWeaponTypeVm
    {

        public int Id { get; set; }
        public int DmgMultiplier { get; set; }

        public int DmgDice { get; set; }
    }
}
