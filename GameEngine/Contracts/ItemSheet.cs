// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Contracts;

public class ItemSheet(string name) : BaseSheet(name)
{
    public bool IsStackable { get; set; }
}