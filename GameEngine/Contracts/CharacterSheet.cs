// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;

namespace GameEngine.Contracts;

public abstract class CharacterSheet(string name) : BaseSheet(name)
{
    public List<Equipment> Equipment { get; set; } = [];

    public List<(Item Item, int Quantity)> Items { get; set; } = [];

    public int MaxInventorySlots { get; set; }
}