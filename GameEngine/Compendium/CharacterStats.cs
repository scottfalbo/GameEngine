// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public class CharacterStats(int armor, int health, int strength, int dexterity, int intelligence)
{
    public int Armor { get; set; } = armor;

    public int Dexterity { get; set; } = dexterity;

    public int Health { get; set; } = health;

    public int Intelligence { get; set; } = intelligence;

    public int Strength { get; set; } = strength;
}