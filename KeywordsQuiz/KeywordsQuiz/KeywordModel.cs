﻿using KeywordsQuiz.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeywordsQuiz
{
    public class KeywordModel : BaseViewModel
    {

        public string Keyword { get; set; }

        private bool _found;

        public bool Found
        {
            get { return _found; }
            set
            {
                _found = value;
                OnPropertyChanged("Found");
            }
        }

        public KeywordModel()
        {

        }
        public KeywordModel(string keyword, bool found)
        {
            Keyword = keyword;
            Found = found;
        }

    }
}