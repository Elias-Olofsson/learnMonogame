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
        //låter andra ställen hämta de olika grejerna
        public static Texture2D Ball { get; private set; }

        public static Texture2D Player { get; private set; }

        public static Texture2D Competitor { get; private set; }

        public static Texture2D Pixel { get; private set; }

        //laddar in visuella grejer
        public static void LoadContent(ContentManager Content)
        {
            Ball = Content.Load<Texture2D>("football");
            Player = Content.Load<Texture2D>("1");
            Competitor = Content.Load<Texture2D>("1");

        }

        //skapar en vit pixel
        public static void CreatePixel(GraphicsDevice graphics)
        {
            Pixel = new Texture2D(graphics, 1, 1);
            Pixel.SetData(new Color[] { Color.White});
        }
    }
}
