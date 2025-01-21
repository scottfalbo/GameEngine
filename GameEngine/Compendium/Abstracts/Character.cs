// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Containers;

namespace GameEngine.Compendium.Abstracts;

public abstract class Character(string name, CharacterStats stats)
{
    public Equipped? Equipped { get; private set; }

    public Inventory? Inventory { get; private set; }

    public int Level { get; private set; } = 1;

    public string Name { get; private set; } = name;

    public CharacterStats Stats { get; private set; } = stats;

    public void AddEquipped(Equipped equipped)
    {
        Equipped = equipped;
    }

    public void AddInventory(Inventory inventory)
    {
        Inventory = inventory;
    }

    public void AddLevel(int amount)
    {
        Level += amount;
    }

    public CharacterStats GetAdjustedStats()
    {
        var equippedStats = Equipped!.EquippedStats;

        var adjustedStats = new CharacterStats(
            Stats.Armor + equippedStats.Armor,
            Stats.Dexterity + equippedStats.Dexterity,
            Stats.Health + equippedStats.Health,
            Stats.Intelligence + equippedStats.Intelligence,
            Stats.Strength + equippedStats.Strength);

        return adjustedStats;
    }

    public void SetLevel(int amount)
    {
        Level = amount;
    }
}