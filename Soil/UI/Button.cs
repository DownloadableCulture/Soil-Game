using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

public class Button
{
    public Vector2 Position { get; set; }
    public Texture2D NormalTexture { get; set; }
    public Texture2D HighlightedTexture { get; set; }
    public bool IsSelected { get; set; }
    public Action OnSelect { get; set; }
    public float Scale { get; set; } = 1f;
    public Button(Texture2D normal, Texture2D highlighted, Vector2 position, Action onSelect = null)
    {
        NormalTexture = normal;
        HighlightedTexture = highlighted;
        Position = position;
        OnSelect = onSelect;
        IsSelected = false;
    }

    public virtual void Draw(SpriteBatch spriteBatch)
    {
        var texture = IsSelected ? HighlightedTexture : NormalTexture;
        spriteBatch.Draw(texture, Position, null, Color.White, 0f, Vector2.Zero, Scale, SpriteEffects.None, 0f);
    }

    public virtual void Select()
    {
        OnSelect?.Invoke();
    }
}