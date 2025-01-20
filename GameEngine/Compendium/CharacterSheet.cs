// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public abstract class CharacterSheet(string name)
{
    public int Armor { get; set; }

    public int Dexterity { get; set; }

    public List<Equipment> Equipment { get; set; } = [];

    public int Health { get; set; }

    public int Intelligence { get; set; }

    public List<(Item Item, int Quantity)> Items { get; set; } = [];

    public int MaxInventorySlots { get; set; }

    public string Name { get; set; } = name;

    public int Strength { get; set; }
}