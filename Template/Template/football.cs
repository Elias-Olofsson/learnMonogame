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
        //skapar värden
        private Vector2 speed;

        private Random random;

        //gör så att fotbollar har det de värdena och sånt de behöver
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
            part.Location = position.ToPoint();
            part.Size = size.ToPoint();
        }

        //gör så att fotbollen kan ändra position
        public override void Update()
        {
            Move();
            if (position.Y <= 0 || position.Y + size.Y >= Game1.HEIGHT)
            {
                speed.Y *= -1;
            }
            //if (position.X <= 0 || position.X + size.X >= Game1.WIDTH)
            //{
            //    speed.X *= -1;
            //}
            part.Location = position.ToPoint();
        }

        //förklarar för datorn hur rörelse fungerar vilket den borde kunna vid det här laget om den varit uppmärksam och kunnat koppla ihop hur den ritar uppdateringar med hur vi skriver det
        //vi använder dock en konstig version då koden baserar sig på uppdateringars
        private void Move()
        {
            position += speed;
        }

        //gör ett hyffsat random värde som har gränser så att fotbollen alltid startar åt samma håll och inte fastnar
        private float RandomFloat(float min, float max)
        {

            float r = (float)(random.NextDouble() * (max - min) + min); 
            return r;
        }

        //säger vad som händer när något koliderar
        public void Collision()
        {
            speed.X *= -1;
        }

    }
}
