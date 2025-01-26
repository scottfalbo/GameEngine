// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium.Items;

internal class Crafting(string name, CraftingType craftingType) : Material(name, MaterialType.Crafting)
{
    public CraftingType CraftingType { get; private set; } = craftingType;
}