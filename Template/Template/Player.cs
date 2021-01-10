using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace Template
{
    class Player : Goalkeeper
    {
        //bestämmer höjden på spelaren
        private double Height = 60;
        public Player()
        {
            //bestämmer hastigheten
            speed = new Vector2(0, 1);
            speed *= 10;
        }

        //gör så att du rör spelaren upp med "W" och ner med "S"
        public override void Update()
        {
            KeyboardState kstate = Keyboard.GetState();
            if (kstate.IsKeyDown(Keys.W))
            {
                Move(-speed);
            }
            else if (kstate.IsKeyDown(Keys.S))
            {
                Move(speed);
            }
        }
    }
}
