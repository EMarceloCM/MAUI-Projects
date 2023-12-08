using Jogo_da_Forca.Libraries.Text;
using Jogo_da_Forca.Models;
using Jogo_da_Forca.Repositories;

namespace Jogo_da_Forca
{
    public partial class MainPage : ContentPage
    {
        private bool dmode;
        private Word _word;
        private int _erros = 0;

        public MainPage()
        {
            InitializeComponent();
            dmode = true;

            var repository = new WordRepository();
            _word = repository.GetRandomWord();

            lblTips.Text = _word.Tips;
            lblText.Text = new string('_', _word.Text.Length);
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            string letter = btn.Text;

            var positions = _word.Text.AllIndexesOff(letter);
            if (positions.Count == 0)
            {
                _erros++;
                imgMain.Source = ImageSource.FromFile($"forca{_erros + 1}.png");
                btn.Style = App.Current.Resources.MergedDictionaries.ElementAt(1)["Fail"] as Style;

                await IsGameOver();
                return;
            }
            btn.Style = App.Current.Resources.MergedDictionaries.ElementAt(1)["Sucess"] as Style;

            foreach ( int pos in positions )
            {
                lblText.Text = lblText.Text.Remove(pos, 1).Insert(pos, letter);
            }

            await HasWinner();
        }

        private void GenerateNewWord()
        {
            var repository = new WordRepository();
            _word = repository.GetRandomWord();

            lblTips.Text = _word.Tips;
            lblText.Text = new string('_', _word.Text.Length);
        }

        #region Reset Screen / GameOver / GameWinner
        private async Task IsGameOver()
        {
            if (_erros == 6)
            {
                await DisplayAlert("Perdeu!", "Você foi enforcado!", "Novo Jogo");
                ResetScreen();
            }
        }

        private async Task HasWinner()
        {
            if (!lblText.Text.Contains('_'))
            {
                await DisplayAlert("Parabéns!", "Você ganhou!", "Novo Jogo");
                ResetScreen();
            }
        }

        private void ResetScreen()
        {
            _erros = 0;
            imgMain.Source = ImageSource.FromFile("forca1.png");

            GenerateNewWord();

            ResetVirtualHorizontalKeyBoard((HorizontalStackLayout)KeyBoardContainer.Children[0]);
            ResetVirtualHorizontalKeyBoard((HorizontalStackLayout)KeyBoardContainer.Children[1]);
            ResetVirtualHorizontalKeyBoard((HorizontalStackLayout)KeyBoardContainer.Children[2]);
        }

        private void ResetVirtualHorizontalKeyBoard(HorizontalStackLayout horizontal)
        {
            foreach (Button btn in horizontal.Children.Cast<Button>())
            {
                btn.IsEnabled = true;
                btn.Style = null;
            }
        }

        private void OnButtonClickedResetGame(object sender, EventArgs e)
        {
            ResetScreen();
        }
        #endregion
        private void ChangeTheme(object sender, EventArgs e)
        {
            dmode = !dmode;
            if(dmode )
            {
                Application.Current.UserAppTheme = AppTheme.Dark;
            }
            else
            {
                Application.Current.UserAppTheme = AppTheme.Light;
            }
        }

    }
}