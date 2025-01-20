// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;

namespace GameEngine.Factories;

public class PotionFactory
{
    public Potion Create(EquipmentSheet creationSheet)
    {
        var potion = new Potion(creationSheet.Name);

        return potion;
    }
}