using Gallery.Libraries.Fix;

namespace Gallery;

public partial class AppFlyout : FlyoutPage
{
	public AppFlyout()
	{
		InitializeComponent();
	}

    private void FlyoutPage_IsPresentedChanged(object sender, EventArgs e)
    {
        KeyboardFix.HideKeyBoard();
    }
}