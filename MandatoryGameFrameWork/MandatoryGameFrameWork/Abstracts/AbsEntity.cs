﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MandatoryGame
{
    class Entity: iGameObject
    {
        protected static int id = 0;
        protected static Mutex idMutex = new Mutex();

        public int Id { get; set; }
        public int Hp { get; set; }

        public int PosX { get; set; }
        public int PosY { get; set; }

        public int AttackStat { get; set; }
        public int DefenseStat { get; set; }

        private Equipment[] Gear;
        public List<iGameObject> Inventory { get; set; }


        public void Equip(Equipment obj)
        {
            if (Gear[obj.Slot] != null) throw new Exception("Weapon slot you are trying to use is full!");
            Gear[obj.Slot] = obj;
            AttackStat += obj.AttackStat;
            DefenseStat += obj.DefenseStat;
        }

        public void Hit(Entity enemy)
        {
            var statDif = AttackStat - enemy.DefenseStat;
            Random rand = new Random();

            var hit = rand.Next(0, 10 + statDif);

            enemy.ChangeHP(hit);
        }

        public void ChangeHP(int number)
        {
            Hp += number;
        }
    }
}