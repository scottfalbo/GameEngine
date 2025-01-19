// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;

namespace GameEngine.Factories;

public class PlayerFactory
{
    public Player Create(string name, CharacterStats stats)
    {
        var player = new Player(name, stats);

        player.AddCurrency(10);

        var inventory = new Inventory(10);
        player.AddInventory(inventory);

        var equipped = new Equipped(armorSlots: 1, weaponSlots: 1);
        player.AddEquipped(equipped);

        return player;
    }
}