using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFX.Core
{
    internal class NPC
    {
        public string name;
        private Texture2D _texture;
        public Vector2 _position;
        public Vector2 _scaling;
        public NPC(Texture2D _texture)
        {
            this._texture = _texture;
        }

        public void playerName(string name)
        {
            this.name = name;
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _position, null, Color.White, 0, Vector2.Zero, _scaling, SpriteEffects.None, 0);

        }
    }
}
