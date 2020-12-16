using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Template
{
    class Player: Goalkeeper
    {
        private double Height = 60;
        public Player()
        {
            speed = new Vector2(0, 1);
            speed *= 10;
        }
        public override void Update()
        {
            KeyboardState kstate = Keyboard.GetState();
            if (kstate.IsKeyDown(Keys.W))
            {
                Move(speed);
            }
            else if (kstate.IsKeyDown(Keys.S))
            {
                Move(-speed);
            }
        }
    }
}
