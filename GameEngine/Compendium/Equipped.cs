// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public class Equipped
{
    private readonly Dictionary<int, Armor?> _armor;
    private readonly Dictionary<int, Weapon?> _weapons;

    private int _armorSlots;
    private int _weaponSlots;

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

        return true;
    }

    public bool EquipWeapon(int slot, Weapon weapon)
    {
        if (!WeaponIsInRange(slot))
        {
            return false;
        }

        _weapons[slot] = weapon;

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
        if (!ArmorIsInRange(slot))
        {
            return;
        }

        _armor[slot] = null;
    }

    public void UnequipWeapon(int slot)
    {
        if (!WeaponIsInRange(slot))
        {
            return;
        }

        _weapons[slot] = null;
    }

    private bool ArmorIsInRange(int slot) => slot >= 0 && slot < _armorSlots;

    private bool WeaponIsInRange(int slot) => slot >= 0 && slot < _weaponSlots;
}