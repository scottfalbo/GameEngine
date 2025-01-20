// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Codex;

namespace GameEngine.Compendium;

public class Potion : Item
{
    public Potion(string name, int quantity = 1) : base(name, ItemType.Potion)
    {
        SetQuantity(quantity);
        SetIsConsumable(true);
        SetIsStackable(true);
    }
}