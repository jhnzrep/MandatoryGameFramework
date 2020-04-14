using System;

namespace MandatoryGameFrameWork
{
    class EntityFactory
    {
        public EntityFactory()
        {

        }
        
        public AbsEntity CreateEntity(int PosX, int PosY)
        {
            Random rand = new Random();
            int type = rand.Next(1, 2+1);

            AbsEntity entity;

            switch (type)
            {
                default:
                    entity = null;
                    break;
                case 1:
                    entity = new Troll(PosX, PosY);
                    break;
                case 2:
                    entity = new BabaYaga(PosX, PosY);
                    break;
            }

            return entity;
        }

        public AbsEntity CreateEntity(int PosX, int PosY, string type)
        {
            AbsEntity entity;

            switch (type)
            {
                default:
                    entity = null;
                    break;
                case "TROLL":
                    entity = new Troll(PosX, PosY);
                    break;
                case "BABAYAGA":
                    entity = new BabaYaga(PosX, PosY);
                    break;
            }

            return entity;
        }
    }
}
