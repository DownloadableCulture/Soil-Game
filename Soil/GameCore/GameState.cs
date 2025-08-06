using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public abstract class GameState
{
    protected static SpriteFont font;
    protected static Vector2 _windowSize;
    protected KeyboardState previousKeyboardState;
    protected GameStateManager gameStateManager;

    public static void InitializeStatic(SpriteFont sharedFont, Vector2 sharedWindowSize)
    {
        font = sharedFont;
        _windowSize = sharedWindowSize;
    }
    public GameState(GameStateManager gameStateManager)
    {
        
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