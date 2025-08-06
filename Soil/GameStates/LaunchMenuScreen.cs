using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

public class LaunchMenuScreen : GameState
{

    private PlaceholderButton button1;
    private PlaceholderButton button2;
    private int selectedIndex = 0;
    private KeyboardState previousKeyboardState;
    private Vector2 _windowSize;
    public LaunchMenuScreen(SpriteFont font, Vector2 windowSize, GameStateManager gameStateManager) : base(font, windowSize, gameStateManager)
    {
        _windowSize = windowSize;
        button1 = new PlaceholderButton(new Vector2(_windowSize.X / 2 - 360 / 2, _windowSize.Y / 2 - 100), () => OnButton1Selected())
        {
            Scale = 4f
        };

        button2 = new PlaceholderButton(new Vector2(_windowSize.X / 2 - 360 / 2, _windowSize.Y / 2 + 100), () => OnButton2Selected())
        {
            Scale = 4f
        };

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
        KeyboardState currentKeyboardState = Keyboard.GetState();

        if (IsKeyPressed(currentKeyboardState, Keys.Down))
        {
            selectedIndex = (selectedIndex + 1) % 2;
            UpdateSelection();
        }
        else if (IsKeyPressed(currentKeyboardState, Keys.Up))
        {
            selectedIndex = (selectedIndex - 1 + 2) % 2;
            UpdateSelection();
        }

        if (IsKeyPressed(currentKeyboardState, Keys.Enter))
        {
            if (selectedIndex == 0) button1.Select();
            else button2.Select();
        }


        previousKeyboardState = currentKeyboardState;
    }

    private bool IsKeyPressed(KeyboardState current, Keys key)
    {
        return current.IsKeyDown(key) && previousKeyboardState.IsKeyUp(key);
    }

    private void UpdateSelection()
    {
        button1.IsSelected = selectedIndex == 0;
        button2.IsSelected = selectedIndex == 1;
    }

    public override void Draw(SpriteBatch spriteBatch)
    {
        button1.Draw(spriteBatch);
        button2.Draw(spriteBatch);
    }
}

