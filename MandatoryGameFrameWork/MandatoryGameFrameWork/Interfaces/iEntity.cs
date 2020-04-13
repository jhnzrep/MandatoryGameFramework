using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryGameFrameWork
{
    public interface iEntity
    {
        public int Id { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
    }
}
