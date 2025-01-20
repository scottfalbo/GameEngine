// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;

namespace GameEngineTests.Builders;

internal class ItemBuilder
{
    private bool _isStackable = false;
    private string _name = string.Empty;
    private int _quantity = 1;

    public Potion BuildPotion()
    {
        _name = _name == string.Empty ? "Test Potion" : _name;
        var potion = new Potion(_name, _quantity);

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