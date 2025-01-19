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