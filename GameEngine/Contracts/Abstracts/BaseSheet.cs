// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Contracts.Abstracts;

public abstract class BaseSheet(string name)
{
    public string? FlavorText { get; set; }

    public string Name { get; private set; } = name;
}