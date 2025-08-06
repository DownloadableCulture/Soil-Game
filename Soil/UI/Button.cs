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
    public string Label { get; set; }
    public SpriteFont Font { get; set; }
    public Button(Texture2D normal, Texture2D highlighted, Vector2 position, Action onSelect = null, string label = "", SpriteFont font = null)
    {
        NormalTexture = normal;
        HighlightedTexture = highlighted;
        Position = position;
        OnSelect = onSelect;
        Label = label;
        Font = font;
        IsSelected = false;
    }

    
    public virtual void Draw(SpriteBatch spriteBatch)
    {
        var texture = IsSelected ? HighlightedTexture : NormalTexture;
        spriteBatch.Draw(texture, Position, null, Color.White, 0f, Vector2.Zero, Scale, SpriteEffects.None, 0f);

        if (!string.IsNullOrEmpty(Label) && Font != null)
        {
           
            Vector2 textSize = Font.MeasureString(Label);
            Vector2 buttonSize = new Vector2(texture.Width, texture.Height) * Scale;
            Vector2 textPosition = Position + (buttonSize - textSize) / 2;
            spriteBatch.DrawString(Font, Label, textPosition, Color.White);
        }
    }

    public virtual void Select()
    {
        OnSelect?.Invoke();
    }
}