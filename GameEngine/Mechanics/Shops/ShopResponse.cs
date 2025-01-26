// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Mechanics.Shops;

internal class ShopResponse(string itemName, int quantity, int totalCost)
{
    public bool IsSuccess { get; private set; }

    public string ItemName { get; private set; } = itemName;

    public string Message { get; private set; } = default!;

    public int Quantity { get; private set; } = quantity;

    public int TotalCost { get; private set; } = totalCost;

    public void SetIsSuccess(bool success)
    {
        IsSuccess = success;
    }

    public void SetMessage(string message)
    {
        Message = message;
    }
}