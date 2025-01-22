﻿// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium.Items;

public class Reagent(string name, ReagentType reagentType) : Material(name, MaterialType.Reagent)
{
    public ReagentType ReagentType { get; private set; } = reagentType;
}