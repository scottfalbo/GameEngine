// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public class Creature(string name, CharacterStats stats) : Character(name, stats)
{
    public int ExperiencePoints { get; private set; } = 0;

    public int LootAmount { get; private set; } = 0;

    public void AddLoot(int amount)
    {
        LootAmount += amount;
    }

    public void SetExperiencePoints(int amount)
    {
        ExperiencePoints = amount;
    }
}