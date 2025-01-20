// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public class PlayerSheet(string name) : CharacterSheet(name)
{
    public int Currency { get; set; }
}