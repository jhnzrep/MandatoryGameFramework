using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryGameFrameWork
{
    abstract class AbsFactory<T>
    {
        public abstract T CreateObject(int PosX, int PosY);
        public abstract T CreateObject(int PosX, int PosY, string type);
    }
}
