namespace Gallery.View.Shells.Pages;

public partial class Page01 : ContentPage
{
	public Page01()
	{
		InitializeComponent();
	}

    private void GoToStep01(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("Page01Step01");
    }
}