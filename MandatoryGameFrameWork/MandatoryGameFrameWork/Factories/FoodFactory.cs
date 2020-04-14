using System;

namespace MandatoryGameFrameWork
{
    class FoodFactory
    {
        public FoodFactory()
        {

        }

        public AbsFood CreateFood(int PosX, int PosY)
        {
            Random rand = new Random();
            int type = rand.Next(1, 2 + 1);

            AbsFood food;

            switch (type)
            {
                default:
                    food = null;
                    break;
                case 1:
                    food = new Pizza(PosX, PosY);
                    break;
                case 2:
                    food = new Kebab(PosX, PosY);
                    break;
            }

            return food;
        }

        public AbsFood CreateEquipment(int PosX, int PosY, string type)
        {
            AbsFood food;

            switch (type)
            {
                default:
                    food = null;
                    break;
                case "PIZZA":
                    food = new Pizza(PosX, PosY);
                    break;
                case "KEBAB":
                    food = new Kebab(PosX, PosY);
                    break;
            }

            return food;
        }
    }

}
