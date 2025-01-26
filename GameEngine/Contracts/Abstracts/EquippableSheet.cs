// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Constants;

namespace GameEngine.Contracts.Abstracts;

public abstract class EquippableSheet(string name, EquippableType type) : BaseSheet(name)
{
    public int Armor { get; set; }

    public int Damage { get; set; }

    public int Dexterity { get; set; }

    public int Health { get; set; }

    public int Intelligence { get; set; }

    public int Price { get; set; }

    public int Strength { get; set; }

    public EquippableType Type { get; set; } = type;
}