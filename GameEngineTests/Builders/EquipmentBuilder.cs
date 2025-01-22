// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Equipables;

namespace GameEngineTests.Builders;

internal class EquipmentBuilder
{
    private int _armor = 10;
    private int _damage = 10;
    private string _name = string.Empty;

    public Armor BuildArmor()
    {
        _name = _name == string.Empty ? "Test Armor" : _name;
        var armor = new Armor(_name, _armor);

        return armor;
    }

    public Weapon BuildWeapon()
    {
        _name = _name == string.Empty ? "Test Weapon" : _name;
        var weapon = new Weapon(_name, _damage);

        return weapon;
    }
}