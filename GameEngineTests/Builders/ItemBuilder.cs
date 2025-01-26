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
    private int _vendorBuyPrice = 5;
    private int _vendorSellPrice = 10;

    public Potion BuildPotion()
    {
        _name = _name == string.Empty ? "Test Potion" : _name;
        var potion = new Potion(_name, _adjustmentAmount, _targetStat, _quantity);
        potion.SetVendorBuyPrice(_vendorBuyPrice);
        potion.SetVendorSellPrice(_vendorSellPrice);

        potion.SetIsStackable(_isStackable);

        return potion;
    }

    public ItemBuilder WithIsStackable(bool isStackable)
    {
        _isStackable = isStackable;
        return this;
    }

    public ItemBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public ItemBuilder WithQuantity(int quantity)
    {
        _quantity = quantity;
        return this;
    }

    public ItemBuilder WithVendorBuyPrice(int vendorBuyPrice)
    {
        _vendorBuyPrice = vendorBuyPrice;
        return this;
    }

    public ItemBuilder WithVendorSellPrice(int vendorSellPrice)
    {
        _vendorSellPrice = vendorSellPrice;
        return this;
    }
}