// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Constants;

namespace GameEngine.Contracts.Abstracts;

public abstract class ItemSheet(string name, ItemType itemType) : BaseSheet(name)
{
    public Guid Id { get; } = Guid.NewGuid();

    public bool IsStackable { get; set; } = false;

    public ItemType ItemType { get; set; } = itemType;

    public int Quantity { get; set; } = 1;

    public int VendorBuyPrice { get; set; } = 0;

    public int VendorSellPrice { get; set; } = 0;
}