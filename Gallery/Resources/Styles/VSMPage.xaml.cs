namespace Gallery.Resources.Styles;

public partial class VSMPage : ContentPage
{
	public VSMPage()
	{
		InitializeComponent();
	}

    private void OnChangedVisualState(object sender, TappedEventArgs e)
    {
		var label = (Label)sender;
		VisualStateManager.GoToState(label, "Tapped");
    }
}