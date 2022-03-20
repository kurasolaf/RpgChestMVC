using RpgChestMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Application.ViewModels.Item
{
    public class RarityForItemVm
    {
        public int Id { get; set; }
        
        public int BonusMultiplier { get; set; }

        public EnumRarity ItemRarity { get; set; }



    }
}
