// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Contracts.Abstracts;

namespace GameEngine.Mechanics.Shops;

internal class ShopSlot(ItemSheet itemSheet)
{
    public ItemSheet ItemSheet { get; private set; } = itemSheet;

    public int VendorSellPrice { get; private set; } = itemSheet.VendorSellPrice;

    public void DecreaseQuantity(int amount)
    {
        ItemSheet.Quantity = ItemSheet.Quantity - amount < 0 ? 0 : ItemSheet.Quantity - amount;
    }

    public void IncreaseQuantity(int amount)
    {
        ItemSheet.Quantity += amount;
    }
}