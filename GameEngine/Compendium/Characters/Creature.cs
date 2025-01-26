// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium.Characters;

internal class Creature(string name, Stats stats, CreatureType creatureType)
    : Character(name, stats)
{
    public CreatureType CreatureType { get; private set; } = creatureType;

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