// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using Compendium;

namespace Mechanics;

public class Combat
{
    private readonly IEnumerable<Creature> _creatures;

    private readonly Dice _dice;

    private readonly Player _player;

    public Combat(IEnumerable<Creature> creatures, Player player)
    {
        _creatures = creatures;
        _dice = new();
        _player = player;
    }
}