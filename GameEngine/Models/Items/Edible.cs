﻿// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Constants;

namespace GameEngine.Compendium.Items;

internal class Edible : Consumable
{
    public Edible(string name, int adjustmentAmount, Stat targetStat, int quantity = 1)
        : base(name, adjustmentAmount, ConsumableType.Edible, targetStat)
    {
        SetQuantity(quantity);
        SetIsStackable(true);
    }
}