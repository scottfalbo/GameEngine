// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Constants;
using GameEngine.Compendium.Items;

namespace GameEngineTests.Builders;

internal class ItemBuilder
{
    private int _adjustmentAmount = 1;
    private bool _isStackable = false;
    private string _name = string.Empty;
    private int _quantity = 1;
    private Stat _targetStat = Stat.None;

    public Potion BuildPotion()
    {
        _name = _name == string.Empty ? "Test Potion" : _name;
        var potion = new Potion(_name, _adjustmentAmount, _targetStat, _quantity);

        potion.SetIsStackable(_isStackable);

        return potion;
    }

    public ItemBuilder WithIsStackable(bool isStackable)
    {
        _isStackable = isStackable;
        return this;
    }

    public ItemBuilder WithQuantity(int quantity)
    {
        _quantity = quantity;
        return this;
    }
}