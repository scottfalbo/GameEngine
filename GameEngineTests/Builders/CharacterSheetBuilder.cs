// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Contracts.Characters;

namespace GameEngineTests.Builders;

internal class CharacterSheetBuilder
{
    private int _armor = 10;
    private int _currency = 50;
    private int _dexterity = 5;
    private List<Equippable> _equipment = new();
    private int _experiencePoints = 10;
    private int _health = 20;
    private int _intelligence = 5;
    private List<Item> _items = new();
    private int _level = 1;
    private int _lootAmount = 5;
    private int _maxInventorySlots = 10;
    private string _name = "Trundle the Great";
    private int _strength = 5;

    public CreatureSheet BuildCreatureSheet()
    {
        return new CreatureSheet(_name)
        {
            Armor = _armor,
            Dexterity = _dexterity,
            Equippables = _equipment,
            ExperiencePoints = _experiencePoints,
            Health = _health,
            Intelligence = _intelligence,
            Items = _items,
            Level = _level,
            LootAmount = _lootAmount,
            MaxInventorySlots = _maxInventorySlots,
            Strength = _strength,
        };
    }

    public PlayerSheet BuildPlayerSheet()
    {
        return new PlayerSheet(_name)
        {
            Armor = _armor,
            Currency = _currency,
            Dexterity = _dexterity,
            Equippables = _equipment,
            Health = _health,
            Intelligence = _intelligence,
            Items = _items,
            MaxInventorySlots = _maxInventorySlots,
            Strength = _strength,
        };
    }
}