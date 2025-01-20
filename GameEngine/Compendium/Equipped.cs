// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public class Equipped
{
    private readonly Dictionary<int, Armor?> _armor;
    private readonly Dictionary<int, Weapon?> _weapons;

    private int _armorSlots;
    private CharacterStats _equippedStats;
    private int _weaponSlots;

    public CharacterStats EquippedStats => _equippedStats;

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

        _equippedStats = new CharacterStats(0, 0, 0, 0, 0);
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
        AdjustEquippedStats(armor!, true);

        _armor[slot] = null;
    }

    public void UnequipWeapon(int slot)
    {
        if (!WeaponIsInRange(slot) || _weapons[slot] == null)
        {
            return;
        }

        var weapon = _weapons[slot];
        AdjustEquippedStats(weapon!, true);

        _weapons[slot] = null;
    }

    private void AdjustEquippedStats(EquipmentBase equipment, bool unequip = false)
    {
        var armor = unequip ? _equippedStats.Armor - equipment.Armor : _equippedStats.Armor + equipment.Armor;
        var dexterity = unequip ? _equippedStats.Dexterity - equipment.Dexterity : _equippedStats.Dexterity + equipment.Dexterity;
        var health = unequip ? _equippedStats.Health - equipment.Health : _equippedStats.Health + equipment.Health;
        var intelligence = unequip ? _equippedStats.Intelligence - equipment.Intelligence : _equippedStats.Intelligence + equipment.Intelligence;
        var strength = unequip ? _equippedStats.Strength - equipment.Strength : _equippedStats.Strength + equipment.Strength;

        _equippedStats.SetArmor(armor);
        _equippedStats.SetDexterity(dexterity);
        _equippedStats.SetHealth(health);
        _equippedStats.SetIntelligence(intelligence);
        _equippedStats.SetStrength(strength);
    }

    private bool ArmorIsInRange(int slot) => slot >= 0 && slot < _armorSlots;

    private bool WeaponIsInRange(int slot) => slot >= 0 && slot < _weaponSlots;
}