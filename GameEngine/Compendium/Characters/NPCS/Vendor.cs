﻿// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium.Characters.NPCS;

internal class Vendor(string name) : NPC(name, NPCType.Vendor)
{
}