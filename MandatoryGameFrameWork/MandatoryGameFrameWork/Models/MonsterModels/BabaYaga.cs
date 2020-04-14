namespace MandatoryGameFrameWork
{
    class BabaYaga : AbsEntity
    {
        public BabaYaga(int posX, int posY)
        {
            idMutex.WaitOne();
            id++;
            Id = id;
            idMutex.ReleaseMutex();

            PosX = posX;
            PosY = posY;

            Hp = 20;
            Gear = new AbsEquipment[1];
            Equip(new Wand());

            EntityState = State.Alive;
        }

        public override string ToString()
        {
            return $"Entity type: NPC | Hp: {Hp} | Entity name: BabaYaga";
        }
    }
}

