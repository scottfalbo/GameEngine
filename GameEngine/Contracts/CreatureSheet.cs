// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Contracts;

namespace GameEngine.Compendium;

public class CreatureSheet(string name) : CharacterSheet(name)
{
    public int ExperiencePoints { get; set; }

    public int Level { get; set; }

    public int LootAmount { get; set; }
}