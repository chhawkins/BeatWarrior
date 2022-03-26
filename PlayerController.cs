using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gaming
{
    public class PlayerController
    {
        private ContentManager Content;
        private Texture2D playerTexture;

        private KeyboardState currentKeyboardState;
        private KeyboardState priorKeyboardState;
        
        /// <summary>
        /// vector that says where he is by the pixel
        /// </summary>
        private Vector2 position;
        /// <summary>
        /// his position according to the grid
        /// </summary>
        public Vector2 Position;

        public PlayerController(ContentManager content)
        {
            Content = content;

            Position.X = 0;
            Position.Y = 0;
        }

        public void LoadContent()
        {
            playerTexture = Content.Load<Texture2D>("fillerMan");
        }
        public void Update(GameTime gameTime)
        {
            //update positions relative to grid and stuff
            position.X = (Position.X * 64) + Constants.BORDERSIZE;
            position.Y = (Position.Y * 64) + Constants.BORDERSIZE;

            currentKeyboardState = Keyboard.GetState();
            if(currentKeyboardState.IsKeyDown(Keys.D) && priorKeyboardState.IsKeyUp(Keys.D) && Position.X < 11)
            {
                Position.X = Position.X + 1;
            }
            if (currentKeyboardState.IsKeyDown(Keys.S) && priorKeyboardState.IsKeyUp(Keys.S) && Position.Y < 11)
            {
                Position.Y = Position.Y + 1;
            }
            if (currentKeyboardState.IsKeyDown(Keys.A) && priorKeyboardState.IsKeyUp(Keys.A) && Position.X > 0)
            {
                Position.X = Position.X - 1;
            }
            if (currentKeyboardState.IsKeyDown(Keys.W) && priorKeyboardState.IsKeyUp(Keys.W) && Position.Y > 0)
            {
                Position.Y = Position.Y - 1;
            }

            priorKeyboardState = currentKeyboardState;
        }
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(playerTexture, position, Color.Green);
        }
    }
}
