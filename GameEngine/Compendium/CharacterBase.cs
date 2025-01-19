﻿// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public abstract class CharacterBase(string name, CharacterStats stats)
{
    public Equipped? Equipped { get; private set; }

    public Inventory? Inventory { get; private set; }

    public int Level { get; private set; } = 1;

    public string Name { get; private set; } = name;

    public CharacterStats Stats { get; private set; } = stats;

    public void AddEquipped(Equipped equipped)
    {
        Equipped = equipped;
    }

    public void AddInventory(Inventory inventory)
    {
        Inventory = inventory;
    }

    public void AddLevel(int amount)
    {
        Level += amount;
    }

    public void SetLevel(int amount)
    {
        Level = amount;
    }
}