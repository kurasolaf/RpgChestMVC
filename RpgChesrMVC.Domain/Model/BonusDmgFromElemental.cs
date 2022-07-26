using RpgChestMVC.Domain.Model.EnumsModels;
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

        public int ValueR { get; set; }
        public EnumResistance DmgFromElement { get; set; }

        //connection below
        public int FullWeaponId { get; set; }
        public virtual FullWeapon FullWeapon { get; set; }
        // Many to one (DONE) / context - DONE
    }
}
