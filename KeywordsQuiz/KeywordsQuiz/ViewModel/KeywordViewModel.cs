using KeywordsQuiz.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

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

        public KeywordViewModel()
        {
            PrepareKeywords();
            UpdateScore();
        }

        private void CheckKeyword(string keyword)
        {

            KeywordModel foundKeyword = KeywordsList
                .ToList()
                .Find(k => k.Keyword == keyword);

            if (foundKeyword != null)
            {

                if (foundKeyword.Found)
                {
                    // Já achou, piscar a keyword
                    return;
                }
                else
                {
                    foundKeyword.Found = true;
                }

                KeywordEntry = "";
                UpdateScore();

                //if (c == total)
                //{
                //    Application.Current.MainPage.DisplayAlert("KeywordQuiz", "Parabéns, você passou na entrevista!", "Ok");
                //    quer jogar novamente
                // }

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
        }

    }

}
