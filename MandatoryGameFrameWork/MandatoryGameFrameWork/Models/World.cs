using System;
using System.Collections.Generic;

namespace MandatoryGameFrameWork
{
    public class World : AbsWorld
    {
        public World(int sizeX, int sizeY)
        {
            SizeX = sizeX;
            SizeY = sizeY;
            Entities = new List<AbsEntity>();
            DeadEntities = new List<AbsEntity>();
            Items = new List<AbsItem>();
        }

        public override void PopulateWorld()
        {
            Random rand = new Random();

            EntityFactory entityFactory = new EntityFactory();
            while (Entities.Count <= 10)
            {
                int x = rand.Next(1, SizeX + 1);
                int y = rand.Next(1, SizeY + 1);
                if(Entities.Find(entity => entity.PosX == x && entity.PosY == y) != null) continue;
                Entities.Add(entityFactory.CreateObject(x, y));
            }

            EquipmentFactory equipFactory = new EquipmentFactory();
            while(Items.Count <= 10)
            {
                int x = rand.Next(1, SizeX + 1);
                int y = rand.Next(1, SizeY + 1);
                if (Items.Find(entity => entity.PosX == x && entity.PosY == y) != null) continue;
                Items.Add(equipFactory.CreateObject(x, y));
            }

            FoodFactory foodFactory = new FoodFactory();
            while (Items.Count <= 20)
            {
                int x = rand.Next(1, SizeX + 1);
                int y = rand.Next(1, SizeY + 1);
                if (Items.Find(entity => entity.PosX == x && entity.PosY == y) != null) continue;
                Items.Add(foodFactory.CreateObject(x, y));
            }

        }

        public override void Move(Direction direction, AbsEntity entity)
        {
            int newPosX = entity.PosX;
            int newPosY = entity.PosY;

            switch (direction)
            {
                case Direction.Up:
                    newPosY = entity.PosY + 1;
                    break;
                case Direction.Down:
                    newPosY = entity.PosY - 1;
                    break;
                case Direction.Left:
                    newPosX = entity.PosX - 1;
                    break;
                case Direction.Right:
                    newPosX = entity.PosX + 1;
                    break;
                default:
                    break;
            }
            if (Entities.Find(e => e.PosX == newPosX && e.PosY == newPosY) != null) return;

            entity.PosX = newPosX;
            entity.PosY = newPosY;
        }
    }
}
