using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

public class LaunchMenuScreen : GameState
{

    private List<PlaceholderButton> buttons = new();
    private int selectedIndex = 0;
    public LaunchMenuScreen(GameStateManager gameStateManager)
    : base(gameStateManager)
    {
        

        float buttonSpacing = 200f;
        float buttonWidth = 360f; //this can be dynamic instead of hardcoded
        float startY = _windowSize.Y / 2 - (buttonSpacing * 1.5f);

        buttons.Add(new PlaceholderButton(new Vector2(_windowSize.X / 2 - buttonWidth / 2, startY + 0 * buttonSpacing), () => OnButtonSelected(0), "Start", font) { Scale = 4f });
        buttons.Add(new PlaceholderButton(new Vector2(_windowSize.X / 2 - buttonWidth / 2, startY + 1 * buttonSpacing), () => OnButtonSelected(1), "Settings", font) { Scale = 4f });
        buttons.Add(new PlaceholderButton(new Vector2(_windowSize.X / 2 - buttonWidth / 2, startY + 2 * buttonSpacing), () => OnButtonSelected(2), "Back", font) { Scale = 4f });

        buttons[0].IsSelected = true;
    }
    private void OnButtonSelected(int index)
    {
        Console.WriteLine($"Button {index + 1} Selected!");

        if (index == 0)
        {
            gameStateManager.ChangeState(new TestState(gameStateManager));
        }
        if (index == 2)
        {
            gameStateManager.ChangeState(new StartScreen(gameStateManager));
        }
    }
    public override void Update(GameTime gameTime)
    {
        KeyboardState currentKeyboardState = Keyboard.GetState();
        if (IsKeyPressed(currentKeyboardState, Keys.Enter))
        {
            buttons[selectedIndex].Select();  // This calls OnButtonSelected(selectedIndex)
        }

        if (IsKeyPressed(currentKeyboardState, Keys.Down))
        {
            selectedIndex = (selectedIndex + 1) % buttons.Count;
            UpdateSelection();
        }
        else if (IsKeyPressed(currentKeyboardState, Keys.Up))
        {
            selectedIndex = (selectedIndex - 1 + buttons.Count) % buttons.Count;
            UpdateSelection();
        }

        if (IsKeyPressed(currentKeyboardState, Keys.Enter))
        {
            buttons[selectedIndex].Select();
        }


        previousKeyboardState = currentKeyboardState;
    }

    private bool IsKeyPressed(KeyboardState current, Keys key)
    {
        return current.IsKeyDown(key) && previousKeyboardState.IsKeyUp(key);
    }

    private void UpdateSelection()
    {
        for (int i = 0; i < buttons.Count; i++)
            buttons[i].IsSelected = i == selectedIndex;
    }

    public override void Draw(SpriteBatch spriteBatch)
    {
        foreach (var button in buttons)
            button.Draw(spriteBatch);
    }
}

