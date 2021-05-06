using KeywordsQuiz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace KeywordsQuizTest
{
    [TestClass]
    public class JavaGameTest
    {


        [TestMethod]
        public void Game_ShouldHaveKeywords_WhenCreated()
        {

            // Arrange
            IGame game = new JavaGame();

            // Act
            int keywordsCount = game.keywordsList.Count();

            // Assert
            Assert.IsTrue(keywordsCount > 0);

        }


        [TestMethod]
        public void Game_ShouldHaveZeroScore_WhenCreated()
        {

            IGame game = new JavaGame();

            int score = game.score();

            Assert.IsTrue(score == 0);

        }

        [TestMethod]
        public void CheckKeyword_ShouldReturnTrue_WhenKeywordExist()
        {

            IGame game = new JavaGame();

            bool exist = game.CheckKeyword("boolean");

            Assert.IsTrue(exist);

        }

        public void CheckKeyword_ShouldReturnFalse_WhenKeywordDoesntExist()
        {

            IGame game = new JavaGame();

            bool exist = game.CheckKeyword("bool");

            Assert.IsFalse(exist);

        }


    }

}
