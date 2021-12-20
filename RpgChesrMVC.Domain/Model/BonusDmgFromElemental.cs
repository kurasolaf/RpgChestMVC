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

        public int ValueR;
        public EnumResistance DmgFromElement;
        
        //connection below
        public int FullWeaponTypeId { get; set; }
        public virtual FullWeaponType FullWeaponTypes { get; set; }
        // Many to one (DONE) / context - undone
    }
}
