using ArsMagica;

namespace ArsMagicaTest;

[TestClass]
public class Game
{
    [TestMethod]
    public void FindPlayerFromSearchFunction(string name, List<Player> players)
    {
        var player_name = players.Find(player => player.name() == name);
        
        if(player_name != null)
        {
            Assert.IsTrue(true);
        }
        else
        {
            Assert.IsTrue(false);
        }

}