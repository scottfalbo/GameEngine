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
    private Potion _potion;
    private Weapon _weapon;

    public InventoryTests()
    {
        _maxSlots = 10;

        _inventory = new(_maxSlots);
        _potionFactory = new();
        _weaponFactory = new();

        _potion = _potionFactory.Create("Test Potion");
        _weapon = _weaponFactory.Create("Test Sword", 10);
    }

    [TestMethod]
    public void AddItem_AddsItemToInventorySlot()
    {
        // Arrange
        var quantity = 1;
        var slot = 0;

        // Act
        var result = _inventory.AddItem(slot, _potion, quantity);

        // Assert
        var inventorySlots = _inventory.GetInventory();

        Assert.IsTrue(result);
        Assert.AreEqual(expected: 1, inventorySlots[slot].Quantity);
        Assert.AreEqual(_potion, inventorySlots[slot].Item);
    }

    [TestMethod]
    public void AddItem_ReturnsFalse_WhenSlotIsOccupied()
    {
        // Arrange
        var quantity = 1;
        var slot = 0;

        _inventory.AddItem(slot, _potion, quantity);

        // Act
        var result = _inventory.AddItem(slot, _weapon, quantity);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void AddItem_ReturnsFalse_WhenSlotIsOutOfRange()
    {
        // Arrange
        var quantity = 1;
        var slot = _maxSlots + 1;

        // Act
        var result = _inventory.AddItem(slot, _potion, quantity);

        // Assert
        Assert.IsFalse(result);
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

    [TestMethod]
    public void DecreaseMaxSlots_DecreasesMaxSlots()
    {
        // Arrange
        var amount = 2;
        var expectedSlots = _maxSlots - amount;

        // Act
        _inventory.DecreaseMaxSlots(amount);

        // Assert
        Assert.AreEqual(expectedSlots, _inventory.MaxSlots);
    }

    [TestMethod]
    public void DecreaseMaxSlots_RemovesSlots()
    {
        // Arrange
        var amount = 2;
        var expectedSlots = _maxSlots - amount;

        // Act
        _inventory.DecreaseMaxSlots(amount);

        // Assert
        var inventorySlots = _inventory.GetInventory();

        Assert.AreEqual(expectedSlots, inventorySlots.Count);
    }

    [TestMethod]
    public void DecreaseQuantity_QuantityZero_RemovesItem()
    {
        // Arrange
        var quantity = 2;
        var slot = 0;

        _inventory.AddItem(slot, _potion, quantity);

        // Act
        _inventory.DecreaseQuantity(slot, quantity);

        // Assert
        var inventorySlots = _inventory.GetInventory();

        Assert.AreEqual(expected: 0, inventorySlots[slot].Quantity);
        Assert.IsNull(inventorySlots[slot].Item);
    }

    [TestMethod]
    public void DecreaseQuantity_RemovesQuantity()
    {
        // Arrange
        var quantity = 2;
        var slot = 0;

        _inventory.AddItem(slot, _potion, quantity);

        // Act
        _inventory.DecreaseQuantity(slot, 1);

        // Assert
        var inventorySlots = _inventory.GetInventory();

        Assert.AreEqual(expected: 1, inventorySlots[slot].Quantity);
    }

    [TestMethod]
    public void IncreaseMaxSlots_AddsSlots()
    {
        // Arrange
        var amount = 2;
        var expectedSlots = _maxSlots + amount;

        // Act
        _inventory.IncreaseMaxSlots(amount);

        // Assert
        var inventorySlots = _inventory.GetInventory();

        Assert.AreEqual(expectedSlots, inventorySlots.Count);
    }

    [TestMethod]
    public void IncreaseMaxSlots_IncreasesMaxSlots()
    {
        // Arrange
        var amount = 2;
        var expectedSlots = _maxSlots + amount;

        // Act
        _inventory.IncreaseMaxSlots(amount);

        // Assert
        Assert.AreEqual(expectedSlots, _inventory.MaxSlots);
    }

    [TestMethod]
    public void IncreaseQuantity_AddsQuantity()
    {
        // Arrange
        var quantity = 1;
        var slot = 0;

        _inventory.AddItem(slot, _potion, quantity);

        // Act
        var result = _inventory.IncreaseQuantity(slot, quantity);

        // Assert
        var inventorySlots = _inventory.GetInventory();

        Assert.IsTrue(result);
        Assert.AreEqual(expected: 2, inventorySlots[slot].Quantity);
    }

    [TestMethod]
    public void IncreaseQuantity_ReturnsFalse_WhenItemIsNotStackable()
    {
        // Arrange
        var quantity = 1;
        var slot = 0;

        _inventory.AddItem(slot, _weapon, quantity);

        // Act
        var result = _inventory.IncreaseQuantity(slot, quantity);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void MoveItem_MovesItem()
    {
        // Arrange
        var quantity = 1;
        var sourceSlot = 0;
        var targetSlot = 1;

        _inventory.AddItem(sourceSlot, _potion, quantity);

        // Act
        var result = _inventory.MoveItem(sourceSlot, targetSlot);

        // Assert
        var inventorySlots = _inventory.GetInventory();

        Assert.IsTrue(result);

        Assert.AreEqual(expected: 0, inventorySlots[sourceSlot].Quantity);
        Assert.IsNull(inventorySlots[sourceSlot].Item);

        Assert.AreEqual(expected: 1, inventorySlots[targetSlot].Quantity);
        Assert.AreEqual(_potion, inventorySlots[targetSlot].Item);
    }

    [TestMethod]
    public void RemoveItem_RemovesItem()
    {
        // Arrange
        var quantity = 1;
        var slot = 0;

        _inventory.AddItem(slot, _potion, quantity);

        // Act
        _inventory.RemoveItem(slot);

        // Assert
        var inventorySlots = _inventory.GetInventory();

        Assert.AreEqual(expected: 0, inventorySlots[slot].Quantity);
        Assert.IsNull(inventorySlots[slot].Item);
    }

    [TestMethod]
    public void RemoveItem_ReturnsFalse_WhenSlotIsOutOfRange()
    {
        // Arrange
        var slot = _maxSlots + 1;

        // Act
        var result = _inventory.RemoveItem(slot);

        // Assert
        Assert.IsFalse(result);
    }
}