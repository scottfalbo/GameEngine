// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public class Weapon : Equipment
{
    public Weapon(string name, int damage) : base(name)
    {
        SetDamage(damage);
    }
}