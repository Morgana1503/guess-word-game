﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_word_game
{
    public interface IQuestionProvider
    {
        Question get();
    }
}
