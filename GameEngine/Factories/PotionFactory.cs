// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;
using GameEngine.Contracts;

namespace GameEngine.Factories;

public class PotionFactory
{
    public Potion Create(ItemSheet creationSheet)
    {
        var potion = new Potion(creationSheet.Name, creationSheet.Quantity);

        return potion;
    }
}