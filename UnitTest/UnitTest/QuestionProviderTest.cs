using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Guess_word_game;
using Moq;

namespace GuaessWordGameTest
{
    [TestClass]
    public class GameServiceTest
    {
        [TestMethod]
        public void TestStart()
        {
            var questionProvider =  new Mock<IQuestionProvider>();

            var question = new Question()
            {
                question = "What colour of oranges?",
                answer = "Oranges"
            };

            questionProvider.Setup(x => x.get()).Returns(question);

            var gameView = new Mock<IGameView>();

            var gameservice = new GameServiceImpl(questionProvider.Object, gameView.Object);

            gameservice.start();

            gameView.Verify(x => x.showQuestion(question));
            gameView.Verify(x => x.showCurrentGuess("*******"));
            
        }
    }
}