using ArsMagica;
namespace ArsMagicaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AttackingTest()
        {
            Player testPlayer = new Player();
            Player enemy = new Player();
            Weapon weapon = new Weapon(10);
            testPlayer.EquipWeapon(weapon);

            int enemyHealth = enemy.health;

            testPlayer.Attack(enemy);
            
            Assert.AreNotEqual(enemyHealth, enemy.health);
        }
    }
}