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
            Assert.AreEqual(game.keywordsList.Count, 3);
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
            Assert.AreEqual(score, 0);
        }

        [TestMethod]
        public void ProcessInput_ShoudReturnTrue_WhenKeyworkExists()
        {
            Game game = new JavaGame();
            bool result = game.processInput("boolean");
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void ProcessInput_ShoudReturnFalse_WhenKeyworkDoesntExist()
        {
            Game game = new JavaGame();
            bool result = game.processInput("bool");
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void Score_ShouldIncrement_WhenKeyworkExists()
        {
            Game game = new JavaGame();
            game.processInput("boolean");
            Assert.AreEqual(game.score, 1);
        }

        [TestMethod]
        public void Score_ShouldNotIncrement_WhenKeywordAlreadyFound()
        {
            Game game = new JavaGame();
            game.processInput("boolean");
            game.processInput("boolean");
            Assert.AreEqual(game.score, 1);
        }

        [TestMethod]
        public void ProcessInput_ShouldHandleNullValues()
        {
            Game game = new JavaGame();
            game.processInput(null);
        }

        [TestMethod]
        public void Keyword_ShoudHaveNameAndState_WhenCreated()
        {
            Keyword keyword = new Keyword("boolean", false);
            Assert.AreEqual(keyword.Name, "boolean");
            Assert.AreEqual(keyword.Found, false);
        }

    }

}
