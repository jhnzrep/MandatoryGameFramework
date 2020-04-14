namespace MandatoryGameFrameWork
{
    public class Axe : AbsEquipment
    {
        public Axe()
        {
            AttackStat = 1;
            DefenseStat = 0;
            Slot = 0;
        }

        public Axe(int posX, int posY)
        {
            AttackStat = 1;
            DefenseStat = 0;
            Slot = 0;

            PosX = posX;
            PosY = posY;
        }

        public override string ToString()
        {
            return "Item type: Equipment | Slot: 0 | Item name : Axe";
        }
    }
}
