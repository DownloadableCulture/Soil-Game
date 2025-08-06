using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Soil;

public class Game1 : Game
{
    public Vector2 WindowSize { get; private set; }
   
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private SpriteFont mainFont;
    private GameStateManager gameStateManager;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;

        _graphics.PreferredBackBufferWidth = 1600;
        _graphics.PreferredBackBufferHeight = 900;
        _graphics.ApplyChanges();
    }

    protected override void Initialize()
    {
        WindowSize = new Vector2(
        GraphicsDevice.Viewport.Width,
        GraphicsDevice.Viewport.Height
    );

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        mainFont = Content.Load<SpriteFont>("Fonts/8BitDragon");
        PlaceholderButton.InitializeTextures(Content);
        gameStateManager = new GameStateManager();
        gameStateManager.SetupGameStates(mainFont, WindowSize);

        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here
        gameStateManager.Update(gameTime);
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.DeepPink);

        _spriteBatch.Begin();

        gameStateManager.Draw(_spriteBatch);

        _spriteBatch.End();

        base.Draw(gameTime);

        
    }
}
