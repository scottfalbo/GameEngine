// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Characters;
using GameEngine.Contracts.Characters;

namespace GameEngine.Factories;

public class CreatureFactory : CharacterFactory
{
    public Creature Create(CreatureSheet creationSheet)
    {
        var stats = CreateCharacterStats(creationSheet);

        var creature = new Creature(creationSheet.Name, stats, creationSheet.CreatureType);

        creature.AddLoot(creationSheet.LootAmount);
        creature.SetExperiencePoints(creationSheet.ExperiencePoints);
        creature.SetLevel(creationSheet.Level);

        var inventory = CreateInventory(creationSheet);
        creature.AddInventory(inventory);

        var equipped = CreateEquipped(creationSheet);
        creature.AddEquipped(equipped);

        return creature;
    }
}