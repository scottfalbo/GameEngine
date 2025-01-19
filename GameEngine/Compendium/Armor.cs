// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public class Armor(string name, int defense) : EquipmentBase(name)
{
    public int Defense { get; private set; } = defense;
}