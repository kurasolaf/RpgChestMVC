using RpgChestMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Application.ViewModels.Item
{
    public class ResistanceForItemDetailsVm
    {
        public int ValueR { get; set; }
        public EnumResistance BasicResistances { get; set; }
    }
}
