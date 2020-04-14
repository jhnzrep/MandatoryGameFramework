using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandatoryGameFrameWork;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            World world = new World(100, 100);
            world.Player = new Player(1, 1);
            world.Player.Equip(new EnchantedWeapon(new Axe()));

            Assert.AreEqual(1, world.Player.Gear[0].AttackStat);
        }
    }
}
