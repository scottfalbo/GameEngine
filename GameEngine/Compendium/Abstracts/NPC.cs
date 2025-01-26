// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium.Abstracts;

public abstract class NPC(string name, NPCType npcType)
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    public string Name { get; private set; } = name;

    public NPCType NPCType { get; private set; } = npcType;
}