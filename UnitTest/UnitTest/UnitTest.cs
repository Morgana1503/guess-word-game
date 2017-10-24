using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Guess_word_game;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        IQuestionProvider questionProvider = new QuestionProviderImpl();

        [TestMethod]
        public void TestGet()
        {
            var question = questionProvider.get();
            Assert.IsNotNull(question);
            Assert.IsNotNull(question.answer);
            Assert.IsNotNull(question.question);
        }

        [TestMethod]
        public void TestGetReturns()
        {
            var question1 = questionProvider.get();
            var question2 = questionProvider.get();
            var question3 = questionProvider.get();
            var question4 = questionProvider.get();
            var question5 = questionProvider.get();
            var question6 = questionProvider.get();

            Assert.AreNotEqual(question1, question2);
            Assert.AreNotEqual(question3, question4);
            Assert.AreNotEqual(question5, question6);
        }
    }
}
