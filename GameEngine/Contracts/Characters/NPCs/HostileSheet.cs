// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Contracts.Abstracts;

namespace GameEngine.Contracts.Characters.NPCs;

public class HostileSheet(string name, CreatureSheet creatureSheet) : NPCSheet(name)
{
    public CreatureSheet CreatureSheet { get; set; } = creatureSheet;
}