// ------------------------------------------
// Game Engine: Mechanics and Collections
// ------------------------------------------

using GameEngine.Constants;

namespace GameEngine.Compendium.Abstracts;

internal abstract class GameObjectBase(string name, GameObjectType gameObjectType)
{
    public string? FlavorText { get; private set; }

    public GameObjectType GameObjectType { get; private set; } = gameObjectType;

    public Guid Id { get; private set; } = Guid.NewGuid();

    public string Name { get; private set; } = name;

    public GameObjectBase Clone()
    {
        var gameObject = (GameObjectBase)MemberwiseClone();
        gameObject.Id = Guid.NewGuid();

        return gameObject;
    }

    public void SetFlavorText(string flavorText)
    {
        FlavorText = flavorText;
    }
}