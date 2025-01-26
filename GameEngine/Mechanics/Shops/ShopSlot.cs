// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;

namespace GameEngine.Mechanics.Shops;

public class ShopSlot(Item item, int price, int quantity)
{
    public Item Item { get; private set; } = item;

    public int Price { get; private set; } = price;

    public int Quantity { get; private set; } = quantity;

    public void DecreaseQuantity(int amount)
    {
        Quantity = Quantity - amount < 0 ? 0 : Quantity - amount;
        Item.SetQuantity(Quantity);
    }

    public bool IncreaseQuantity(int amount)
    {
        Quantity += amount;
        Item.SetQuantity(Quantity);

        return true;
    }
}