using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    /* 
     *     Y:10  
     *  .
     *  . -
     *  .
     *     H: 3   MH: 5   RY: Y-(MH-H)/2  10-(5-3)/2
     */
    class Goalkeeper : Objects
    {
        protected Vector2 speed;
        int stamina = 1000;
        protected Goalkeeper()  
        {
            texture = Assets.Pixel;
        }
        protected void Move(Vector2 speed)
        {
            stamina--;
            position += speed;
        }
    }
}
