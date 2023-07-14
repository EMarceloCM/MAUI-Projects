using Gallery.View.Lists.Models;

namespace Gallery.View.Lists;

public partial class PickerListPage : ContentPage
{
	public PickerListPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		PickerControl.ItemsSource = MovieList.GetList();
    }
}