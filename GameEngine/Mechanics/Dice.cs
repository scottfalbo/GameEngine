// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Mechanics;

public class Dice
{
    public int Roll(int sides, int count = 1)
    {
        var total = 0;

        for (var i = 0; i < count; i++)
        {
            total += Roll(sides);
        }

        return total;
    }

    private static int Roll(int sides) => new Random().Next(1, sides + 1);
}