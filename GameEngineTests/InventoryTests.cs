// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Containers;
using GameEngine.Compendium.Equipables;
using GameEngine.Compendium.Items;
using GameEngineTests.Builders;

namespace GameEngineTests;

[TestClass]
public class InventoryTests
{
    private readonly Inventory _inventory;

    private int _maxSlots;
    private Potion _potion;
    private Weapon _weapon;

    public InventoryTests()
    {
        _maxSlots = 10;

        _inventory = new(_maxSlots);

        _potion = new ItemBuilder().WithIsStackable(true).BuildPotion();
        _weapon = new EquipmentBuilder().BuildWeapon();
    }

    [TestMethod]
    public void AddItem_AddsItemToInventorySlot()
    {
        // Arrange
        var slot = 0;

        // Act
        var result = _inventory.AddItem(slot, _potion);

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
        var slot = 0;

        _inventory.AddItem(slot, _potion);

        // Act
        var result = _inventory.AddItem(slot, _weapon);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void AddItem_ReturnsFalse_WhenSlotIsOutOfRange()
    {
        // Arrange
        var slot = _maxSlots + 1;

        // Act
        var result = _inventory.AddItem(slot, _potion);

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
        _potion.SetQuantity(quantity);
        var slot = 0;

        _inventory.AddItem(slot, _potion);

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
        _potion.SetQuantity(quantity);
        var slot = 0;

        _inventory.AddItem(slot, _potion);

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

        _inventory.AddItem(slot, _potion);

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

        _inventory.AddItem(slot, _weapon);

        // Act
        var result = _inventory.IncreaseQuantity(slot, quantity);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void MoveItem_MovesItemToNewSlot()
    {
        // Arrange
        var slot = 0;
        var newSlot = 1;

        _inventory.AddItem(slot, _potion);

        // Act
        var result = _inventory.MoveItem(slot, newSlot);

        // Assert
        var inventorySlots = _inventory.GetInventory();

        Assert.IsTrue(result);

        Assert.AreEqual(expected: 0, inventorySlots[slot].Quantity);
        Assert.IsNull(inventorySlots[slot].Item);

        Assert.AreEqual(expected: 1, inventorySlots[newSlot].Quantity);
        Assert.AreEqual(_potion, inventorySlots[newSlot].Item);
    }

    [TestMethod]
    public void MoveItem_ReturnsFalse_WhenSourceSlotIsOutOfRange()
    {
        // Arrange
        var slot = _maxSlots + 1;
        var newSlot = 0;

        // Act
        var result = _inventory.MoveItem(slot, newSlot);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void MoveItem_ReturnsFalse_WhenTargetSlotIsOutOfRange()
    {
        // Arrange
        var slot = 0;
        var newSlot = _maxSlots + 1;

        // Act
        var result = _inventory.MoveItem(slot, newSlot);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void MoveItem_SwapsItemsIfTargetIsOccupied()
    {
        // Arrange
        var slot = 0;
        var newSlot = 1;

        _inventory.AddItem(slot, _potion);
        _inventory.AddItem(newSlot, _weapon);

        // Act
        var result = _inventory.MoveItem(slot, newSlot);

        // Assert
        var inventorySlots = _inventory.GetInventory();

        Assert.IsTrue(result);
        Assert.AreEqual(expected: 1, inventorySlots[slot].Quantity);
        Assert.AreEqual(_weapon, inventorySlots[slot].Item);

        Assert.AreEqual(expected: 1, inventorySlots[newSlot].Quantity);
        Assert.AreEqual(_potion, inventorySlots[newSlot].Item);
    }

    [TestMethod]
    public void RemoveItem_RemovesItem()
    {
        // Arrange
        var slot = 0;

        _inventory.AddItem(slot, _potion);

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