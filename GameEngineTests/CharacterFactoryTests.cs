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
    private readonly CharacterCreationSheetBuilder _builder;
    private readonly CharacterFactory _characterFactory;

    public CharacterFactoryTests()
    {
        _builder = new CharacterCreationSheetBuilder();
        _characterFactory = new CharacterFactory();
    }

    [TestMethod]
    public void Create_CreatureCreationSheet_CreatesCreature()
    {
        // Arrange
        var creatureCreatureSheet = _builder.BuildCreatureCreationSheet();

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
        var playerCreationSheet = _builder.BuildPlayerCreationSheet();

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
}