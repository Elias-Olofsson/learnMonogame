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
        public Football() : base(Assets.ball,new Vector2(100,100),new Vector2(5,5))
        {
           
        }
    }
}
