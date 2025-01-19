// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public class PlayerCreationSheet(string name) : CreationSheetBase(name)
{
    public int Currency { get; set; }
}