﻿// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium.Abstracts;
using GameEngine.Compendium.Constants;

namespace GameEngine.Compendium;

public class Potion : Consumable
{
    public Potion(
        string name,
        int adjustmentAmount,
        Stat targetStat,
        int quantity = 1)
        : base(
            name,
            adjustmentAmount,
            ConsumableType.Potion,
            targetStat)
    {
        SetQuantity(quantity);
        SetIsStackable(true);
    }
}