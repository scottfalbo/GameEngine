// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public class Weapon(string name, int damage) : EquipmentBase(name)
{
    public int Damage { get; private set; } = damage;
}