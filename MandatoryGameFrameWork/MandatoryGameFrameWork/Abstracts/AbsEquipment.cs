using System.Threading;

namespace MandatoryGame
{
    abstract class Equipment : iGameObject
    {

        protected static int id = 0;
        protected static Mutex idMutex = new Mutex();

        public int Id { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }

        public int AttackStat { get; set; }
        public int DefenseStat { get; set; }
        public int Slot { get; set; }
    }
}
