using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public class StartScreen : GameState
{
    public StartScreen(SpriteFont font, Vector2 windowSize, GameStateManager gameStateManager) : base(font, windowSize, gameStateManager)
    {
        
     }

    public override void Update(GameTime gameTime)
    {
        var currentKeyboardState = Keyboard.GetState();
        if (currentKeyboardState.IsKeyDown(Keys.Enter) && !previousKeyboardState.IsKeyDown(Keys.Enter))
        {
            gameStateManager.ChangeState(new TestState(font, _windowSize, gameStateManager));
        }
        previousKeyboardState = currentKeyboardState;
    
    }

    public override void Draw(SpriteBatch spriteBatch)
    {


        spriteBatch.DrawString(font, "Welcome To Soil", new Vector2(_windowSize.X/2-100, _windowSize.Y/2), Color.White);
    }
}