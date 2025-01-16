// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public class Player(string name, CharacterStats stats) : CharacterBase(name, stats)
{
    public int Currency { get; set; } = 0;
}