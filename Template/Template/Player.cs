using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Template
{
    class Player: Goalkeeper
    {
        public Player()
        {
            texture = Assets.Player;
            position =  new Vector2(0,Game1.HEIGHT/2-100);
            part.Location = position.ToPoint();
        }
    }
}
