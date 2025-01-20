// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;
using GameEngine.Contracts;

namespace GameEngine.Factories;

public abstract class CharacterFactory
{
    protected static CharacterStats CreateCharacterStats(CharacterSheet creationSheet)
    {
        var stats = new CharacterStats(
            creationSheet.Armor,
            creationSheet.Dexterity,
            creationSheet.Health,
            creationSheet.Intelligence,
            creationSheet.Strength);

        return stats;
    }

    protected static Equipped CreateEquipped(CharacterSheet creationSheet)
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

    protected static Inventory CreateInventory(CharacterSheet creationSheet)
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