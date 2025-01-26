// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Contracts.Abstracts;

namespace GameEngine.Factories;

public abstract class EquipmentFactory
{
    protected void SetStats(Equippable equipment, EquippableSheet creationSheet)
    {
        equipment.SetArmor(creationSheet.Armor);
        equipment.SetDamage(creationSheet.Damage);
        equipment.SetDexterity(creationSheet.Dexterity);
        equipment.SetHealth(creationSheet.Health);
        equipment.SetIntelligence(creationSheet.Intelligence);
        equipment.SetStrength(creationSheet.Strength);
    }
}