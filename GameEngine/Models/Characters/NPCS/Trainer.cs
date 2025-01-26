// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Constants;

namespace GameEngine.Compendium.Characters.NPCS;

internal class Trainer(string name) : NPC(name, NPCType.Trainer)
{
}