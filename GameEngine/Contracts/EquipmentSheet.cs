// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Codex;
using GameEngine.Contracts;

public class EquipmentSheet(string name, EquipmentType type) : BaseSheet(name)
{
    public int Damage { get; set; } = 0;

    public EquipmentType equipmentType { get; set; } = type;
}