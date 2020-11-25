using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Objects
    {
        protected Texture2D texture;
        protected Vector2 position = new Vector2();
        protected Vector2 size = new Vector2();


        public Objects(Texture2D texture,Vector2 position,Vector2 size)
        {
            this.texture = texture;
            this.position = position;
            this.size = size;
        }

    }
}
