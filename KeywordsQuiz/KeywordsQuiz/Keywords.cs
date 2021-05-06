namespace KeywordsQuiz
{

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