using CommunityToolkit.Maui.Views;
using Gallery.View.CommunityMaui.Popups;

namespace Gallery.View.CommunityMaui;

public partial class PopupPage : ContentPage
{
	public PopupPage()
	{
		InitializeComponent();
	}

    private void OnClickedToOpenPopUp(object sender, EventArgs e)
    {
		var popup = new MyPopup();
		this.ShowPopup(popup);
    }
}