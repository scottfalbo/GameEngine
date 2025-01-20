// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public class PlayerCreationSheet(string name) : CharacterCreationSheet(name)
{
    public int Currency { get; set; }
}