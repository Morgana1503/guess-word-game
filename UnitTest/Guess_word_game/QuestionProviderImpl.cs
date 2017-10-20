using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_word_game
{
    public class QuestionProviderImpl : IQuestionProvider
    {
        Random rnd = new Random();

        Question[] questions =
        {
            new Question()
            {
                question = "How much is 100 + 100 = ?",
                answer = "200"
            },

            new Question()
            {
                question = "What colour of oranges?",
                answer = "Orange"
            },

            new Question()
            {
                question = "What is the first moon of the winter?",
                answer = "December"
            },

            new Question()
            {
                question = "What is the capital of Poland?",
                answer = "Warsaw"
            },

            new Question()
            {
                question = "How old is a seven-year-old child",
                answer = "Seven"
            },

            new Question()
            {
                question = "How to pass the session?",
                answer = "No one don't know this :)"
            }
        };

        public Question get()
        {

            return questions[rnd.Next(questions.Length)];

        }
    }
}