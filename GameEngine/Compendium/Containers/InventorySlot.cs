// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;

namespace GameEngine.Compendium.Containers;

public class InventorySlot
{
    public bool HasItem => Item != null;

    public Item? Item { get; private set; }

    public int Quantity { get; private set; } = 0;

    public bool AddItem(Item item)
    {
        if (Item == null)
        {
            Item = item;
            Quantity = item.Quantity;

            return true;
        }

        return false;
    }

    public void DecreaseQuantity(int amount)
    {
        Quantity -= amount;
        Item!.SetQuantity(Quantity);

        if (Quantity <= 0)
        {
            RemoveItem();
        }
    }

    public bool IncreaseQuantity(int amount)
    {
        if (!Item!.IsStackable)
        {
            return false;
        }

        Quantity += amount;
        Item!.SetQuantity(Quantity);

        return true;
    }

    public void RemoveItem()
    {
        Quantity = 0;
        Item = null;
    }
}