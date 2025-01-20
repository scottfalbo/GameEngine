// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;

namespace GameEngine.Mechanics;

public class Combat : CombatRolls
{
    private readonly Queue<Character> _combatSequence;

    private readonly IEnumerable<Creature> _creatures;

    private readonly Dice _dice;

    private readonly Player _player;

    public Combat(IEnumerable<Creature> creatures, Player player)
    {
        _creatures = creatures;
        _dice = new();
        _player = player;

        _combatSequence = new();

        _combatSequence.Enqueue(player);

        foreach (var creature in creatures)
        {
            _combatSequence.Enqueue(creature);
        }
    }
}