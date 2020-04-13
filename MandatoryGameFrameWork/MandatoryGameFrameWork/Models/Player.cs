using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryGame.Models
{
    class Player : Entity
    {
        public Player()
        {
            id
            this.hp = hp;
            gear = new Equipment[7];
            inventory = new List<iGameObject>();
        }

        public void Equip(Equipment obj)
        {
            if (gear[obj.Slot] != null) throw new Exception("Weapon slot you are trying to use is full!");
            gear[obj.Slot] = obj;
            attackStat += obj.AttackStat;
            defenseStat += obj.DefenseStat;
        }

        public void Hit(Entity enemy)
        {
            var statDif = AttackStat - enemy.defenseStat;
            Random rand = new Random();

            var hit = rand.Next(0, 10 + statDif);

            enemy.ChangeHP(hit);
        }

        public void ChangeHP(int number)
        {
            hp += number;
        }
    }
}
