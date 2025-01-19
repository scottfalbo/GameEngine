// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public class Creature(string name, CharacterStats stats) : CharacterBase(name, stats)
{
    public int LootAmount { get; private set; } = 0;

    public void AddLoot(int amount)
    {
        LootAmount += amount;
    }
}