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
        public string WeaponType { get; set; }
        
        public virtual ICollection<FullArmor> FullArmors { get; set; }

        // Connections below 


    }
}
