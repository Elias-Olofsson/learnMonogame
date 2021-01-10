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
    class Objects
    {
        private static List<Objects> listOfObjects = new List<Objects>();
        public static List<Objects> ListOfObjects { get => listOfObjects;}
        //skapar massa grejer
        protected Texture2D texture;
        protected Vector2 position = new Vector2();
        protected Vector2 size = new Vector2();
        protected Rectangle part;

        //gör så att man kommer åt grejerna på andra ställen
        public Vector2 Position
        {
            get => position;
        }

        public Rectangle Part
        {
            get => part;
        }

        //gör en lista med alla grejer
        public Objects()
        {
            listOfObjects.Add(this);
        }
        public virtual void Update()
        {

        }

        //ritar ut texturer vita men de är ju texturer så de har förmodligen egna färger
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Rectangle(position.ToPoint(), size.ToPoint()), Color.White);
        }
    }
}
