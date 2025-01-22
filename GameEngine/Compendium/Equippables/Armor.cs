// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium.Equippables;

public class Armor : Equippable
{
    public Armor(string name, int armor)
        : base(name, EquippableType.Armor)
    {
        SetArmor(armor);
    }
}