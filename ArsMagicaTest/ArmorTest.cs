using ArsMagica;
using Microsoft.VisualStudio.TestPlatform.Common.DataCollection;

namespace ArsMagicaTest;

[TestClass]
public class ArmorTest
{
    [TestMethod]
    public void TestArmorDurability()
    {
        Armor IronChestPlate = new Armor();

        int Durability = IronChestPlate.Durability;

        Durability -= 10; // 10 point of damage 

        if (IronChestPlate.Durability != Durability)
        {
            Assert.Fail("The armor did not take any damage");
        }
        

    }
}