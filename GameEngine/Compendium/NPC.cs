// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;

namespace GameEngine.Compendium;

public class NPC(string name, CharacterStats stats)
    : Character(name, stats)
{
}