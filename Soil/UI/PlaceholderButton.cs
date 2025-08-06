using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using System;

public class PlaceholderButton : Button
{
    private static Texture2D _normalTexture;
    private static Texture2D _highlightedTexture;
    private static bool _isInitialized = false;

    public static void InitializeTextures(ContentManager content)
    {
        _normalTexture = content.Load<Texture2D>("sprites/UI/placeholderbutton2");
        _highlightedTexture = content.Load<Texture2D>("sprites/UI/placeholderbutton1");
        _isInitialized = true;
    }

    public PlaceholderButton(Vector2 position, Action onSelect = null)
        : base(
            _normalTexture ?? throw new Exception("PlaceholderButton textures not initialized!"),
            _highlightedTexture ?? throw new Exception("PlaceholderButton textures not initialized!"),
            position,
            onSelect)
    {
        if (!_isInitialized)
            throw new Exception("Call InitializeTextures before creating PlaceholderButtons");
    }
}