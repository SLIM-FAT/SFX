using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SFX
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;


        private Sprite _mario;
        private bool _mouseVisible;
        private Sprite _mouse;
        private MouseState _mouseState;
       

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = false;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            var texture1 = Content.Load<Texture2D>("mario");
            //var mousetexture = Content.Load<Texture2D>("mouse");

            _mario = new Sprite(texture1)
            {
                _position = new Vector2(70, 70),
                _speed = 5f,
                _scaling = new Vector2(0.1f, 0.1f),
                _input = new Input()
                {
                    Up = Keys.W,
                    Down = Keys.S,
                    Left = Keys.A,
                    Right = Keys.D,
                }
            };

            _mouse = new Sprite(texture1)
            {
                _position = new Vector2(),
                _speed = 5f,
                _scaling = new Vector2(0.1f, 0.1f),
                _input = new Input()
                {
                    Up = Keys.W,
                    Down = Keys.S,
                    Left = Keys.A,
                    Right = Keys.D,
                }
            };


        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            _mouseState = Mouse.GetState();
            _mario.Update();
            //_mousePosition = Vector2(_mouseState.X, _mouseState.Y);
            _mouse._position.X = _mouseState.X;
            _mouse._position.Y = _mouseState.Y;

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
           
            _mario.Draw(_spriteBatch); 
            _mouse.Draw(_spriteBatch);
           
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}