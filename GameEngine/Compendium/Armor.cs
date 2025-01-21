// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium;

public class Armor : Equipment
{
    public Armor(string name, int armor)
        : base(name, EquipmentType.Armor)
    {
        SetArmor(armor);
    }
}