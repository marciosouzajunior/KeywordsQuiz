using KeywordsQuiz.Util;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace KeywordsQuiz
{

    public class KeywordViewModel : BaseViewModel
    {

        private string _scoreLabel;
        public string ScoreLabel
        {
            get { return _scoreLabel; }
            set
            {
                _scoreLabel = value;
                OnPropertyChanged("ScoreLabel");
            }
        }

        private string _timerLabel;
        public string TimerLabel
        {
            get { return _timerLabel; }
            set
            {
                _timerLabel = value;
                OnPropertyChanged("TimerLabel");
            }
        }

        private string _keywordEntry;
        public string KeywordEntry
        {
            get { return _keywordEntry; }
            set
            {
                _keywordEntry = value;
                OnPropertyChanged("KeywordEntry");

                if (value != "")
                    CheckKeyword(value);

            }
        }

        private ObservableCollection<KeywordModel> _keywordsList;
        public ObservableCollection<KeywordModel> KeywordsList
        {
            get { return _keywordsList; }
            set
            {
                _keywordsList = value;
                OnPropertyChanged("KeywordsList");
            }
        }

        // Acessibilidade: propriedade para listar as palavras encontradas.
        public string FoundKeywords
        {
            get
            {
                string result = "";

                foreach (KeywordModel k in KeywordsList)
                    if (k.Found)
                        result += k.Keyword + " e ";

                return result == "" ? "nenhuma" : 
                    result.Remove(result.LastIndexOf(" e "));
            }
        }

        public KeywordViewModel()
        {
            PrepareKeywords();
            UpdateScore();
        }

        public event EventHandler<string> KeyworkFound;

        private void CheckKeyword(string keyword)
        {

            KeywordModel foundKeyword = KeywordsList
                .ToList()
                .Find(k => k.Keyword == keyword);

            if (foundKeyword != null)
            {

                if (!foundKeyword.Found)
                {
                    foundKeyword.Found = true;
                    OnPropertyChanged("FoundKeywords");
                    KeyworkFound?.Invoke(this, keyword);
                }

                KeywordEntry = "";
                UpdateScore();

            }
        }

        private void PrepareKeywords()
        {
            string[] keywordsArr = { "abstract", "continue", "for", "new", "switch", "assert", "default", "goto", "package", "synchronized", "boolean", "do", "if", "private", "this", "break", "double", "implements", "protected", "throw", "byte", "else", "import", "public", "throws", "case", "enum", "instanceof", "return", "transient", "catch", "extends", "int", "short", "try", "char", "final", "interface", "static", "void", "class", "finally", "long", "strictfp", "volatile", "const", "float", "native", "super", "while" };
            KeywordsList = new ObservableCollection<KeywordModel>();
            foreach (var keyword in keywordsArr)
                KeywordsList.Add(new KeywordModel(keyword, false));
        }

        private void UpdateScore()
        {
            ScoreLabel = string.Format("Score: {0}/{1}",
                KeywordsList.Count(k => k.Found == true),
                KeywordsList.Count());


            //if (c == total)
            //{
            //    Application.Current.MainPage.DisplayAlert("KeywordQuiz", "Parabéns, você passou na entrevista!", "Ok");
            //    quer jogar novamente
            // }
        }

    }

}
