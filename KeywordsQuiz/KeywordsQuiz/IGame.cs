using System;
using System.Collections.Generic;

namespace KeywordsQuiz
{
    public interface IGame
    {

        List<string> keywordsList { get; }

        int score();
        bool CheckKeyword(string v);
    }
}