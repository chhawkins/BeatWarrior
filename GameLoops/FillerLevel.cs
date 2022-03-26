using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended.Tiled;
using MonoGame.Extended.Tiled.Renderers;

namespace Gaming.GameLoops
{
    public class FillerLevel : LevelLoop
    {
        public override void LoadContent()
        {
            _tiledMap = Content.Load<TiledMap>("FillerLevelContent/fillerTileMap");
            _tiledMapRenderer = new TiledMapRenderer(graphicsDevice, _tiledMap);

            player = new PlayerController(Content);
            player.LoadContent();
        }
        public override void Update(GameTime gameTime)
        {
            _tiledMapRenderer.Update(gameTime);

            player.Update(gameTime);
        }
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            _tiledMapRenderer.Draw(viewMatrix : Matrix.CreateTranslation((float)Constants.BORDERSIZE, (float)Constants.BORDERSIZE, 0));
            spriteBatch.Begin();
            player.Draw(gameTime, spriteBatch);
            spriteBatch.End();
        }
    }
}
