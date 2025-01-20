// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Codex;

namespace GameEngine.Contracts;

public class EquipmentSheet(string name, EquipmentType type) : BaseSheet(name)
{
    public int Damage { get; set; } = 0;

    public EquipmentType Type { get; set; } = type;
}