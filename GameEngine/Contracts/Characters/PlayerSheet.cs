// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Contracts.Abstracts;

namespace GameEngine.Contracts.Characters;

public class PlayerSheet(string name) : CharacterSheet(name)
{
    public int Currency { get; set; }

    public int Experience { get; set; }

    public int MaxInventorySlots { get; set; }
}