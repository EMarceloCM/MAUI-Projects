namespace Gallery.View.Components.Mains;

public partial class ImageButtonPage : ContentPage
{
	bool state = false;
	public ImageButtonPage()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		state = !state;

		string poweroff = "poweroff.png";
		string poweron = "poweron.png";

		var button = (ImageButton)sender;
		button.Source = (state == false) ? ImageSource.FromFile(poweron) : ImageSource.FromFile(poweroff);
    }
}