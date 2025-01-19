// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public class Player(string name, CharacterStats stats) : CharacterBase(name, stats)
{
    public int Currency { get; private set; } = 0;

    public int Experience { get; private set; } = 0;

    public void AddCurrency(int amount)
    {
        Currency += amount;
    }

    public void AddExperience(int amount)
    {
        Experience += amount;
    }

    public void RemoveCurrency(int amount)
    {
        Currency -= amount;
    }

    public void SetCurrency(int amount)
    {
        Currency = amount;
    }
}