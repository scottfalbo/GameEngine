// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Equippables;
using GameEngine.Contracts.Abstracts;

namespace GameEngine.Factories;

public class ArmorFactory : EquipmentFactory
{
    public Armor Create(EquippableSheet creationSheet)
    {
        var armor = new Armor(
            creationSheet.Name,
            creationSheet.Armor);

        SetStats(armor, creationSheet);

        return armor;
    }
}