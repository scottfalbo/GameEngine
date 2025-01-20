// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;

namespace GameEngine.Factories;

public class CharacterFactory
{
    public Player Create(PlayerCreationSheet creationSheet)
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

    public Creature Create(CreatureCreationSheet creationSheet)
    {
        var stats = CreateCharacterStats(creationSheet);

        var creature = new Creature(creationSheet.Name, stats);

        creature.AddLoot(creationSheet.LootAmount);
        creature.SetExperiencePoints(creationSheet.ExperiencePoints);
        creature.SetLevel(creationSheet.Level);

        var inventory = CreateInventory(creationSheet);
        creature.AddInventory(inventory);

        var equipped = CreateEquipped(creationSheet);
        creature.AddEquipped(equipped);

        return creature;
    }

    private static CharacterStats CreateCharacterStats(CharacterCreationSheet creationSheet)
    {
        var stats = new CharacterStats(
            creationSheet.Armor,
            creationSheet.Dexterity,
            creationSheet.Health,
            creationSheet.Intelligence,
            creationSheet.Strength);

        return stats;
    }

    private static Equipped CreateEquipped(CharacterCreationSheet creationSheet)
    {
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

        for (var i = 0; i < armors.Count; i++)
        {
            equipped.EquipArmor(i, armors[i]);
        }
        for (var i = 0; i < weapons.Count; i++)
        {
            equipped.EquipWeapon(i, weapons[i]);
        }
        return equipped;
    }

    private static Inventory CreateInventory(CharacterCreationSheet creationSheet)
    {
        var inventory = new Inventory(creationSheet.MaxInventorySlots);

        for (var i = 0; i < creationSheet.Items.Count; i++)
        {
            var (Item, Quantity) = creationSheet.Items[i];
            inventory.AddItem(i, Item, Quantity);
        }

        return inventory;
    }
}