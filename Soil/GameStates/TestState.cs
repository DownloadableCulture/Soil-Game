using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class TestState : GameState
{
    public TestState(SpriteFont font, Vector2 windowSize, GameStateManager gameStateManager) : base(font, windowSize, gameStateManager)
    {
        this.gameStateManager = gameStateManager;
    }

    public override void Update(GameTime gameTime)
    {
    }

    public override void Draw(SpriteBatch spriteBatch)
    {


        spriteBatch.DrawString(font, "TEST", new Vector2(WindowSize.X/2-100, WindowSize.Y/2), Color.White);
    }
}