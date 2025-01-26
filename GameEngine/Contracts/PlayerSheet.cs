// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Contracts.Abstracts;

namespace GameEngine.Contracts;

public class PlayerSheet(string name) : CharacterSheet(name)
{
    public int Currency { get; set; }
}