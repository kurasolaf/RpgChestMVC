using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Model
{
    public class BasicStat
    {
        public int Id { get; set; }

        public EnumBasicStat BasicsStat { get; set; }

        public int ValueBS;

        //Connection below







        // many to one -   / context -  

    }
}
