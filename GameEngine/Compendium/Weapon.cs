// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public class Weapon(string name, int damage) : Equipment(name)
{
    public int Damage { get; private set; } = damage;
}