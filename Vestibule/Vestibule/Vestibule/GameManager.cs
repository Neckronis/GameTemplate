using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace Vestibule
{
    class GameManager
    {
        GameWindow window;
        Texture2D titleScreen; //temp
        enum GameStates { TitleScreen, Playing, PlayerDead, GameOver };
        GameStates gameState;

        public GameManager()
        {
            window = GlobalManager.Window;
            titleScreen = MediaManager.GetTexture2D("TitleScreen"); //temp
            gameState = GameStates.TitleScreen;
        }

        public void Update(GameTime gameTime)
        {
            switch (gameState)
            {
                case GameStates.TitleScreen:
                    if (InputManager.IsKeyDown(Keys.Space))
                        gameState = GameStates.Playing;
                    break;
                case GameStates.Playing:
                    break;
                case GameStates.PlayerDead:
                    break;
                case GameStates.GameOver:
                    break;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            if (gameState == GameStates.TitleScreen)
            {
                                spriteBatch.Draw(titleScreen, new Rectangle(0, 0, window.ClientBounds.Width, window.ClientBounds.Height), Color.White); //temp
            }
            if ((gameState == GameStates.Playing) ||
            (gameState == GameStates.PlayerDead) ||
            (gameState == GameStates.GameOver))
            {

            }
            if (gameState == GameStates.GameOver)
            {

            }
            spriteBatch.End();
        }
    }
}
