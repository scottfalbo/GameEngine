// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;

namespace GameEngine.Contracts;

public abstract class CharacterSheet(string name) : BaseSheet(name)
{
    public List<Equipment> Equipment { get; set; } = [];

    public List<Item> Items { get; set; } = [];

    public int MaxInventorySlots { get; set; }
}