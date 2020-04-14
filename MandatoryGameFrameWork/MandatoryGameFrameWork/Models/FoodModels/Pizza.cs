namespace MandatoryGameFrameWork
{
    class Pizza : AbsFood
    {
        public Pizza()
        {
            HpValue = 5;
        }

        public Pizza(int posX, int posY)
        {
            HpValue = 7;
            PosX = posX;
            PosY = posY;
        }

        public override string ToString()
        {
            return $"Item type: Food | Hp value: {HpValue} | Item name : Pizza";
        }
    }
}
