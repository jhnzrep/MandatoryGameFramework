namespace MandatoryGameFrameWork
{
    class Distance
    {
        public static bool IsCloseEnough(AbsEntity firstEnt, AbsEntity secondEnt, int maxDistance)
        {
            if((firstEnt.PosX - secondEnt.PosX) * (firstEnt.PosX - secondEnt.PosX) + (firstEnt.PosY - secondEnt.PosY) * (firstEnt.PosY - secondEnt.PosY) <= maxDistance*maxDistance)
            {
                return true;
            }
            return false;
        }

        public static bool IsCloseEnough(AbsEntity firstEnt, AbsItem secondEnt, int maxDistance)
        {
            if ((firstEnt.PosX - secondEnt.PosX) * (firstEnt.PosX - secondEnt.PosX) + (firstEnt.PosY - secondEnt.PosY) * (firstEnt.PosY - secondEnt.PosY) <= maxDistance * maxDistance)
            {
                return true;
            }
            return false;
        }
    }
}
