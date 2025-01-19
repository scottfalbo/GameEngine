// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;

namespace GameEngine.Factories;

public class PotionFactory
{
    public Potion Create(string name)
    {
        var potion = new Potion(name);
        potion.SetIsStackable(true);

        return potion;
    }
}