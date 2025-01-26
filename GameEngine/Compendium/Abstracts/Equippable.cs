// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium.Abstracts;

internal abstract class Equippable(string name, EquippableType equipmentType)
    : Item(name, ItemType.Equipment)
{
    public int Damage { get; private set; } = 0;

    public int Defense { get; private set; } = 0;

    public EquippableType EquipmentType { get; private set; } = equipmentType;

    public Stats Stats { get; private set; } = new Stats();

    public void SetArmor(int armor)
    {
        Stats.SetArmor(armor);
    }

    public void SetDamage(int damage)
    {
        Damage = damage;
    }

    public void SetDefense(int defense)
    {
        Defense = defense;
    }
}