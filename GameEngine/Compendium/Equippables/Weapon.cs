// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium.Equippables;

internal class Weapon : Equippable
{
    public Weapon(string name, int damage)
        : base(name, EquippableType.Weapon)
    {
        SetDamage(damage);
    }
}