// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Constants;

namespace GameEngine.Contracts.Abstracts;

public abstract class ConsumableSheet(string name) : ItemSheet(name)
{
    public int AdjustmentAmount { get; set; }

    public bool IsStaticAdjustment { get; set; }

    public Stat TargetStat { get; set; }
}