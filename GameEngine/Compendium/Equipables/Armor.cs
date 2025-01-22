// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium.Equipables;

public class Armor : Equipable
{
    public Armor(string name, int armor)
        : base(name, EquipmentType.Armor)
    {
        SetArmor(armor);
    }
}