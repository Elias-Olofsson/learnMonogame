using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    //planer för att göra spelet lättare att vinna
    /* 
     *     Y:10  
     *  .
     *  . -
     *  .
     *     H(höjd): 3   MH(max höjd): 5   RY(Rita ut Y): Y-(MH-H)/2  10-(5-3)/2
     */
    class Goalkeeper : Objects
    {
        //gör en hastighet
        protected Vector2 speed;

        //int stamina = 1000;

        //sätter värde och sånt för målvakter
        protected Goalkeeper()  
        {
            texture = Assets.Pixel;
            size = new Vector2(20, 200);
            speed = new Vector2(0, 1);
            speed *= 10;
            part = new Rectangle();
            part.Size = size.ToPoint();
        }
        protected void Move(Vector2 speed)
        {

            //stamina--;

            //förklarar hastighet igen
            position += speed;
            part.Location = position.ToPoint();
        }
    }
}
