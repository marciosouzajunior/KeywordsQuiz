using System;

namespace KeywordsQuiz
{
    public class GameManager
    {

        IGame game;

        public GameManager()
        {
        }

        public void setGame(IGame game)
        {
            this.game = game;
        }
    }
}