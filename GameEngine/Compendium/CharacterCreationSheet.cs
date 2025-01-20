// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public abstract class CharacterCreationSheet(string name)
{
    public int Armor { get; set; }

    public int Dexterity { get; set; }

    public List<EquipmentBase> Equipment { get; set; } = [];

    public int Health { get; set; }

    public int Intelligence { get; set; }

    public List<(ItemBase Item, int Quantity)> Items { get; set; } = [];

    public int MaxInventorySlots { get; set; }

    public string Name { get; set; } = name;

    public int Strength { get; set; }
}