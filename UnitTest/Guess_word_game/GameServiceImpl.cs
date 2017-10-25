using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_word_game
{
    public class GameServiceImpl : IGameService
    {
        private IQuestionProvider questionProvider;
        private IGameView gameView;

        public GameServiceImpl(IQuestionProvider questionProvider, IGameView gameView)
        {
            this.questionProvider = questionProvider;
            this.gameView = gameView;
        }

        public void GuessLetter(string letter)
        {
            throw new NotImplementedException();
        }

        public void GuessWord(string word)
        {
            throw new NotImplementedException();
        }

        public void start()
        {
            var task = questionProvider.get();
            gameView.showQuestion(task);

            int count = task.answer.Length;

            string currentGuess = "";
            for (int i = 0; i < count; i++)
            {
                currentGuess = currentGuess + "*";
            }


        }
    }
}
