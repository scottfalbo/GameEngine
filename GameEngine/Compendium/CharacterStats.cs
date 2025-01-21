// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public class CharacterStats(
    int armor,
    int dexterity,
    int health,
    int intelligence,
    int strength)
{
    public int Armor { get; private set; } = armor;

    public int Dexterity { get; private set; } = dexterity;

    public int Health { get; private set; } = health;

    public int Intelligence { get; private set; } = intelligence;

    public int Strength { get; private set; } = strength;

    public void SetArmor(int value)
    {
        Armor = value;
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