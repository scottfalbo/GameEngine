// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium.Abstracts;

public abstract class Item(string name, ItemType type)
{
    public string? FlavorText { get; private set; }

    public Guid Id { get; private set; } = Guid.NewGuid();

    public bool IsStackable { get; private set; } = false;

    public ItemType ItemType { get; private set; } = type;

    public string Name { get; private set; } = name;

    public int Quantity { get; private set; } = 1;

    public int VendorBuyPrice { get; private set; } = 0;

    public int VendorSellPrice { get; private set; } = 0;

    public Item Clone()
    {
        var item = (Item)MemberwiseClone();
        item.Id = Guid.NewGuid();
        return item;
    }

    public void SetFlavorText(string value)
    {
        FlavorText = value;
    }

    public void SetIsStackable(bool value)
    {
        IsStackable = value;
    }

    public void SetQuantity(int value)
    {
        Quantity = value;
    }

    public void SetVendorBuyPrice(int value)
    {
        VendorBuyPrice = value;
    }

    public void SetVendorSellPrice(int value)
    {
        VendorSellPrice = value;
    }
}