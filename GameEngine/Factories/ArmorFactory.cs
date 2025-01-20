// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;
using GameEngine.Contracts;

namespace GameEngine.Factories;

public class ArmorFactory : EquipmentFactory
{
    public Armor Create(EquipmentSheet creationSheet)
    {
        var armor = new Armor(
            creationSheet.Name,
            creationSheet.Armor);

        SetStats(armor, creationSheet);

        return armor;
    }
}