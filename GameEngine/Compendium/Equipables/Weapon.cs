// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium.Equipables;

public class Weapon : Equipable
{
    public Weapon(string name, int damage)
        : base(name, EquipmentType.Weapon)
    {
        SetDamage(damage);
    }
}