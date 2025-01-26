// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium.Characters.NPCS;

internal class Hostile(string name, Creature creature) : NPC(name, NPCType.Hostile)
{
    public Creature Creature { get; private set; } = creature;
}