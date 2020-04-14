namespace MandatoryGameFrameWork
{
    class Wand : AbsEquipment
    {
        public Wand()
        {
            AttackStat = 2;
            DefenseStat = -1;
            Slot = 0;
        }

        public Wand(int posX, int posY)
        {
            AttackStat = 1;
            DefenseStat = 0;
            Slot = 0;

            PosX = posX;
            PosY = posY;
        }

        public override string ToString()
        {
            return "Item type: Equipment | Slot: 0 | Item name : Wand";
        }
    }
}
