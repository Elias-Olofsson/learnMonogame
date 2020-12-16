using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        //variabel för grafik
        private GraphicsDeviceManager graphics;
        //variabel för att ríta ut spelet
        private SpriteBatch spriteBatch;
        //variabel för fotbollen
        private Football football;
        //variabel för padeln på högra sidan som datorn kontrollerar
        private Competitor c;
        //variabel för padeln på vänster sida som spelaren kontrollerar
        private Player p;
        //bredden på rutan/planen
        public const int WIDTH = 1000;
        //höjden på rutan/planen
        public const int HEIGHT = WIDTH / 3 * 2;

        //fixar rutan/planen och gör så att musen blir synlig
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = WIDTH;
            graphics.PreferredBackBufferHeight = HEIGHT;
            IsMouseVisible = true;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            // TODO: use this.Content to load your game content here
            Assets.LoadContent(Content);
            Assets.CreatePixel(GraphicsDevice);
            football = new Football();
            c = new Competitor(football);
            p  = new Player();
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            //football.Update();
            foreach (Objects obj in Objects.ListOfObjects)
            {
                if (obj != null)//objektet måste finnnas
                {
                    obj.Update();
                }
                if (c.Part.Intersects(football.Part) || p.Part.Intersects(football.Part)) 
                {
                    football.Collision();
                }
            }
            if (football.Position.X < -20 || football.Position.X > WIDTH)
                Exit();
            // TODO: Add your update logic here
            //updaterar flera gånger per sekund
            base.Update(gameTime); 
            
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here.
            //börjar rittiden typ
            spriteBatch.Begin();

            //ritar ut forbollen
            foreach (Objects obj in Objects.ListOfObjects)
            {
                if(obj != null)
                {
                    obj.Draw(spriteBatch);
                }
            }

            
            //slutar rittiden typ
            spriteBatch.End();
            

            base.Draw(gameTime);
        }
    }
}
