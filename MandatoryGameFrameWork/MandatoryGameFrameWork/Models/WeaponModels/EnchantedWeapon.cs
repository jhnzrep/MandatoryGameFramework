using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryGameFrameWork
{
    public class EnchantedWeapon : AbsEquipmentDecorator
    {
        public EnchantedWeapon(AbsEquipment Equipbase) : base(Equipbase)
        {
            AttackStat = baseEquipment.AttackStat + 2;
        }

        public override string ToString()
        {
            return $"Item type: Equipment | Slot: 0 | Item name : Enchanted {baseEquipment.GetType().ToString()}";
        }
    }
}
