namespace Gallery.View.Styles;

public partial class StaticDinamicResource : ContentPage
{
	public StaticDinamicResource()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Resources["TitleColor"] = Color.FromArgb("#00FF00");
    }
}