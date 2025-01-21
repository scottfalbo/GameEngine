// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium.Abstracts;

public abstract class Consumable(string name, int adjustmentAmount, ConsumableType consumableType, Stat targetStat)
    : Item(name, ItemType.Consumable)
{
    public int AdjustmentAmount { get; private set; } = adjustmentAmount;

    public ConsumableType ConsumableType { get; private set; } = consumableType;

    public Stat TargetStat { get; private set; } = targetStat;

    public void SetTargetStat(Stat value)
    {
        TargetStat = value;
    }
}