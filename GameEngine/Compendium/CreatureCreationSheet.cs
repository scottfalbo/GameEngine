// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace GameEngine.Compendium;

public class CreatureCreationSheet(string name) : CreationSheetBase(name)
{
    public int ExperiencePoints { get; set; }

    public int Level { get; set; }

    public int LootAmount { get; set; }
}