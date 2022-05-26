using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Lesson_2_scaling_using_rectangles_PHILIP_GRAHAM
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D circleTexture;
        Rectangle circleRect; 


        Texture2D rectangleTexture;
        Rectangle rectangleRect;
        Rectangle circle1;
        Rectangle circleBackground;

        

        SpriteFont titleFont;




        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here                                      
            circleRect = new Rectangle(50, 25, 50, 50);
            rectangleRect = new Rectangle(65, 125, 150, 50);
            circle1 = new Rectangle(200, 25, 50, 50);
            circleBackground = new Rectangle(0, 0, 300, 200);

            
            base.Initialize();  
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            circleTexture = Content.Load<Texture2D>("Circle");
            titleFont = Content.Load<SpriteFont>("Title"); 
            
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(circleTexture, circleBackground, Color.Yellow);
            _spriteBatch.Draw(circleTexture, circleRect,Color.Black);
            _spriteBatch.Draw(circleTexture, circle1, Color.Black);
            
            _spriteBatch.Draw(rectangleTexture, rectangleRect,Color.Black);
            
            


            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
