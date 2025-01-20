// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;
using GameEngine.Factories;
using GameEngineTests.Builders;

namespace GameEngineTests;

[TestClass]
public class CharacterFactoryTests
{
    private readonly CharacterSheetBuilder _characterSheetBuilder;
    private readonly CreatureFactory _creatureFactory;
    private readonly EquipmentBuilder _equipmentBuilder;
    private readonly ItemBuilder _itemBuilder;
    private readonly PlayerFactory _playerFactory;

    public CharacterFactoryTests()
    {
        _characterSheetBuilder = new CharacterSheetBuilder();
        _creatureFactory = new CreatureFactory();
        _playerFactory = new PlayerFactory();
        _equipmentBuilder = new EquipmentBuilder();
        _itemBuilder = new ItemBuilder();
    }

    [TestMethod]
    public void Create_CreatureCreationSheet_CreatesCreature()
    {
        // Arrange
        var creatureSheet = _characterSheetBuilder.BuildCreatureSheet();

        // Act
        var creature = _creatureFactory.Create(creatureSheet);

        // Assert
        Assert.IsInstanceOfType(creature, typeof(Creature));

        Assert.AreEqual(creatureSheet.Name, creature.Name);

        Assert.AreEqual(creatureSheet.ExperiencePoints, creature.ExperiencePoints);
        Assert.AreEqual(creatureSheet.LootAmount, creature.LootAmount);
        Assert.AreEqual(creatureSheet.Level, creature.Level);

        Assert.AreEqual(creatureSheet.Armor, creature.Stats.Armor);
        Assert.AreEqual(creatureSheet.Dexterity, creature.Stats.Dexterity);
        Assert.AreEqual(creatureSheet.Health, creature.Stats.Health);
        Assert.AreEqual(creatureSheet.Intelligence, creature.Stats.Intelligence);
        Assert.AreEqual(creatureSheet.Strength, creature.Stats.Strength);

        Assert.AreEqual(creatureSheet.MaxInventorySlots, creature.Inventory!.MaxSlots);
    }

    [TestMethod]
    public void Create_PlayerCreationSheet_CreatesPlayer()
    {
        // Arrange
        var playerSheet = _characterSheetBuilder.BuildPlayerSheet();

        // Act
        var player = _playerFactory.Create(playerSheet);

        // Assert
        Assert.IsInstanceOfType(player, typeof(Player));

        Assert.AreEqual(playerSheet.Name, player.Name);

        Assert.AreEqual(playerSheet.Currency, player.Currency);

        Assert.AreEqual(playerSheet.Armor, player.Stats.Armor);
        Assert.AreEqual(playerSheet.Dexterity, player.Stats.Dexterity);
        Assert.AreEqual(playerSheet.Health, player.Stats.Health);
        Assert.AreEqual(playerSheet.Intelligence, player.Stats.Intelligence);
        Assert.AreEqual(playerSheet.Strength, player.Stats.Strength);

        Assert.AreEqual(playerSheet.MaxInventorySlots, player.Inventory!.MaxSlots);
    }

    [TestMethod]
    public void Create_WithEquipment_CreatesEquipped()
    {
        // Arrange
        var playerSheet = _characterSheetBuilder.BuildPlayerSheet();

        var armor = _equipmentBuilder.BuildArmor();
        var weapon = _equipmentBuilder.BuildWeapon();

        playerSheet.Equipment.Add(armor);
        playerSheet.Equipment.Add(weapon);

        // Act
        var player = _playerFactory.Create(playerSheet);

        var equippedArmor = player.Equipped!.GetArmor();
        var equippedWeapon = player.Equipped!.GetWeapons();

        // Assert
        Assert.AreEqual(expected: 1, equippedArmor.Count);
        Assert.AreEqual(expected: 1, equippedWeapon.Count);

        Assert.AreEqual(armor, equippedArmor[0]);
        Assert.AreEqual(weapon, equippedWeapon[0]);
    }

    [TestMethod]
    public void Create_WithItems_CreatesInventory()
    {
        // Arrange
        var playerSheet = _characterSheetBuilder.BuildPlayerSheet();

        var potion = _itemBuilder.BuildPotion();

        playerSheet.Items.Add((potion));

        // Act
        var player = _playerFactory.Create(playerSheet);

        var inventory = player.Inventory!.GetInventory();

        // Assert
        Assert.AreEqual(playerSheet.MaxInventorySlots, inventory.Count);
        Assert.AreEqual(potion, inventory[0].Item);
    }

    [TestMethod]
    public void Create_WithItems_CreatesInventoryWithMultipleItems()
    {
        // Arrange
        var playerSheet = _characterSheetBuilder.BuildPlayerSheet();

        var potion = _itemBuilder.WithQuantity(10).BuildPotion();
        var weapon = _equipmentBuilder.BuildWeapon();
        var armor = _equipmentBuilder.BuildArmor();

        playerSheet.Items.Add((potion));
        playerSheet.Items.Add((weapon));
        playerSheet.Items.Add((armor));

        // Act
        var player = _playerFactory.Create(playerSheet);

        var inventory = player.Inventory!.GetInventory();

        // Assert
        Assert.AreEqual(playerSheet.MaxInventorySlots, inventory.Count);
        Assert.AreEqual(potion, inventory[0].Item);
        Assert.AreEqual(expected: 10, inventory[0].Quantity);
        Assert.AreEqual(weapon, inventory[1].Item);
        Assert.AreEqual(armor, inventory[2].Item);
    }
}