using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public abstract class GameState
{
    protected SpriteFont font;
    protected Vector2 _windowSize;
    protected KeyboardState previousKeyboardState;
    protected GameStateManager gameStateManager;
    public GameState(SpriteFont font, Vector2 windowSize, GameStateManager gameStateManager)
    {
        this.font = font;
        _windowSize = windowSize;
        previousKeyboardState = Keyboard.GetState();
        this.gameStateManager = gameStateManager;

    }
    public virtual void Update(GameTime gameTime)
    {
        var currentKeyBoardState = Keyboard.GetState();
        previousKeyboardState = currentKeyBoardState;
    }
    public abstract void Draw(SpriteBatch spriteBatch);
}