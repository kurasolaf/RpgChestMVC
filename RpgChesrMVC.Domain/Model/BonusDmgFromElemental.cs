﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Domain.Model
{
    public class BonusDmgFromElemental
    {
        public int Id { get; set; }
        public StructResistance BonusDmgFromElementals { get; set; }

        public virtual ICollection<FullWeaponType> FullWeaponTypes { get; set; }

    }
}
