// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Constants;

namespace GameEngine.Contracts.Abstracts;

public abstract class ConsumableSheet(string name, ConsumableType consumableType)
    : ItemSheet(name, ItemType.Consumable)
{
    public int AdjustmentAmount { get; set; }

    public ConsumableType ConsumableType { get; set; } = consumableType;

    public bool IsStaticAdjustment { get; set; }

    public Stat TargetStat { get; set; }
}