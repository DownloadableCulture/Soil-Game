using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class TestState : GameState
{
    public TestState(SpriteFont font, Vector2 windowSize, GameStateManager gameStateManager) : base(font, windowSize, gameStateManager)
    {
       
    }

    public override void Update(GameTime gameTime)
    {
    }

    public override void Draw(SpriteBatch spriteBatch)
    {


        spriteBatch.DrawString(font, "TEST", new Vector2(_windowSize.X/2-100, _windowSize.Y/2), Color.White);
    }
}