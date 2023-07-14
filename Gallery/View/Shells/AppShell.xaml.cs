using Gallery.View.Shells.Pages;

namespace Gallery.View.Shells;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("pg1/Page01Step01", typeof(Page01Step01));
		Routing.RegisterRoute("pg1/Page01Step02", typeof(Page01Step02));
		Routing.RegisterRoute("pg2/Page02Step01", typeof(Page02Step01WParameters));
	}

    private void BackToGallery(object sender, EventArgs e)
    {
		App.Current.MainPage = new AppFlyout();
    }
}