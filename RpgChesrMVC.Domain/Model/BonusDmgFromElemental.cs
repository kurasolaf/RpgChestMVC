using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Model
{
    public class BonusDmgFromElemental
    {
        public int Id { get; set; }
        public BasicResistance BonusDmgFromElementals { get; set; }

        public int FullWeaponTypeRef { get; set; }
        public FullWeaponType FullWeaponTypes { get; set; }

    }
}
