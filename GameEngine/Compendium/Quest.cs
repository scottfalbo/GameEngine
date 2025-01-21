// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium;

public class Quest(string name, string questId) : Item(name, ItemType.Quest)
{
    public string QuestId { get; private set; } = questId;
}