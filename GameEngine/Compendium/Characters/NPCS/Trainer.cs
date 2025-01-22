// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium.Characters.NPCS;

public class Trainer(string name) : NPC(name, NPCType.Trainer)
{
}