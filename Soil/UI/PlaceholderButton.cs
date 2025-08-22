using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using System;

public class PlaceholderButton : Button
{
 

    
    public PlaceholderButton(Vector2 position, Action onSelect = null, string label = "", SpriteFont font = null)
        : base(
            SpriteManager.Get("demoButtonNormal"),
            SpriteManager.Get("demoButtonHighlighted"),
            position,
            onSelect,
            label,
            font)
    {
    }
}
