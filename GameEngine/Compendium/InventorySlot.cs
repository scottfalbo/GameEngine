// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public class InventorySlot
{
    public ItemBase? Item { get; private set; }

    public int Quantity { get; private set; } = 0;

    public bool AddItem(ItemBase item, int quantity = 1)
    {
        if (Item == null)
        {
            Item = item;
            Quantity = quantity;

            return true;
        }

        return false;
    }

    public void DecreaseQuantity(int amount)
    {
        Quantity -= amount;

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

        return true;
    }

    public void RemoveItem()
    {
        Quantity = 0;
        Item = null;
    }
}