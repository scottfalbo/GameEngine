// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public class Armor : Equipment
{
    public Armor(string name, int armor) : base(name, Codex.EquipmentType.Armor)
    {
        SetArmor(armor);
    }
}