using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended.Tiled;
using MonoGame.Extended.Tiled.Renderers;

namespace Gaming.GameLoops
{
    public abstract class LevelLoop
    {
        public TiledMap _tiledMap;
        public TiledMapRenderer _tiledMapRenderer;

        public GraphicsDevice graphicsDevice;
        public ContentManager Content;

        public PlayerController player;
        public virtual void Initialize(ContentManager content, GraphicsDevice gd)
        {
            graphicsDevice = gd;
            Content = content;
        }
        public abstract void LoadContent();
        public abstract void Update(GameTime gameTime);
        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);
    }
}
