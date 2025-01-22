// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Compendium.Characters;

namespace GameEngine.Mechanics;

public class Combat
{
    private readonly Queue<Character> _combatSequence;
    private readonly IEnumerable<Creature> _creatures;
    private readonly Dice _dice = new();
    private readonly Player _player;

    public Combat(IEnumerable<Creature> creatures, Player player)
    {
        _creatures = creatures;
        _player = player;

        _combatSequence = new();

        _combatSequence.Enqueue(player);

        foreach (var creature in creatures)
        {
            _combatSequence.Enqueue(creature);
        }
    }

    public int AttackRoll(Character attacker, Character defender)
    {
        var playerStats = attacker.GetAdjustedStats();

        var d20 = _dice.Roll(20);
        var damageModifier = playerStats.Strength + playerStats.Dexterity;
        var attackRoll = d20 + damageModifier;

        if (RollToHit(attackRoll, defender))
        {
            var weaponDamage = attacker.Equipped!.GetWeaponDamage();
            var damage = _dice.Roll(weaponDamage) + damageModifier;

            return damage;
        }

        return 0;
    }

    private bool RollToHit(int attackRoll, Character defender) => attackRoll >= defender.Stats.Armor;
}