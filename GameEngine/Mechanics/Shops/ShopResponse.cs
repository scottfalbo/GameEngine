// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Mechanics.Shops;

public class ShopResponse()
{
    public bool IsSuccess { get; private set; }

    public string Message { get; private set; } = default!;

    public void SetIsSuccess(bool success)
    {
        IsSuccess = success;
    }

    public void SetMessage(string message)
    {
        Message = message;
    }
}