// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Contracts.Abstracts;

public abstract class EquippableSheet(string name) : ItemSheet(name)
{
    public int Damage { get; set; }

    public int Defense { get; set; }

    public StatsSheet Stats { get; set; } = new StatsSheet();
}