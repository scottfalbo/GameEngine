// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium.Characters.NPCS;

public class Extra(string name, string flavorText) : NPC(name, NPCType.Extra)
{
    public string FlavorText { get; private set; } = flavorText;
}