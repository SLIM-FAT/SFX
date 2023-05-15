using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFX
{
    public class Sprite
    {
        private Texture2D _texture;
        public Vector2 _position;
        public float _speed = 3f;
        public Vector2 _scaling = new Vector2(0,0);
        public SpriteEffects _effect;
        public Sprite (Texture2D texture)
        {
            _texture = texture;
        }
        public void Update()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                _position.Y -= _speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                _position.Y += _speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                _position.X -= _speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                _position.X += _speed;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _position, null, Color.White, 0, _position, _scaling, _effect, 0);
                //_spriteBatch.Draw(_spaceship,_position,null,Color.White,0,_position,_scaling,_sprite,0 );
        }
    }
}
