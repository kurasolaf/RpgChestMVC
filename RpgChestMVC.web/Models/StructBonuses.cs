using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgChestMVC.web.Models
{

    public struct SecondaryStat
    {
        public int valueSs;
        public EnumSecondaryStat secondaryStat;
    }

    public struct BasicStats
    {
        public int valueSb;
        public EnumBasicStats basicStat;

    }

    public struct Resistance
    {
        public int valueR;
        public EnumResistance resist;
    }

    public struct BasicElements
    {
        public int valueBE;
        public EnumBasicElements basicElement;
    }

    public struct AdvancedElements
    {
        public int valueAE;
        public EnumAdvancedElements advancedElement;
    }




}
