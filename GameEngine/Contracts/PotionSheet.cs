// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Constants;
using GameEngine.Contracts.Abstracts;

namespace GameEngine.Contracts;

public class PotionSheet(string name) : ConsumableSheet(name, ConsumableType.Potion)
{
}