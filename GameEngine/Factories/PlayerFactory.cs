// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Characters;
using GameEngine.Contracts.Characters;

namespace GameEngine.Factories;

public class PlayerFactory : CharacterFactory
{
    public Player Create(PlayerSheet creationSheet)
    {
        var stats = CreateCharacterStats(creationSheet);

        var player = new Player(creationSheet.Name, stats);

        player.SetCurrency(creationSheet.Currency);

        var inventory = CreateInventory(creationSheet);
        player.AddInventory(inventory);

        var equipped = CreateEquipped(creationSheet);
        player.AddEquipped(equipped);

        return player;
    }
}