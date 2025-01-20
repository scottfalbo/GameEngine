// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Compendium.Codex;

namespace GameEngine.Compendium;

public class Potion : Consumable
{
    public Potion(string name, int quantity = 1) : base(name, ConsumableType.Potion)
    {
        SetQuantity(quantity);
        SetIsStackable(true);
    }
}