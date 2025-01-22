// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Constants;

namespace GameEngine.Contracts;

public class CreatureSheet(string name) : CharacterSheet(name)
{
    public CreatureType CreatureType { get; set; }

    public int ExperiencePoints { get; set; }

    public int Level { get; set; }

    public int LootAmount { get; set; }
}