using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public abstract class GameState
{
    protected SpriteFont font;
    protected KeyboardState previousKeyboardState;
    public GameState(SpriteFont font)
    {
        this.font = font;
        previousKeyboardState = Keyboard.GetState();

    }
    public virtual void Update(GameTime gameTime)
    {
        var currentKeyBoardState = Keyboard.GetState();
        previousKeyboardState = currentKeyBoardState;
    }
    public abstract void Draw(SpriteBatch spriteBatch);
}