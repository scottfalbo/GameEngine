// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Mechanics.Shops;
using GameEngineTests.Builders;

namespace GameEngineTests;

[TestClass]
public class ShopTests
{
    private readonly EquipmentBuilder _equipmentBuilder;
    private readonly ItemBuilder _itemBuilder;
    private readonly Shop _shop;

    public ShopTests()
    {
        _equipmentBuilder = new EquipmentBuilder();
        _itemBuilder = new ItemBuilder();
        _shop = new Shop("Test Shop");
    }

    [TestMethod]
    public void AddItem_AddEquipment_AddsItemsAndEquipmentToShop()
    {
        // Arrange
        var item1 = _itemBuilder.WithName("Test Potion 1").BuildPotion();
        var item2 = _itemBuilder.WithName("Test Potion 2").BuildPotion();
        var weapon1 = _equipmentBuilder.WithName("Test Weapon 1").BuildWeapon();
        var weapon2 = _equipmentBuilder.WithName("Test Weapon 2").BuildWeapon();
        var armor1 = _equipmentBuilder.WithName("Test Armor 1").BuildArmor();
        var armor2 = _equipmentBuilder.WithName("Test Armor 2").BuildArmor();
    }

    [TestMethod]
    public void Constructor_CreatesEmptyShop()
    {
        // Arrange
        var shopSlots = _shop.GetSlots();

        // Assert
        Assert.AreEqual("Test Shop", _shop.Name);
        Assert.AreEqual(0, shopSlots.Count);
        Assert.AreEqual(1, _shop.MarkupPercentage);
    }

    [TestMethod]
    public void SetMarkupPercentage_AssignsMarkupPercentage()
    {
        // Arrange
        var markupPercentage = 1.5m;

        // Act
        _shop.SetMarkupPercentage(markupPercentage);

        // Assert
        Assert.AreEqual(markupPercentage, _shop.MarkupPercentage);
    }
}