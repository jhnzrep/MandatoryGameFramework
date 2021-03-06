﻿using System.Threading;

namespace MandatoryGameFrameWork
{
    public abstract class AbsItem : iItem
    {
        protected static int id = 0;
        protected static Mutex idMutex = new Mutex();

        public int Id { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
    }
}
