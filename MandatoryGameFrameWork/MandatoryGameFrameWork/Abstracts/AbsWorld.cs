using System.Collections.Generic;

namespace MandatoryGameFrameWork
{
    abstract class AbsWorld
    {
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public AbsEntity Player { get; set; }
        public List<AbsEntity> Entities { get; set; }
        public List<AbsItem> Items { get; set; }

        public abstract void PopulateWorld();
        public abstract void Move(Direction direction, AbsEntity entity);
    }
}
