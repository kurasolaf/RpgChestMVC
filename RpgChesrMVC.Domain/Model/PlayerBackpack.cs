using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Model
{
    public class PlayerBackpack
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<FullArmor> FullArmors { get; set; }
        //connection one to many/context -done








    }
}
