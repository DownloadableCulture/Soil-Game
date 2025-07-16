using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public abstract class GameState
{
    protected SpriteFont font;
    protected Vector2 WindowSize;
    protected KeyboardState previousKeyboardState;
    public GameState(SpriteFont font, Vector2 windowSize)
    {
        this.font = font;
        this.WindowSize = windowSize;
        previousKeyboardState = Keyboard.GetState();

    }
    public virtual void Update(GameTime gameTime)
    {
        var currentKeyBoardState = Keyboard.GetState();
        previousKeyboardState = currentKeyBoardState;
    }
    public abstract void Draw(SpriteBatch spriteBatch);
}