using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_word_game
{
    public interface IGameView
    {
        void showSorry(string message);
        void showCongratulations(string message);
        void showCurrentGuess(string message);
        void showQuestion(Question question);
    }
}
