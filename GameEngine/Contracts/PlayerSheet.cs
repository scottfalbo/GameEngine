// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Contracts;

public class PlayerSheet(string name) : CharacterSheet(name)
{
    public int Currency { get; set; }
}