using ArsMagica;
namespace ArsMagicaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void attacking_test()
        {
            Player testplayer = new Player();
            Player enemy = new Player();

            int enemy_healt = enemy.health;

            testplayer.attack(weapon, enemy);
            
            Assert.AreNotEqual(enemy_healt, enemy.health);
        }
    }
}