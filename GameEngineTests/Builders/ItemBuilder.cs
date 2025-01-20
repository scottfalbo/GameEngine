// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Compendium;

namespace GameEngineTests.Builders;

internal class ItemBuilder
{
    private bool _isStackable = false;
    private string _name = string.Empty;

    public Potion BuildPotion()
    {
        _name = _name == string.Empty ? "Test Potion" : _name;
        var potion = new Potion(_name);

        potion.SetIsStackable(_isStackable);

        return potion;
    }
}