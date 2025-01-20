// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;

namespace GameEngine.Compendium;

public class Weapon : Equipment
{
    public Weapon(string name, int damage) : base(name, Codex.EquipmentType.Weapon)
    {
        SetDamage(damage);
    }
}