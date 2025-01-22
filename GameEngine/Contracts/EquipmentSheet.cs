// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Constants;

namespace GameEngine.Contracts;

public class EquipmentSheet(string name, EquippableType type) : BaseSheet(name)
{
    public int Damage { get; set; }

    public int Price { get; set; }

    public EquippableType Type { get; set; } = type;
}