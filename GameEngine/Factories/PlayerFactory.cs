// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;

namespace GameEngine.Factories;

public class PlayerFactory
{
    public Player Create(PlayerCreationSheet creationSheet)
    {
        var stats = new CharacterStats(
            creationSheet.Armor,
            creationSheet.Dexterity,
            creationSheet.Health,
            creationSheet.Intelligence,
            creationSheet.Strength);

        var player = new Player(creationSheet.Name, stats);

        player.SetCurrency(creationSheet.Currency);

        var inventory = new Inventory(creationSheet.MaxInventorySlots);
        player.AddInventory(inventory);

        for (var i = 0; i < creationSheet.Items.Count; i++)
        {
            var (Item, Quantity) = creationSheet.Items[i];
            player.Inventory!.AddItem(i, Item, Quantity);
        }

        List<Armor> armors = [];
        List<Weapon> weapons = [];

        foreach (var equipment in creationSheet.Equipment)
        {
            if (equipment is Armor armor)
            {
                armors.Add(armor);
            }

            if (equipment is Weapon weapon)
            {
                weapons.Add(weapon);
            }
        }

        var equipped = new Equipped(armors.Count, weapons.Count);
        player.AddEquipped(equipped);

        for (var i = 0; i < armors.Count; i++)
        {
            player.Equipped!.EquipArmor(i, armors[i]);
        }

        for (var i = 0; i < weapons.Count; i++)
        {
            player.Equipped!.EquipWeapon(i, weapons[i]);
        }

        return player;
    }
}