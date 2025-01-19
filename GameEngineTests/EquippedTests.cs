// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;

namespace GameEngineTests;

[TestClass]
public class EquippedTests
{
    private readonly Equipped _equipped;

    private Armor _armor;
    private int _armorSlots;
    private Weapon _weapon;
    private int _weaponSlots;

    public EquippedTests()
    {
        _armor = new Armor("Test Armor", 10);
        _armorSlots = 1;

        _weapon = new Weapon("Test Weapon", 10);
        _weaponSlots = 1;

        _equipped = new Equipped(_armorSlots, _weaponSlots);
    }

    [TestMethod]
    public void Constructor()
    {
        // Arrange
        var armorSlots = _equipped.GetArmor();
        var weaponSlots = _equipped.GetWeapons();

        // Assert
        Assert.AreEqual(_armorSlots, armorSlots.Count);
        Assert.AreEqual(_weaponSlots, weaponSlots.Count);
    }

    [TestMethod]
    public void DecreaseArmorSlots_RemovesArmorSlots()
    {
        // Arrange
        var amount = 1;

        // Act
        _equipped.DecreaseArmorSlots(amount);

        // Assert
        var armorSlots = _equipped.GetArmor();

        Assert.AreEqual(0, armorSlots.Count);
    }

    [TestMethod]
    public void DecreaseWeaponSlots_RemovesWeaponSlots()
    {
        // Arrange
        var amount = 1;

        // Act
        _equipped.DecreaseWeaponSlots(amount);

        // Assert
        var weaponSlots = _equipped.GetWeapons();

        Assert.AreEqual(0, weaponSlots.Count);
    }

    [TestMethod]
    public void EquipArmor_AddsArmorToSlot()
    {
        // Arrange
        var slot = 0;

        // Act
        var result = _equipped.EquipArmor(slot, _armor);

        // Assert
        var armorSlots = _equipped.GetArmor();

        Assert.IsTrue(result);
        Assert.AreEqual(_armor, armorSlots[slot]);
    }

    [TestMethod]
    public void EquipArmor_ReturnsFalse_WhenSlotIsOutOfRange()
    {
        // Arrange
        var slot = 2;

        // Act
        var result = _equipped.EquipArmor(slot, _armor);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void EquipWeapon_AddsWeaponToSlot()
    {
        // Arrange
        var slot = 0;

        // Act
        var result = _equipped.EquipWeapon(slot, _weapon);

        // Assert
        var weaponSlots = _equipped.GetWeapons();

        Assert.IsTrue(result);
        Assert.AreEqual(_weapon, weaponSlots[slot]);
    }

    [TestMethod]
    public void EquipWeapon_ReturnsFalse_WhenSlotIsOutOfRange()
    {
        // Arrange
        var slot = 2;

        // Act
        var result = _equipped.EquipWeapon(slot, _weapon);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IncreaseArmorSlots_AddsArmorSlots()
    {
        // Arrange
        var amount = 1;
        var expectedSlots = _armorSlots + amount;

        // Act
        _equipped.IncreaseArmorSlots(amount);

        // Assert
        var armorSlots = _equipped.GetArmor();

        Assert.AreEqual(expectedSlots, armorSlots.Count);
    }

    [TestMethod]
    public void IncreaseWeaponSlots_AddsWeaponSlots()
    {
        // Arrange
        var amount = 1;
        var expectedSlots = _weaponSlots + amount;

        // Act
        _equipped.IncreaseWeaponSlots(amount);

        // Assert
        var weaponSlots = _equipped.GetWeapons();

        Assert.AreEqual(expectedSlots, weaponSlots.Count);
    }

    [TestMethod]
    public void UnequipArmor_RemovesArmorFromSlot()
    {
        // Arrange
        var slot = 0;
        _equipped.EquipArmor(slot, _armor);

        // Act
        _equipped.UnequipArmor(slot);

        // Assert
        var armorSlots = _equipped.GetArmor();

        Assert.IsNull(armorSlots[slot]);
    }

    [TestMethod]
    public void UnequipWeapon_RemovesWeaponFromSlot()
    {
        // Arrange
        var slot = 0;
        _equipped.EquipWeapon(slot, _weapon);

        // Act
        _equipped.UnequipWeapon(slot);

        // Assert
        var weaponSlots = _equipped.GetWeapons();

        Assert.IsNull(weaponSlots[slot]);
    }
}