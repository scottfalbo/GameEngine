// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Constants;
using GameEngine.Contracts.Abstracts;

namespace GameEngine.Contracts.Characters;

public class CreatureSheet(string name) : CharacterSheet(name)
{
    public CreatureType CreatureType { get; set; }

    public int ExperiencePoints { get; set; }

    public int LootAmount { get; set; }
}