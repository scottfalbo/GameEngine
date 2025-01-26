// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;
using GameEngine.Compendium.Abstracts;
using GameEngine.Compendium.Equippables;

namespace GameEngine.Mechanics.Inventories;

public class Equipped
{
    private readonly Dictionary<int, Armor?> _armor;
    private readonly Dictionary<int, Weapon?> _weapons;

    private int _armorSlots;
    private Stats _equippedStats;
    private int _weaponSlots;

    public Stats EquippedStats => _equippedStats;

    public Equipped(int armorSlots, int weaponSlots)
    {
        _armor = [];
        _weapons = [];

        _armorSlots = armorSlots;
        _weaponSlots = weaponSlots;

        for (int i = 0; i < _armorSlots; i++)
        {
            _armor.Add(i, null);
        }

        for (int i = 0; i < _weaponSlots; i++)
        {
            _weapons.Add(i, null);
        }

        _equippedStats = new Stats();
    }

    public void DecreaseArmorSlots(int amount)
    {
        _armorSlots -= amount;

        if (_armorSlots < 0)
        {
            _armorSlots = 0;
        }

        for (int i = 0; i < amount; i++)
        {
            _armor.Remove(_armorSlots + i);
        }
    }

    public void DecreaseWeaponSlots(int amount)
    {
        _weaponSlots -= amount;

        if (_weaponSlots < 0)
        {
            _weaponSlots = 0;
        }

        for (int i = 0; i < amount; i++)
        {
            _weapons.Remove(_weaponSlots + i);
        }
    }

    public bool EquipArmor(int slot, Armor armor)
    {
        if (!ArmorIsInRange(slot))
        {
            return false;
        }

        _armor[slot] = armor;
        AdjustEquippedStats(armor);

        return true;
    }

    public bool EquipWeapon(int slot, Weapon weapon)
    {
        if (!WeaponIsInRange(slot))
        {
            return false;
        }

        _weapons[slot] = weapon;
        AdjustEquippedStats(weapon);

        return true;
    }

    public Dictionary<int, Armor?> GetArmor() => _armor;

    public int GetWeaponDamage()
    {
        int damage = 0;

        foreach (var weapon in _weapons.Values)
        {
            if (weapon != null)
            {
                damage += weapon.Damage;
            }
        }
        return damage;
    }

    public Dictionary<int, Weapon?> GetWeapons() => _weapons;

    public void IncreaseArmorSlots(int amount)
    {
        _armorSlots += amount;

        for (int i = 0; i < amount; i++)
        {
            _armor.Add(_armorSlots + i, null);
        }
    }

    public void IncreaseWeaponSlots(int amount)
    {
        _weaponSlots += amount;

        for (int i = 0; i < amount; i++)
        {
            _weapons.Add(_weaponSlots + i, null);
        }
    }

    public void UnequipArmor(int slot)
    {
        if (!ArmorIsInRange(slot) || _armor[slot] == null)
        {
            return;
        }

        var armor = _armor[slot];
        AdjustEquippedStats(armor!, unequip: true);

        _armor[slot] = null;
    }

    public void UnequipWeapon(int slot)
    {
        if (!WeaponIsInRange(slot) || _weapons[slot] == null)
        {
            return;
        }

        var weapon = _weapons[slot];
        AdjustEquippedStats(weapon!, unequip: true);

        _weapons[slot] = null;
    }

    private void AdjustEquippedStats(Equippable equipment, bool unequip = false)
    {
        var equipmentArmor = equipment.Stats.Armor;
        var equipmentDexterity = equipment.Stats.Dexterity;
        var equipmentHealth = equipment.Stats.Health;
        var equipmentIntelligence = equipment.Stats.Intelligence;
        var equipmentStrength = equipment.Stats.Strength;

        var adjustedArmor = unequip ? _equippedStats.Armor - equipmentArmor : _equippedStats.Armor + equipmentArmor;
        var adjustedDexterity = unequip ? _equippedStats.Dexterity - equipmentDexterity : _equippedStats.Dexterity + equipmentDexterity;
        var adjustedHealth = unequip ? _equippedStats.Health - equipmentHealth : _equippedStats.Health + equipmentHealth;
        var adjustedIntelligence = unequip ? _equippedStats.Intelligence - equipmentIntelligence : _equippedStats.Intelligence + equipmentIntelligence;
        var adjustedStrength = unequip ? _equippedStats.Strength - equipmentStrength : _equippedStats.Strength + equipmentStrength;

        _equippedStats.SetArmor(adjustedArmor);
        _equippedStats.SetDexterity(adjustedDexterity);
        _equippedStats.SetHealth(adjustedHealth);
        _equippedStats.SetIntelligence(adjustedIntelligence);
        _equippedStats.SetStrength(adjustedStrength);
    }

    private bool ArmorIsInRange(int slot) => slot >= 0 && slot < _armorSlots;

    private bool WeaponIsInRange(int slot) => slot >= 0 && slot < _weaponSlots;
}