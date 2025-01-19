// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;

namespace GameEngine.Factories;

public class CreatureFactory
{
    public static Creature Create(string name, CharacterStats stats)
    {
        var creature = new Creature(name, stats);

        creature.AddLoot(5);

        return creature;
    }
}