using CommunityToolkit.Maui.Views;

namespace Gallery.View.CommunityMaui.Popups;

public partial class MyPopup : Popup
{
	public MyPopup()
	{
		InitializeComponent();
	}

    private void OnClickedToCloseScreen(object sender, EventArgs e)
    {
		this.Close();
    }
}