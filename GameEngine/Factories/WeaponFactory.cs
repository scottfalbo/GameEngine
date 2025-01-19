// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;

namespace GameEngine.Factories;

public class WeaponFactory
{
    public Weapon Create(string name, int damage)
    {
        return new Weapon(name, damage);
    }
}