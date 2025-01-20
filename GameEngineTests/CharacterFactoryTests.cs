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
    private readonly CharacterFactory _characterFactory;
    private readonly CharacterCreationSheetBuilder _characterSheetBuilder;
    private readonly EquipmentBuilder _equipmentBuilder;
    private readonly ItemBuilder _itemBuilder;

    public CharacterFactoryTests()
    {
        _characterSheetBuilder = new CharacterCreationSheetBuilder();
        _characterFactory = new CharacterFactory();
        _equipmentBuilder = new EquipmentBuilder();
        _itemBuilder = new ItemBuilder();
    }

    [TestMethod]
    public void Create_CreatureCreationSheet_CreatesCreature()
    {
        // Arrange
        var creatureCreatureSheet = _characterSheetBuilder.BuildCreatureCreationSheet();

        // Act
        var creature = _characterFactory.Create(creatureCreatureSheet);

        // Assert
        Assert.IsInstanceOfType(creature, typeof(Creature));

        Assert.AreEqual(creatureCreatureSheet.Name, creature.Name);

        Assert.AreEqual(creatureCreatureSheet.ExperiencePoints, creature.ExperiencePoints);
        Assert.AreEqual(creatureCreatureSheet.LootAmount, creature.LootAmount);
        Assert.AreEqual(creatureCreatureSheet.Level, creature.Level);

        Assert.AreEqual(creatureCreatureSheet.Armor, creature.Stats.Armor);
        Assert.AreEqual(creatureCreatureSheet.Dexterity, creature.Stats.Dexterity);
        Assert.AreEqual(creatureCreatureSheet.Health, creature.Stats.Health);
        Assert.AreEqual(creatureCreatureSheet.Intelligence, creature.Stats.Intelligence);
        Assert.AreEqual(creatureCreatureSheet.Strength, creature.Stats.Strength);

        Assert.AreEqual(creatureCreatureSheet.MaxInventorySlots, creature.Inventory!.MaxSlots);
    }

    [TestMethod]
    public void Create_PlayerCreationSheet_CreatesPlayer()
    {
        // Arrange
        var playerCreationSheet = _characterSheetBuilder.BuildPlayerCreationSheet();

        // Act
        var player = _characterFactory.Create(playerCreationSheet);

        // Assert
        Assert.IsInstanceOfType(player, typeof(Player));

        Assert.AreEqual(playerCreationSheet.Name, player.Name);

        Assert.AreEqual(playerCreationSheet.Currency, player.Currency);

        Assert.AreEqual(playerCreationSheet.Armor, player.Stats.Armor);
        Assert.AreEqual(playerCreationSheet.Dexterity, player.Stats.Dexterity);
        Assert.AreEqual(playerCreationSheet.Health, player.Stats.Health);
        Assert.AreEqual(playerCreationSheet.Intelligence, player.Stats.Intelligence);
        Assert.AreEqual(playerCreationSheet.Strength, player.Stats.Strength);

        Assert.AreEqual(playerCreationSheet.MaxInventorySlots, player.Inventory!.MaxSlots);
    }

    [TestMethod]
    public void Create_WithEquipment_CreatesEquipped()
    {
        // Arrange
        var playerCreationSheet = _characterSheetBuilder.BuildPlayerCreationSheet();

        var armor = _equipmentBuilder.BuildArmor();
        var weapon = _equipmentBuilder.BuildWeapon();

        playerCreationSheet.Equipment.Add(armor);
        playerCreationSheet.Equipment.Add(weapon);

        // Act
        var player = _characterFactory.Create(playerCreationSheet);

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
        var playerCreationSheet = _characterSheetBuilder.BuildPlayerCreationSheet();

        var potion = _itemBuilder.BuildPotion();

        playerCreationSheet.Items.Add((potion, 1));

        // Act
        var player = _characterFactory.Create(playerCreationSheet);

        var inventory = player.Inventory!.GetInventory();

        // Assert
        Assert.AreEqual(playerCreationSheet.MaxInventorySlots, inventory.Count);
        Assert.AreEqual(potion, inventory[0].Item);
    }

    [TestMethod]
    public void Create_WithItems_CreatesInventoryWithMultipleItems()
    {
        // Arrange
        var playerCreationSheet = _characterSheetBuilder.BuildPlayerCreationSheet();

        var potion = _itemBuilder.BuildPotion();
        var weapon = _equipmentBuilder.BuildWeapon();
        var armor = _equipmentBuilder.BuildArmor();

        playerCreationSheet.Items.Add((potion, 10));
        playerCreationSheet.Items.Add((weapon, 1));
        playerCreationSheet.Items.Add((armor, 1));

        // Act
        var player = _characterFactory.Create(playerCreationSheet);

        var inventory = player.Inventory!.GetInventory();

        // Assert
        Assert.AreEqual(playerCreationSheet.MaxInventorySlots, inventory.Count);
        Assert.AreEqual(potion, inventory[0].Item);
        Assert.AreEqual(expected: 10, inventory[0].Quantity);
        Assert.AreEqual(weapon, inventory[1].Item);
        Assert.AreEqual(armor, inventory[2].Item);
    }
}