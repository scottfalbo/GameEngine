// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Codex;

namespace GameEngine.Compendium.Abstracts;

public abstract class Consumable(string name, ConsumableType consumableType) : Item(name, ItemType.Consumable)
{
    public ConsumableType ConsumableType { get; private set; } = consumableType;
}