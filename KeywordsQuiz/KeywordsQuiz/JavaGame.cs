using KeywordsQuiz;
using System.Collections.Generic;

namespace KeywordsQuiz
{
    public class JavaGame : IGame
    {

        public List<string> keywordsList => 
            new List<string>() { "abstract", "continue", "for", "new", "switch", "assert", "default", "goto", "package", "synchronized", "boolean", "do", "if", "private", "this", "break", "double", "implements", "protected", "throw", "byte", "else", "import", "public", "throws", "case", "enum", "instanceof", "return", "transient", "catch", "extends", "int", "short", "try", "char", "final", "interface", "static", "void", "class", "finally", "long", "strictfp", "volatile", "const", "float", "native", "super", "while" };

        public bool CheckKeyword(string keyword)
        {
            return keywordsList.Contains(keyword);
        }

        public int score()
        {
            return 0;
        }

    }
}