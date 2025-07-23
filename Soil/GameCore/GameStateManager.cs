using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GameStateManager
{
    private GameState current;
    private GameState next;

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
