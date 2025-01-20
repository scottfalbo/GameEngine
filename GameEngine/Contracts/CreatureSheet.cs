// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Contracts;

public class CreatureSheet(string name) : CharacterSheet(name)
{
    public int ExperiencePoints { get; set; }

    public int Level { get; set; }

    public int LootAmount { get; set; }
}