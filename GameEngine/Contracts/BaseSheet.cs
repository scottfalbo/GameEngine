// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Contracts;

public class BaseSheet(string name)
{
    public int Armor { get; set; }

    public int Dexterity { get; set; }

    public int Health { get; set; }

    public int Intelligence { get; set; }

    public string Name { get; set; } = name;

    public int Strength { get; set; }
}