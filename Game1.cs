using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SFX
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;



        // private Texture2D _spaceship;
        // private Vector2 _position;
        // private Vector2 _scaling = new Vector2(0.1F, 0.1F);
        // private SpriteEffects _sprite;
        private Sprite _mario;
        private Sprite _ship;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
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
            var texture2 = Content.Load<Texture2D>("ship");

            _mario = new Sprite(texture1);
            _mario._position = new Vector2(100,100);
            _mario._scaling = new Vector2(0.7F, 0.7F); //don't set it to 1 and def give it a value cuz otherwise it wont move for some reason (im a dumbass)

            _ship = new Sprite(texture2)
            {
                _position = new Vector2(70, 70),
                _speed = 5f,
                _scaling = new Vector2(0.1f, 0.1f),
            };

            
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            _ship.Update();
            _mario.Update();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _ship.Draw(_spriteBatch);
            _mario.Draw(_spriteBatch); 
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}