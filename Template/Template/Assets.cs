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
        public static Texture2D ball;
        public static Texture2D player;
        public static Texture2D competitor;

        public static void LoadContent(ContentManager Content)
        {
            ball = Content.Load<Texture2D>("football");
            player = Content.Load<Texture2D>("player");
            competitor = Content.Load<Texture2D>("competitor");
        }
    }
}
