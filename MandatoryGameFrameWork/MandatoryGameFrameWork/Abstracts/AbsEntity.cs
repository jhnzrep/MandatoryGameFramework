using System;
using System.Collections.Generic;
using System.Threading;

namespace MandatoryGameFrameWork
{
    public abstract class AbsEntity: iEntity
    {
        protected static int id = 0;
        protected static Mutex idMutex = new Mutex();

        public int Id { get; set; }
        public int Hp { get; set; }

        public State EntityState { get; set; }

        public int PosX { get; set; }
        public int PosY { get; set; }

        public int AttackStat { get; set; }
        public int DefenseStat { get; set; }

        public AbsEquipment[] Gear;
        public List<AbsItem> Inventory { get; set; }

        public void Equip(AbsEquipment obj)
        {
            if (Gear[obj.Slot] != null) throw new Exception("Weapon slot you are trying to use is full!");
            Gear[obj.Slot] = obj;
            AttackStat += obj.AttackStat;
            DefenseStat += obj.DefenseStat;
        }

        public void DeEquip(AbsEquipment obj)
        {
            if (Gear[obj.Slot] == null) throw new Exception("Weapon slot you are trying to remove weapon from is empty!");
            AttackStat -= obj.AttackStat;
            DefenseStat -= obj.DefenseStat;
            Gear[obj.Slot] = null;
        }

        public virtual void Hit(AbsEntity enemy)
        {
            var statDif = AttackStat - enemy.DefenseStat;
            Random rand = new Random();

            var hit = rand.Next(0, 10 + statDif);

            enemy.ChangeHP(hit);
        }

        public void ChangeHP(int number)
        {
            Hp += number;
            if (Hp < 1) EntityState = State.Dead;
        }

        public void PickUpItem(AbsItem item)
        {
            if (!Distance.IsCloseEnough(this, item, 3)) throw new Exception("Item is too far!");
            if (Inventory.Count < 30) throw new Exception("Inventory is full!");

            Inventory.Add(item);
        }
    }
}
