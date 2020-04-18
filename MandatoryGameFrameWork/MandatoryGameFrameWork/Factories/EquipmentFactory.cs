using System;

namespace MandatoryGameFrameWork
{
    class EquipmentFactory : AbsFactory<AbsEquipment>
    {
        public EquipmentFactory()
        {

        }

        public override AbsEquipment CreateObject(int PosX, int PosY, string type)
        {
            AbsEquipment equipment;

            switch (type)
            {
                default:
                    equipment = null;
                    break;
                case "AXE":
                    equipment = new Axe(PosX, PosY);
                    break;
                case "WOODENSHIELD":
                    equipment = new WoodenShield(PosX, PosY);
                    break;
                case "WAND":
                    equipment = new Wand(PosX, PosY);
                    break;
            }

            return equipment;
        }

        public override AbsEquipment CreateObject(int PosX, int PosY)
        {
            Random rand = new Random();
            int type = rand.Next(1, 3+1);

            AbsEquipment equipment;

            switch (type)
            {
                default:
                    equipment = null;
                    break;
                case 1:
                    equipment = new Axe(PosX, PosY);
                    break;
                case 2:
                    equipment = new WoodenShield(PosX, PosY);
                    break;
                case 3:
                    equipment = new Wand(PosX, PosY);
                    break;
            }

            return equipment;
        }

    }
}
