namespace MandatoryGameFrameWork
{ 
    class Troll : AbsEntity
    {
        public Troll(int posX, int posY)
        {
            idMutex.WaitOne();
            id++;
            Id = id;
            idMutex.ReleaseMutex();

            PosX = posX;
            PosY = posY;

            Hp = 15;
            Gear = new AbsEquipment[1];
            Equip(new Axe());
            Equip(new WoodenShield());

            EntityState = State.Alive;
        }

        public override string ToString()
        {
            return $"Entity type: NPC | Hp: {Hp} | Entity name: Troll";
        }
    }
}
