using System;

namespace MandatoryGameFrameWork
{
    class Combat
    {
        public static void Fight(AbsEntity firstEnt, AbsEntity secondEnt)
        {
            if (firstEnt.EntityState == State.InCombat || secondEnt.EntityState == State.InCombat) throw new Exception("One of the entities is already in combat!");
            if (firstEnt.EntityState == State.Dead || secondEnt.EntityState == State.Dead) throw new Exception("One of the entities is already dead.");
            if (Distance.IsCloseEnough(firstEnt, secondEnt, 2)) throw new Exception("Entities are too far from each other to combat!");

            //Fights are to the DEATH!
            while(firstEnt.EntityState == State.Alive && secondEnt.EntityState == State.Alive)
            {
                firstEnt.Hit(secondEnt);
                secondEnt.Hit(firstEnt);
            }
        }
    }
}
