// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Constants;
using GameEngine.Mechanics.Inventories;

namespace GameEngine.Compendium.Abstracts;

internal abstract class Character(string name, Stats stats) : GameObjectBase(name, GameObjectType.Character)
{
    public Equipped? Equipped { get; private set; }

    public int HitPoints { get; private set; } = stats.Health;

    public Inventory? Inventory { get; private set; }

    public int Level { get; private set; } = 1;

    public Stats Stats { get; private set; } = stats;

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

    public void DecrementHitPoints(int amount)
    {
        HitPoints -= amount;
    }

    public Stats GetAdjustedStats()
    {
        var equippedStats = Equipped!.EquippedStats;

        var adjustedStats = new Stats();

        adjustedStats.SetArmor(Stats.Armor + equippedStats.Armor);
        adjustedStats.SetDexterity(Stats.Dexterity + equippedStats.Dexterity);
        adjustedStats.SetHealth(Stats.Health + equippedStats.Health);
        adjustedStats.SetIntelligence(Stats.Intelligence + equippedStats.Intelligence);
        adjustedStats.SetStrength(Stats.Strength + equippedStats.Strength);

        return adjustedStats;
    }

    public void IncrementHitPoints(int amount)
    {
        var maxHitPoints = GetAdjustedStats().Health;

        if (HitPoints + amount > maxHitPoints)
        {
            HitPoints = maxHitPoints;
            return;
        }

        HitPoints += amount;
    }

    public void SetLevel(int amount)
    {
        Level = amount;
    }
}