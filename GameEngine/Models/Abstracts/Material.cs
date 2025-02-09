﻿// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Constants;

namespace GameEngine.Compendium.Abstracts;

internal abstract class Material(string name, MaterialType materialType) : Item(name, ItemType.Material)
{
    public MaterialType MaterialType { get; private set; } = materialType;
}