// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Contracts.Abstracts;

public abstract class CharacterSheet(string name) : BaseSheet(name)
{
    public List<EquippableSheet> EquippableSheets { get; set; } = [];

    public List<ItemSheet> ItemSheets { get; set; } = [];

    public int MaxInventorySlots { get; set; }

    public StatsSheet Stats { get; set; } = new StatsSheet();
}