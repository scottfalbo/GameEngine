// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public abstract class ItemBase(string name)
{
    public string Name { get; private set; } = name;
}