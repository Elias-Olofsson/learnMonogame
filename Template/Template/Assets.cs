using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Template
{
    static class Assets
    {
        public static Texture2D Ball { get; private set; }

        public static Texture2D Player { get; private set; }

        public static Texture2D Competitor { get; private set; }

        public static void LoadContent(ContentManager Content)
        {
            Ball = Content.Load<Texture2D>("football");
            //Player = Content.Load<Texture2D>("player");
            //Competitor = Content.Load<Texture2D>("competitor");
        }
    }
}
