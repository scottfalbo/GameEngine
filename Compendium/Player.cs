﻿// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

namespace Compendium;

public class Player(string name, CharacterStats stats) : CharacterBase(name, stats)
{
    public int Currency { get; set; } = 0;
}