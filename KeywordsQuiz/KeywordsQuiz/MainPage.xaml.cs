using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KeywordsQuiz
{
    public partial class MainPage : ContentPage
    {

        private KeywordViewModel vm;

        public MainPage()
        {
            InitializeComponent();
            vm = new KeywordViewModel();
            BindingContext = vm;
            vm.KeyworkFound += OnKeywordFound;
        }

        private void OnKeywordFound(object sender, string e)
        {
            DisplayAlert("Mensagem", "Keyword " + e + " encontrada.", "OK");
        }

    }
}
