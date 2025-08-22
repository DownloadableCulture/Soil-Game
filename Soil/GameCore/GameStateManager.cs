using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GameStateManager
{
    private GameState current;
    private GameState next;

    public StartScreen StartScreen { get; private set; }
    public TestState TestState { get; private set; }
    public LaunchMenuScreen LaunchMenuScreen { get; private set; }
    public Desert1 Desert1 { get; private set; }

    public void SetupGameStates()
    {
        StartScreen = new StartScreen(this);
        TestState = new TestState(this);
        LaunchMenuScreen = new LaunchMenuScreen(this);
        Desert1 = new Desert1(this);

        SetInitialState(StartScreen);
    }

    public void ChangeState(GameState newState)
    {
        next = newState;
    }

    public void Update(GameTime gameTime)
    {
        if (next != null)
        {
            current = next;
            next = null;
        }

        current?.Update(gameTime);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        current?.Draw(spriteBatch);
    }

    public void SetInitialState(GameState state)
    {
        current = state;
    }
}
