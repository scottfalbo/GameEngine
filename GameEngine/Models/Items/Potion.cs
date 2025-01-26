// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Constants;

namespace GameEngine.Compendium.Items;

internal class Potion : Consumable
{
    public Potion(string name, int adjustmentAmount, Stat targetStat, int quantity = 1)
        : base(name, adjustmentAmount, ConsumableType.Potion, targetStat)
    {
        SetQuantity(quantity);
        SetIsStackable(true);
    }
}