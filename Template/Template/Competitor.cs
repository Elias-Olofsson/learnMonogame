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
        //private double Height = 200;
        private Football football;

        
       
        public Competitor(Football football)
        {
            //lägger till fotbollen så att den kan hjälpa till med att bestämma rörelsen
            this.football = football;
            //gör så att motståndaren startar på andra sidan planen
            position.X = Game1.WIDTH - size.X;
            part.Location = position.ToPoint();
        }

        //gör så att motståndaren följer fotbollens
        public override void Update()
        {
            if (football.Position.Y + 10 > position.Y + size.Y / 2)
            {
                Move(speed);
            }
            else if (football.Position.Y + 10 < position.Y + size.Y / 2)
            {
                Move(-speed);
            }
        }
    }
}
