// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium.Equippables;

internal class Armor : Equippable
{
    public Armor(string name, int defense) : base(name, EquippableType.Armor)
    {
        SetDefense(defense);
    }
}