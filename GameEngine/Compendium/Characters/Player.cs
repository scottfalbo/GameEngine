// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;

namespace GameEngine.Compendium.Characters;

public class Player(string name, Stats stats)
    : Character(name, stats)
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