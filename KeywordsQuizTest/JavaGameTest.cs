using KeywordsQuiz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace KeywordsQuizTest
{
    [TestClass]
    public class JavaGameTest
    {


        [TestMethod]
        public void SetKeywords_ShoudFillKeywordsList()
        {
            // Arrange
            Game game = new JavaGame();
            // Act
            game.setKeywords(new string[] { "keyword_1", "keyword_2", "keyword_3" });
            // Assert
            Assert.IsTrue(game.keywordsList.Count == 3);
        }

        [TestMethod]
        public void Game_ShouldHaveKeywords_WhenCreated()
        {           
            Game game = new JavaGame();
            int keywordsCount = game.keywordsList.Count();
            Assert.IsTrue(keywordsCount > 0);
        }

        [TestMethod]
        public void Game_ShouldHaveZeroScore_WhenCreated()
        {
            Game game = new JavaGame();
            int score = game.score;
            Assert.IsTrue(score == 0);
        }

        [TestMethod]
        public void Score_ShouldIncrement_WhenKeyworkExists()
        {
            Game game = new JavaGame();
            game.checkKeyword("boolean");
            Assert.AreEqual(game.score, 1);
        }

        [TestMethod]
        public void Score_ShouldNotIncrement_WhenKeywordAlreadyFound()
        {
            Game game = new JavaGame();
            game.checkKeyword("boolean");
            game.checkKeyword("boolean");
            Assert.AreEqual(game.score, 1);
        }

        [TestMethod]
        public void CheckKeyword_ShouldHandleNullValues()
        {
            Game game = new JavaGame();
            game.checkKeyword(null);
        }

    }

}
