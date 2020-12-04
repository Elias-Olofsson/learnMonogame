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
        private Vector2 speed;
        private Random random;
        public Football()
        {
            texture = Assets.Ball;
            position = new Vector2(500, 260);
            random = new Random();
            float v = 1.3f;
            speed = new Vector2((float)Math.Cos(RandomFloat(-v,v)), (float)Math.Sin(RandomFloat(-v, v)));
            speed.Normalize();
            size = new Vector2(20, 20);
            speed *= 10;
        }

        public override void Update()
        {
            Move();
            if (position.Y <= 0 || position.Y + size.Y >= Game1.HEIGHT)
            {
                speed.Y *= -1;
            }
            if (position.X <= 0 || position.X + size.X >= Game1.WIDTH)
            {
                speed.X *= -1;
            }

        }

        private void Move()
        {
            position += speed;
        }

        private float RandomFloat(float min, float max)
        {

            float r = (float)(random.NextDouble() * (max - min) + min); 
            return r;
        }

    }
}
