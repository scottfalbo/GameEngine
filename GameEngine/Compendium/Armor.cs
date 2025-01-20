// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public class Armor : EquipmentBase
{
    public Armor(string name, int armor) : base(name)
    {
        SetArmor(armor);
    }
}