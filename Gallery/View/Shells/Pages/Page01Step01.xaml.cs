namespace Gallery.View.Shells.Pages;

public partial class Page01Step01 : ContentPage
{
	public Page01Step01()
	{
		InitializeComponent();
	}

    private void GoBack(object sender, EventArgs e)
    {
		//Rota:	/pg1/Page01Step01
		Shell.Current.GoToAsync("..");
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("../Page01Step02");
    }
}