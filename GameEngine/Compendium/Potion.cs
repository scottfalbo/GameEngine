// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public class Potion : Item
{
    public Potion(string name) : base(name)
    {
        SetIsStackable(true);
    }
}