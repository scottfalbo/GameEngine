// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium.Characters.NPCS;

internal class Mystic(string name) : NPC(name, NPCType.Mystic)
{
    public void HealerPlayer(Player player)
    {
        var adjustedPlayerStats = player.GetAdjustedStats();
        var playerHealth = adjustedPlayerStats.Health;
        var playerHitPoints = player.HitPoints;
        var healingAmount = playerHealth - playerHitPoints;

        player.IncrementHitPoints(healingAmount);
    }
}