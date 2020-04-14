namespace MandatoryGameFrameWork
{
    class Kebab : AbsFood
    {
        public Kebab()
        {
            HpValue = 7;
        }

        public Kebab(int posX, int posY)
        {
            HpValue = 7;
            PosX = posX;
            PosY = posY;
        }

        public override string ToString()
        {
            return $"Item type: Food | Hp value: {HpValue} | Item name : Kebab";
        }
    }
}
