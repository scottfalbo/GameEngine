// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;

namespace GameEngine.Contracts.Abstracts;

public abstract class CharacterSheet(string name) : BaseSheet(name)
{
    public List<Equippable> Equipment { get; set; } = [];

    public List<Item> Items { get; set; } = [];

    public int MaxInventorySlots { get; set; }

    public StatsSheet Stats { get; set; } = new StatsSheet();
}