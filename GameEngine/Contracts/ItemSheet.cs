// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Codex;

namespace GameEngine.Contracts;

public class ItemSheet(string name) : BaseSheet(name)
{
    public bool IsConsumable { get; set; }

    public bool IsStackable { get; set; }

    public int Price { get; set; }

    public int Quantity { get; set; }

    public ItemType Type { get; set; }
}