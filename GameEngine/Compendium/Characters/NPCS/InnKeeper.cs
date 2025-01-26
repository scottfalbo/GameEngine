// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium.Characters.NPCS;

internal class InnKeeper(string name, string flavorText) : NPC(name, NPCType.InnKeeper)
{
    public string FlavorText { get; private set; } = flavorText;
}