using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public class StartScreen : GameState
{
    public StartScreen(GameStateManager gameStateManager) : base(gameStateManager)
    {
        
     }

    public override void Update(GameTime gameTime)
    {
        var currentKeyboardState = Keyboard.GetState();
        if (currentKeyboardState.IsKeyDown(Keys.Enter) && !previousKeyboardState.IsKeyDown(Keys.Enter))
        {
            gameStateManager.ChangeState(new LaunchMenuScreen(gameStateManager));
        }
        previousKeyboardState = currentKeyboardState;
    
    }

    public override void Draw(SpriteBatch spriteBatch)
    {
    string text = "Welcome To Soil\n\n\nPress ENTER to Start";
    Vector2 textSize = font.MeasureString(text);
    Vector2 position = new Vector2(
        (_windowSize.X - textSize.X) / 2,
        (_windowSize.Y - textSize.Y) / 2
    );
    spriteBatch.DrawString(font, text, position, Color.White);
}
}