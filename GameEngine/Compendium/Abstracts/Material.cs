// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium.Abstracts;

public abstract class Material(string name, MaterialType materialType) : Item(name, ItemType.Material)
{
    public MaterialType MaterialType { get; private set; } = materialType;
}