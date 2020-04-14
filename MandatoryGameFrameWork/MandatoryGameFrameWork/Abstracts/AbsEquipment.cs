namespace MandatoryGameFrameWork
{
    public abstract class AbsEquipment : AbsItem
    { 
        public int AttackStat { get; set; }
        public int DefenseStat { get; set; }
        public int Slot { get; set; }
    }
}
