﻿// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium.Characters.NPCS;

internal class InnKeeper(string name, string flavorText) : NPC(name, NPCType.InnKeeper)
{
}