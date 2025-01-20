// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;
using GameEngine.Contracts;

namespace GameEngine.Factories;

public class WeaponFactory : EquipmentFactory
{
    public Weapon Create(EquipmentSheet creationSheet)
    {
        var weapon = new Weapon(
            creationSheet.Name,
            creationSheet.Damage);

        SetStats(weapon, creationSheet);

        return weapon;
    }
}