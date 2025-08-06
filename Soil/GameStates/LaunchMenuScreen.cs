using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

public class LaunchMenuScreen : GameState
{

    private PlaceholderButton button1;
    private PlaceholderButton button2;
    private int selectedIndex = 0;
    public LaunchMenuScreen(SpriteFont font, Vector2 windowSize, GameStateManager gameStateManager) : base(font, windowSize, gameStateManager)
    {
        button1 = new PlaceholderButton(new Vector2(100, 100), () => OnButton1Selected());
        button2 = new PlaceholderButton(new Vector2(100, 160), () => OnButton2Selected());

        button1.IsSelected = true;

    }
    private void OnButton1Selected()
    {

        Console.WriteLine("Button 1 Selected!");
    }

    private void OnButton2Selected()
    {

        Console.WriteLine("Button 2 Selected!");
    }
    public override void Update(GameTime gameTime)
    {
        KeyboardState kState = Keyboard.GetState();

        if (kState.IsKeyDown(Keys.Down))
        {
            selectedIndex = (selectedIndex + 1) % 2;  // cycle between 0 and 1
            UpdateSelection();
        }
        else if (kState.IsKeyDown(Keys.Up))
        {
            selectedIndex = (selectedIndex - 1 + 2) % 2;  // cycle up with wraparound
            UpdateSelection();
        }

        // For demo, simulate pressing Enter to "click" the selected button
        if (kState.IsKeyDown(Keys.Enter))
        {
            if (selectedIndex == 0) button1.Select();
            else button2.Select();
        }
    }
    private void UpdateSelection()
    {
        button1.IsSelected = (selectedIndex == 0);
        button2.IsSelected = (selectedIndex == 1);
    }

    public override void Draw(SpriteBatch spriteBatch)
    {
        button1.Draw(spriteBatch);
        button2.Draw(spriteBatch);
    }
}

