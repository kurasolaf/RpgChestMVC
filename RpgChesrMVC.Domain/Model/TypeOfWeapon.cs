using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Model
{
    public class TypeOfWeapon
    {
        public int Id { get; set; }
        public EnumWeaponType EnumWeaponType { get; set; }

        // Connections below
        public int FullWeaponTypesRef { get; set; }
        public FullWeaponType FullWeaponType { get; set; }

    }
}
