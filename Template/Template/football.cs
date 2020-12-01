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
    class Football: Objects
    {
        public Vector2 speed;
        private Random random;
        public Football()
        {
            texture = Assets.ball;
            speed = new Vector2((float)random.NextDouble(), (float)random.NextDouble());

            
        }

        

        public void Move()
        {
            position += speed;
        }

    }
}
