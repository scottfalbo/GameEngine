// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Constants;

namespace GameEngine.Compendium.Abstracts;

internal abstract class NPC(string name, NPCType npcType) : GameObjectBase(name, GameObjectType.NPC)
{
    public NPCType NPCType { get; private set; } = npcType;
}