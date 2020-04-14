using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryGameFrameWork
{
    public class AbsEquipmentDecorator : AbsEquipment
    {
        protected AbsEquipment baseEquipment;

        public AbsEquipmentDecorator(AbsEquipment Equipbase)
        {
            baseEquipment = Equipbase;
        }
    }
}
