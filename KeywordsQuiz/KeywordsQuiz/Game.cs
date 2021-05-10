using System.Collections.ObjectModel;
using System.Linq;

namespace KeywordsQuiz
{
    public abstract class Game
    {

        public ObservableCollection<Keyword> keywordsList;
        public int score;

        public Game()
        {
            score = 0;
        }

        public void setKeywords(string[] keywordsArr)
        {
            
            keywordsList = new ObservableCollection<Keyword>();
            foreach (var keyword in keywordsArr)
                keywordsList.Add(new Keyword(keyword, false));

        }

        public bool processInput(string keyword)
        {

            Keyword keyworkMatch = keywordsList
                .ToList()
                .Find(k => k.Name == keyword);

            if (keyworkMatch == null)
                return false;

            // Score only if have not found before
            if (!keyworkMatch.Found)
            {
                keyworkMatch.Found = true;
                score++;
            }

            return true;

        }

    }

    public class Keyword
    {

        public string Name { get; set; }
        public bool Found { get; set; }

        public Keyword(string name, bool found)
        {
            Name = name;
            Found = found;
        }

    }

}