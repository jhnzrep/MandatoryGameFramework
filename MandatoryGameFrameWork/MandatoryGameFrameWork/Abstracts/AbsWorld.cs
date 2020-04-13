using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryGameFrameWork
{
    class AbsWorld
    {
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public AbsEntity Player { get; set; }
        public List<AbsEntity> Enitites { get; set; }
        public List<AbsItem> Items { get; set; }
    }
}
