using Xamarin.Forms;

namespace KeywordsQuiz
{
    public partial class MainPage : ContentPage
    {

        Game game;

        public MainPage()
        {
            InitializeComponent();
            game = new JavaGame();
            BindingContext = game;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            refreshUI();
        }

        private void entryKeyword_TextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = (Entry)sender;
            if (game.processInput(entry.Text))
                refreshUI();                
        }

        private void refreshUI()
        {
            entryKeyword.Text = "";
            labelScore.Text = "Score: " + game.score;
            collectionView.ItemsSource = null;
            collectionView.ItemsSource = game.keywordsList;
        }

    }
}
