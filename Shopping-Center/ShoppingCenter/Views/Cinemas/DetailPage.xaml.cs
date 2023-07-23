namespace ShoppingCenter.Views.Cinemas;

[XamlCompilation(XamlCompilationOptions.Skip)]
public partial class DetailPage : ContentPage
{
    private bool firstTime = false;
    public DetailPage()
    {
        InitializeComponent();
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Player.IsVisible = true;
        if (!firstTime)
        {
            //btnPlayPause.TranslateTo(- Player.Width / 2 + 30, Player.Height / 2 - img.Height, 500);
            btnPlayPause.TranslateTo(-170, 70, 500);
            firstTime = true;

            MovieText.TranslateTo(0, -100, 500);
        }
        if (Player.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
        {
            Player.Pause();
            btnPlayPause.Source = ImageSource.FromFile("play.png");
        }
        else
        {
            Player.Play();
            btnPlayPause.Source = ImageSource.FromFile("pause.png");
        }
    }
}