﻿// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Compendium.Characters;

namespace GameEngine.Mechanics.Shops;

public class Shop(string name)
{
    private readonly Dictionary<string, ShopSlot> _slots = [];

    public string Name { get; private set; } = name;

    private decimal MarkupPercentage { get; set; } = 1m;

    public void AddItem(Item item, int price, int quantity)
    {
        var slot = new ShopSlot(item, price, quantity);
        _slots.Add(item.Name, slot);
    }

    public ShopResponse PlayerBuysItem(string itemName, Player player, int quantity = 1)
    {
        var itemSlot = _slots[itemName];
        var item = itemSlot.Item;
        var totalPrice = itemSlot.Price * quantity;

        var shopResponse = new ShopResponse(itemName, quantity, totalPrice);

        if (itemSlot.Quantity < quantity)
        {
            shopResponse.SetIsSuccess(false);
            shopResponse.SetMessage(ShopMessages.InsufficientStock);
            return shopResponse;
        }

        if (totalPrice > player.Currency)
        {
            shopResponse.SetIsSuccess(false);
            shopResponse.SetMessage(ShopMessages.InsufficientFunds);
            return shopResponse;
        }

        if (player.Inventory!.IsInventoryFull())
        {
            shopResponse.SetIsSuccess(false);
            shopResponse.SetMessage(ShopMessages.InsufficientSpace);
            return shopResponse;
        }

        item.SetQuantity(quantity);

        player.Inventory.AddItem(item);

        player.RemoveCurrency(totalPrice);

        itemSlot.DecreaseQuantity(quantity);

        if (itemSlot.Quantity == 0)
        {
            _slots.Remove(itemName);
        }

        var message = $"{ShopMessages.PurchaseSuccess} of {quantity} {item.Name} for {totalPrice}";
        shopResponse.SetIsSuccess(true);
        shopResponse.SetMessage(message);

        return shopResponse;
    }

    public ShopResponse PlayerSellsItem(int inventorySlot, Player player, int quantity = 1)
    {
        var playerInventory = player.Inventory!.GetInventory();
        var playerInventorySlot = playerInventory[inventorySlot];

        var item = playerInventorySlot.Item;
        var totalPrice = item!.VendorBuyPrice * quantity;

        var shopResponse = new ShopResponse(item.Name, quantity, totalPrice);

        if (playerInventorySlot.Quantity < quantity)
        {
            shopResponse.SetIsSuccess(false);
            shopResponse.SetMessage(ShopMessages.InsufficientQuantity);
            return shopResponse;
        }

        playerInventorySlot.DecreaseQuantity(quantity);
        player.AddCurrency(totalPrice);

        if (_slots.TryGetValue(item.Name, out ShopSlot? value))
        {
            value.IncreaseQuantity(quantity);
        }
        else
        {
            var adjustedPrice = (int)Math.Round(item.VendorSellPrice * MarkupPercentage);
            AddItem(item, adjustedPrice, quantity);
        }

        var message = $"{ShopMessages.SaleSuccess} of {quantity} {item.Name} for {totalPrice}";
        shopResponse.SetIsSuccess(true);
        shopResponse.SetMessage(message);

        return shopResponse;
    }

    public void SetMarkupPercentage(decimal markupPercentage)
    {
        MarkupPercentage = markupPercentage;
    }
}