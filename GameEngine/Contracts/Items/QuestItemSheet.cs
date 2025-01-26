// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Contracts.Abstracts;

namespace GameEngine.Contracts.Items;

public class QuestItemSheet(string name, string questId) : ItemSheet(name)
{
    public string QuestId { get; set; } = questId;
}