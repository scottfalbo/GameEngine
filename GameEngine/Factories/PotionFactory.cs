// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;
using GameEngine.Contracts;

namespace GameEngine.Factories;

public class PotionFactory
{
    public Potion Create(PotionSheet creationSheet)
    {
        var potion = new Potion(
            creationSheet.Name,
            creationSheet.AdjustmentAmount,
            creationSheet.TargetStat,
            creationSheet.Quantity);

        return potion;
    }
}