// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium.Abstracts;

internal abstract class Consumable(string name, int adjustmentAmount, ConsumableType consumableType, Stat targetStat)
    : Item(name, ItemType.Consumable)
{
    public int AdjustmentAmount { get; private set; } = adjustmentAmount;

    public ConsumableType ConsumableType { get; private set; } = consumableType;

    public bool IsStaticAdjustment { get; private set; } = false;

    public Stat TargetStat { get; private set; } = targetStat;

    public void SetIsStaticAdjustment(bool value)
    {
        IsStaticAdjustment = value;
    }
}