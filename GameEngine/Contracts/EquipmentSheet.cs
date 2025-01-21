﻿// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Constants;

namespace GameEngine.Contracts;

public class EquipmentSheet(string name, EquipmentType type) : BaseSheet(name)
{
    public int Damage { get; set; }

    public int Price { get; set; }

    public EquipmentType Type { get; set; } = type;
}