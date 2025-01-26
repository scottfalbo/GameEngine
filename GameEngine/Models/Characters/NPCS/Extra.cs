// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Constants;

namespace GameEngine.Compendium.Characters.NPCS;

internal class Extra(string name) : NPC(name, NPCType.Extra)
{
}