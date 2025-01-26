// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Characters;
using GameEngine.Contracts.Abstracts;

namespace GameEngine.Mechanics.Shops;

internal class Shop(string name)
{
    private readonly Dictionary<string, ShopSlot> _slots = [];

    private decimal _markupPercentage = 1m;

    public decimal MarkupPercentage => _markupPercentage;

    public string Name { get; private set; } = name;

    public void AddItem(ItemSheet itemSheet, int price)
    {
        var quantity = itemSheet.Quantity;
        var slot = new ShopSlot(itemSheet);
        _slots.Add(itemSheet.Name, slot);
    }

    public Dictionary<string, ShopSlot> GetSlots() => _slots;

    public ShopResponse PlayerBuysItem(string itemName, Player player, int quantity = 1)
    {
        var itemSlot = _slots[itemName];
        var item = itemSlot.ItemSheet;
        var totalPrice = itemSlot.VendorSellPrice * quantity;

        var shopResponse = new ShopResponse(itemName, quantity, totalPrice);

        return shopResponse;
    }

    public ShopResponse PlayerSellsItem(int inventorySlot, Player player, int quantity = 1)
    {
        var playerInventory = player.Inventory!.GetInventory();
        var playerInventorySlot = playerInventory[inventorySlot];

        var item = playerInventorySlot.Item;
        var totalPrice = item!.VendorBuyPrice * quantity;

        var shopResponse = new ShopResponse(item.Name, quantity, totalPrice);

        return shopResponse;
    }

    public void RemoveItem(string itemName)
    {
        _slots.Remove(itemName);
    }

    public void SetMarkupPercentage(decimal markupPercentage)
    {
        _markupPercentage = markupPercentage;
    }
}