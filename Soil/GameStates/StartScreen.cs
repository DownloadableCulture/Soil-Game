using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public class StartScreen : GameState
{
    public StartScreen(SpriteFont font) : base(font)
    {}

    public override void Update(GameTime gameTime)
    {
        var currentKeyboardState = Keyboard.GetState();
        if (currentKeyboardState.IsKeyDown(Keys.Enter) && !previousKeyboardState.IsKeyDown(Keys.Enter))
        {
            // Enter was just pressed!
            // TODO: Switch game state or start game
        }
        previousKeyboardState = currentKeyboardState;
    
    }

    public override void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.DrawString(font, "Welcome To Soil", new Vector2(100, 100), Color.White);
    }
}