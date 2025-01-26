// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

internal class Stats()
{
    public int Armor { get; private set; }

    public int Dexterity { get; private set; }

    public int Health { get; private set; }

    public int Intelligence { get; private set; }

    public int Strength { get; private set; }

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