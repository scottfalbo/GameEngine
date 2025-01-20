﻿// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public abstract class Equipment(string name) : Item(name)
{
    public int Armor { get; private set; } = 0;

    public int Damage { get; private set; } = 0;

    public int Dexterity { get; private set; } = 0;

    public int Health { get; private set; } = 0;

    public int Intelligence { get; private set; } = 0;

    public int Strength { get; private set; } = 0;

    public void SetArmor(int value)
    {
        Armor = value;
    }

    public void SetDamage(int value)
    {
        Damage = value;
    }

    public void SetDexterity(int value)
    {
        Dexterity = value;
    }

    public void SetHealth(int value)
    {
        Health = value;
    }

    public void SetIntelligence(int value)
    {
        Intelligence = value;
    }

    public void SetStrength(int value)
    {
        Strength = value;
    }
}