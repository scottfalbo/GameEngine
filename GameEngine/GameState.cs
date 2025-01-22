// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Characters;

namespace GameEngine;

public class GameState
{
    private static GameState? _instance;

    public static GameState? Instance => _instance ??= new GameState();

    public Player? Player { get; set; }

    private GameState()
    {
    }
}