using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class TileMap
{
    private int[,] map;
    private Dictionary<int, Texture2D> tileTextures;
    private int tileSize;

    public int Width => map.GetLength(1);
    public int Height => map.GetLength(0);

    public TileMap(int[,] map, Dictionary<int, Texture2D> tileTextures, int tileSize)
    {
        this.map = map;
        this.tileTextures = tileTextures;
        this.tileSize = tileSize;
    }
    public void Draw(SpriteBatch spriteBatch)
    {
        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                int tileIndex = map[y, x];
                if (tileTextures.ContainsKey(tileIndex))
                {
                    spriteBatch.Draw(tileTextures[tileIndex], new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize), Color.White);
                }
            }
        }
    }  
}