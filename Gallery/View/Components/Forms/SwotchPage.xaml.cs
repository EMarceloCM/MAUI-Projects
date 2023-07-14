namespace Gallery.View.Components.Forms;

public partial class SwotchPage : ContentPage
{
	public SwotchPage()
	{
		InitializeComponent();
	}

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
		if (e.Value == true)
		{
			Application.Current.UserAppTheme = AppTheme.Dark;
		}
		else
		{
			Application.Current.UserAppTheme = AppTheme.Light;
		}
    }
}