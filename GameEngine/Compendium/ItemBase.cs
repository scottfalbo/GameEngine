// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public abstract class ItemBase(string name)
{
    public bool IsStackable { get; private set; } = false;

    public string Name { get; private set; } = name;

    public void SetIsStackable(bool value)
    {
        IsStackable = value;
    }
}