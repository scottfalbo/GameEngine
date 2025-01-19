// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;

namespace GameEngine.Factories;

public class PlayerFactory
{
    public Player Create(string name)
    {
        var stats = new CharacterStats(3, 20, 5, 5, 5);

        var player = new Player(name, stats)
        {
            Currency = 10
        };

        return player;
    }
}