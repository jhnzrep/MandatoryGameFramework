namespace MandatoryGameFrameWork
{
    class WoodenShield : AbsEquipment
    {
        public WoodenShield()
        {
            AttackStat = 0;
            DefenseStat = 2;
            Slot = 1;
        }

        public WoodenShield(int posX, int posY)
        {
            AttackStat = 0;
            DefenseStat = 2;
            Slot = 1;

            PosX = posX;
            PosY = posY;
        }

        public override string ToString()
        {
            return "Item type: Equipment | Slot: 1 | Item name : Wooden Shield";
        }
    }
}
