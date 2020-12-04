using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Competitor : Goalkeeper
    {
        /// <summary>
        /// In pixels
        /// </summary>
        private double Height = 60;
        private Football football;
       
        public Competitor(Football football)
        {
            speed = new Vector2(0, 1);
            speed *= 10;
            this.football = football;
        }

        public override void Update()
        {
            if (football.Position.Y - 10 > position.Y - Height / 2)
            {
                Move(speed);
            }
            else if (football.Position.Y - 10 < position.Y - Height / 2)
            {
                Move(-speed);
            }
        }
    }
}
