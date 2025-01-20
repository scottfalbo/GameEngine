// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;

namespace GameEngine.Mechanics;

public class CombatRolls
{
    private readonly Dice _dice = new();

    protected int AttackRoll(Player player, Creature creature)
    {
        var playerStats = player.GetAdjustedStats();

        var d20 = _dice.Roll(20);
        var damageModifier = playerStats.Strength + playerStats.Dexterity;
        var attackRoll = d20 + damageModifier;

        if (RollToHit(attackRoll, creature))
        {
            var weaponDamage = player.Equipped!.GetWeaponDamage();
            var damage = _dice.Roll(weaponDamage);

            return damage;
        }

        return 0;
    }

    protected bool RollToHit(int attackRoll, Creature creature) => attackRoll >= creature.Stats.Armor;
}