// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace Compendium;

public class CharacterStats(int health, int strength, int dexterity, int intelligence)
{
    public int Dexterity { get; private set; } = dexterity;

    public int Health { get; private set; } = health;

    public int Intelligence { get; private set; } = intelligence;

    public int Strength { get; private set; } = strength;
}