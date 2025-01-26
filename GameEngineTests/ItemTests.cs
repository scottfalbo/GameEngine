// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Compendium.Items;
using GameEngineTests.Builders;

namespace GameEngineTests;

[TestClass]
public class ItemTests
{
    [TestMethod]
    public void Clone_Item_ReturnsItem()
    {
        // Arrange
        var item = new ItemBuilder().BuildPotion();

        // Act
        var clone = item.Clone();

        // Assert
        Assert.IsInstanceOfType(clone, typeof(Item));
        Assert.IsInstanceOfType(clone, typeof(Potion));

        Assert.AreEqual(item.Name, clone.Name);
        Assert.AreEqual(item.Quantity, clone.Quantity);
        Assert.AreEqual(item.VendorBuyPrice, clone.VendorBuyPrice);
        Assert.AreEqual(item.VendorSellPrice, clone.VendorSellPrice);
        Assert.AreEqual(item.IsStackable, clone.IsStackable);
        Assert.AreEqual(item.FlavorText, clone.FlavorText);
        Assert.AreEqual(item.ItemType, clone.ItemType);

        Assert.AreNotEqual(item.Id, clone.Id);
    }
}