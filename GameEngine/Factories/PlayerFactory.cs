// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;

namespace GameEngine.Factories;

public class PlayerFactory
{
    public Player Create(string name, CharacterStats stats, Inventory inventory, Equipped equipped)
    {
        var player = new Player(name, stats);

        player.AddCurrency(10);

        player.AddInventory(inventory);

        player.AddEquipped(equipped);

        return player;
    }
}