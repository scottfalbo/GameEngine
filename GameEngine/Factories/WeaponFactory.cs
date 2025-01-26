// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Equippables;
using GameEngine.Contracts.Abstracts;

namespace GameEngine.Factories;

public class WeaponFactory : EquipmentFactory
{
    public Weapon Create(EquippableSheet creationSheet)
    {
        var weapon = new Weapon(
            creationSheet.Name,
            creationSheet.Damage);

        SetStats(weapon, creationSheet);

        return weapon;
    }
}