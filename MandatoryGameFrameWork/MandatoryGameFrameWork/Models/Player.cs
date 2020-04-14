using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryGameFrameWork
{
    public class Player : AbsEntity
    {
        public const int MAX_PLAYER_HP = 30;

        public Player(int posX, int posY)
        {
            idMutex.WaitOne();
            id++;
            Id = id;
            idMutex.ReleaseMutex();

            Hp = MAX_PLAYER_HP;
            Gear = new AbsEquipment[6];
            Inventory = new List<AbsItem>();

            PosX = posX;
            PosY = posY;

            EntityState = State.Alive;
        }

        public void Eat(AbsFood food)
        {
            Hp = Hp + food.HpValue;
            if (Hp > MAX_PLAYER_HP) Hp = MAX_PLAYER_HP;
        }
    }
}
