using Gallery.View.Lists.Models;

namespace Gallery.View.Lists;

public partial class DataTemplateSelectorPage : ContentPage
{
	public DataTemplateSelectorPage()
	{
		InitializeComponent();

		CollectionViewControl.ItemsSource = MovieList.GetList();
	}
}