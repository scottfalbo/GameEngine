// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Codex;

namespace GameEngine.Compendium;

public class Potion : Item
{
    public Potion(string name) : base(name, ItemType.Potion)
    {
        SetIsConsumable(true);
        SetIsStackable(true);
    }
}