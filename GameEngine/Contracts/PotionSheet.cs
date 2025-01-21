// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Constants;

namespace GameEngine.Contracts;

public class PotionSheet(string name) : ItemSheet(name)
{
    public int AdjustmentAmount { get; set; }

    public Stat TargetStat { get; set; }
}