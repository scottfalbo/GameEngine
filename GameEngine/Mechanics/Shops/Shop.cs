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

    public void AddItem(Item item, int price, int quantity)
    {
        var slot = new ShopSlot(item, price, quantity);
        _slots.Add(item.Name, slot);
    }

    public ShopResponse PlayerBuysItem(string itemName, Player player, int quantity = 1)
    {
        var itemSlot = _slots[itemName];
        var item = itemSlot.Item;
        var totalCost = itemSlot.Price * quantity;

        var shopResponse = new ShopResponse(itemName, quantity, totalCost);

        if (itemSlot.Quantity < quantity)
        {
            shopResponse.SetIsSuccess(false);
            shopResponse.SetMessage(ShopMessages.InsufficientStock);
            return shopResponse;
        }

        if (totalCost > player.Currency)
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

        player.RemoveCurrency(totalCost);

        var message = $"{ShopMessages.PurchaseSuccess} of {quantity} {item.Name} for {totalCost}";
        shopResponse.SetIsSuccess(true);
        shopResponse.SetMessage(message);

        itemSlot.DecreaseQuantity(quantity);

        if (itemSlot.Quantity == 0)
        {
            _slots.Remove(itemName);
        }

        return shopResponse;
    }

    public ShopResponse PlayerSellsItem(Item item, Player player, int quantity = 1)
    {
        var totalPrice = item.SellPrice * quantity;

        var shopResponse = new ShopResponse(item.Name, quantity, totalPrice);

        return shopResponse;
    }
}