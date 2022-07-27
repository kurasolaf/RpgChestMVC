using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Model
{
    public class TypeOfArmor
    {

        
        public int Id { get; set; }
        public string ArmorTypes { get; set; }

        
        public virtual ICollection<FullArmor> FullArmors { get; set; }
        //connection one to many/context -done


    }
}
