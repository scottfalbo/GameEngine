﻿// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Codex;

namespace GameEngine.Compendium;

public abstract class Item(string name, ItemType type)
{
    public bool IsConsumable { get; private set; } = false;

    public bool IsStackable { get; private set; } = false;

    public ItemType ItemType { get; private set; } = type;

    public string Name { get; private set; } = name;

    public void SetIsConsumable(bool value)
    {
        IsConsumable = value;
    }

    public void SetIsStackable(bool value)
    {
        IsStackable = value;
    }
}