// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;

namespace GameEngine.Factories;

public class PotionFactory
{
    public Potion Create(string name)
    {
        return new Potion(name);
    }
}