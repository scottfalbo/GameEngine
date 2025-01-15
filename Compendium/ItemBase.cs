// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace Compendium;

public abstract class ItemBase(string name)
{
    public string Name { get; private set; } = name;
}