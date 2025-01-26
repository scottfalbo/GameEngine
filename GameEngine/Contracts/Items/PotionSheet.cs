// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Constants;
using GameEngine.Contracts.Abstracts;

namespace GameEngine.Contracts.Items;

public class PotionSheet(string name) : ConsumableSheet(name, ConsumableType.Potion)
{
}