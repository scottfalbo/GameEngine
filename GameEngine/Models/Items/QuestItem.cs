// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Constants;

namespace GameEngine.Compendium.Items;

internal class QuestItem(string name, string questId) : Item(name, ItemType.Quest)
{
    public string QuestId { get; private set; } = questId;
}