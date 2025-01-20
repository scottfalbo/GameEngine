// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;

namespace GameEngine.Factories;

public abstract class EquipmentFactory
{
    protected void SetStats(Equipment equipment, EquipmentSheet creationSheet)
    {
        equipment.SetArmor(creationSheet.Armor);
        equipment.SetDamage(creationSheet.Damage);
        equipment.SetDexterity(creationSheet.Dexterity);
        equipment.SetHealth(creationSheet.Health);
        equipment.SetIntelligence(creationSheet.Intelligence);
        equipment.SetStrength(creationSheet.Strength);
    }
}