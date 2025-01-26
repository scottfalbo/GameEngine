// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Contracts.Abstracts;

public abstract class ItemSheet(string name) : BaseSheet(name)
{
    public bool IsStackable { get; set; } = false;

    public int Quantity { get; set; } = 1;

    public int VendorBuyPrice { get; set; } = 0;

    public int VendorSellPrice { get; set; } = 0;
}