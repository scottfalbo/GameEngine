// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;

namespace GameEngine.Factories;

public class CreatureFactory
{
    public Creature Create(CreatureCreationSheet creationSheet)
    {
        var stats = new CharacterStats(
            creationSheet.Armor,
            creationSheet.Dexterity,
            creationSheet.Health,
            creationSheet.Intelligence,
            creationSheet.Strength);

        var creature = new Creature(creationSheet.Name, stats);

        creature.AddLoot(creationSheet.LootAmount);
        creature.SetExperiencePoints(creationSheet.ExperiencePoints);
        creature.SetLevel(creationSheet.Level);

        var inventory = new Inventory(creationSheet.MaxInventorySlots);
        creature.AddInventory(inventory);

        for (var i = 0; i < creationSheet.Items.Count; i++)
        {
            var (Item, Quantity) = creationSheet.Items[i];
            creature.Inventory!.AddItem(i, Item, Quantity);
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
        creature.AddEquipped(equipped);

        for (var i = 0; i < armors.Count; i++)
        {
            creature.Equipped!.EquipArmor(i, armors[i]);
        }

        for (var i = 0; i < weapons.Count; i++)
        {
            creature.Equipped!.EquipWeapon(i, weapons[i]);
        }

        return creature;
    }
}