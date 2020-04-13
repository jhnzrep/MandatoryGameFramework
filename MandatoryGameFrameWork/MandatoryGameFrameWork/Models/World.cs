using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryGameFrameWork
{
    class World : AbsWorld
    {
        public World(int sizeX, int sizeY, int noOfMonsters, int noOfItems)
        {
            if (noOfMonsters + noOfItems >= sizeX * sizeY) throw new Exception("Not enough room for GameObjects");
            SizeX = sizeX;
            SizeY = sizeY;

        }
    }
}
