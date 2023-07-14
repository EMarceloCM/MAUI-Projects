using Gallery.View.Lists.Models;

namespace Gallery.View.Lists;

public partial class BindableLayoutPage : ContentPage
{
	public BindableLayoutPage()
	{
		InitializeComponent();

		var layout = VerticalStackControl;
		var list = MovieList.GetList();

		BindableLayout.SetItemsSource(layout, list);
	}
}