﻿// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public abstract class CharacterBase(string name, CharacterStats stats)
{
    public Equipped Equipped { get; private set; } = new();

    public Inventory Inventory { get; private set; } = new(12);

    public string Name { get; private set; } = name;

    public CharacterStats Stats { get; private set; } = stats;
}