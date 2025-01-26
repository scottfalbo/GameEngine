// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium.Abstracts;

public abstract class Item(string name, ItemType type) : GameObjectBase(name, GameObjectType.Item)
{
    public bool IsStackable { get; private set; } = false;

    public ItemType ItemType { get; private set; } = type;

    public int Quantity { get; private set; } = 1;

    public int VendorBuyPrice { get; private set; } = 0;

    public int VendorSellPrice { get; private set; } = 0;

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