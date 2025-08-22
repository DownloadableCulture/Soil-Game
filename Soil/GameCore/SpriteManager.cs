using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

public static class SpriteManager
{
    private static Dictionary<string, Texture2D> sprites = new();

    public static void LoadAll(ContentManager content)
    {
        // UI
        sprites["demoButtonNormal"] = content.Load<Texture2D>("sprites/UI/placeholderbutton2");
        sprites["demoButtonHighlighted"] = content.Load<Texture2D>("sprites/UI/placeholderbutton1");

        // Tiles
        sprites["desertTile1"] = content.Load<Texture2D>("sprites/tiles/desertdemotile1");

        // Characters

        //Backgrounds

    }

    public static Texture2D Get(string key)
    {
        if (!sprites.ContainsKey(key))
            throw new System.Exception($"Sprite '{key}' not found in SpriteManager. Did you forget to load it?");
        
        return sprites[key];
    }
}
