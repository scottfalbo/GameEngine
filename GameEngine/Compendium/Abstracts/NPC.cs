// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium.Abstracts;

public abstract class NPC(string name, NPCType npcType) : GameObjectBase(name, GameObjectType.NPC)
{
    public NPCType NPCType { get; private set; } = npcType;
}