namespace Gallery.View.CommunityMaui;

public partial class MediaElementPage : ContentPage
{
	public MediaElementPage()
	{
		InitializeComponent();
	}

    private void OnClickedToPlay(object sender, EventArgs e)
    {
		var btn = (Button)sender;
		if(player.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
		{
            player.Pause();
			btn.Text = "Play";
        }
		else
		{
            player.Play();
			btn.Text = "Pause";
        }
    }
}