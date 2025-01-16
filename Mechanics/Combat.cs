// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using Compendium;

namespace Mechanics;

public class Combat(Player player, List<Creature> creatures)
{
    private readonly List<Creature> _creatures = creatures;

    private readonly Dice _dice = new();

    private readonly Player _player = player;
}