// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;
using GameEngine.Factories;

namespace GameEngineTests;

[TestClass]
public class InventoryTests
{
    private readonly Inventory _inventory;
    private readonly PotionFactory _potionFactory;
    private readonly WeaponFactory _weaponFactory;

    private int _maxSlots;

    public InventoryTests()
    {
        _maxSlots = 10;

        _inventory = new(_maxSlots);
        _potionFactory = new();
        _weaponFactory = new();
    }

    [TestMethod]
    public void AddItem_AddsItemToInventorySlot()
    {
        // Arrange
        var potion = _potionFactory.Create("Health Potion");
        var quantity = 1;
        var slot = 0;

        // Act
        _inventory.AddItem(slot, potion, quantity);

        // Assert
        var inventorySlots = _inventory.GetInventory();

        Assert.AreEqual(expected: 1, inventorySlots[slot].Quantity);
        Assert.AreEqual(potion, inventorySlots[slot].Item);
    }

    [TestMethod]
    public void Constructor_InstantiatesInventoryWithSlots()
    {
        // Arrange
        var inventorySlots = _inventory.GetInventory();

        // Assert
        Assert.AreEqual(_maxSlots, _inventory.MaxSlots);

        foreach (var slot in inventorySlots)
        {
            Assert.AreEqual(expected: 0, slot.Value.Quantity);
            Assert.IsNull(slot.Value.Item);
        }
    }
}